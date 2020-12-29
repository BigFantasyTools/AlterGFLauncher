using AlterGFLauncher.Properties;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterGFLauncher
{
    public class GameInstanceManager
    {
        private Account Account;
        private StateGameInstanceEnumeration StateGameInstance;
        private Action<StateGameInstanceEnumeration, string> UpdateStateFunction;
        private WebBrowser WebBrowser;
        public GameInstanceManager(Account account, Action<StateGameInstanceEnumeration, string> UpdateStateFunction)
        {
            this.Account = account;
            this.UpdateStateFunction = UpdateStateFunction;
            StateGameInstance = StateGameInstanceEnumeration.Stop;
        }

        public void StartSession()
        {
            StateGameInstance = StateGameInstanceEnumeration.Starting;
            SendStateUpdate();
            string loginPageHtml = Resources.login
                .Replace("{PASSWORD}", Account.UncryptedPassword)
                .Replace("{ID}", Account.Id)
                .Replace("{IDCLIENT}", Settings.IdClient);

            WebBrowser = new WebBrowser();
            WebBrowser.DocumentText = loginPageHtml;
            WaitForCode();
        }

        private async void WaitForCode()
        {
            Regex regexCode = new Regex("code=(.*)$");
            Match regexMatch = null;
            int i = 0;
            while (i < Settings.TimeoutBeforeCode)
            {
                await Task.Delay(10);
                regexMatch = regexCode.Match(WebBrowser.Url.AbsoluteUri);
                if (regexMatch.Success)
                {
                    ResetCookies();
                    StartGame(regexMatch.Groups[1].Value);
                    return;
                }
                i += 10;
            }

            Match match = Regex.Match(WebBrowser.DocumentText, @"<div class=""messages error"">((\s|.)[^<]*)<");

            StateGameInstance = StateGameInstanceEnumeration.Error;
            string error = Strings.UNKNOWNERROR_IDENTIFICATION;

            if (match.Success)
                error = match.Groups[1].Value.Trim();
            else if (WebBrowser.Url.AbsoluteUri.Contains("missing"))
                error = Strings.ERROR_IDCLIENT;

            SendStateUpdate(error);
        }

        private void StartGame(string code)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = Settings.GrandFantasiaWorkingPath;
            _processStartInfo.FileName = Settings.GrandFantasiaExecutable;
            _processStartInfo.Arguments = "EasyFun  -a " + code + "  -p xlwlogin";

            Action processDelegate = delegate
            {
                Process process = new Process();
                process.StartInfo = _processStartInfo;
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GFInstance_Exited);
                process.Start();
            };

            string error = "";
            try
            {
                processDelegate.Invoke();
                StateGameInstance = StateGameInstanceEnumeration.Started;
            }
            catch (Exception)
            {
                error = Strings.ERROR_EXE;
                StateGameInstance = StateGameInstanceEnumeration.Error;
            }
            SendStateUpdate(error);
        }

        private void ResetCookies()
        {
            WebBrowser.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())");
        }

        private void GFInstance_Exited(object sender, System.EventArgs e)
        {
            StateGameInstance = StateGameInstanceEnumeration.Stop;
            SendStateUpdate();
        }

        private void SendStateUpdate(string errorMessage = "")
        {
            UpdateStateFunction(StateGameInstance, errorMessage);
        }
    }
}
