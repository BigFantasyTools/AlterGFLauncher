using AlterGFLauncher.Forms;
using System.Collections.Generic;
using System.Linq;

namespace AlterGFLauncher
{
    public class AccountUserControlManager
    {
        public List<AccountUserControl> AccountUserControls { get; private set; }

        private MainForm MainForm { get; set; }

        public AccountUserControlManager(List<Account> accounts, MainForm mainForm)
        {
            AccountUserControls = new List<AccountUserControl>();
            MainForm = mainForm;
            UpdateAccountUserControl(accounts);
        }

        public void UpdateAccountUserControl(List<Account> accounts)
        {
            AccountUserControls.AddRange(
                accounts.Where(x => !AccountUserControls.Any(y => y.Account.Id == x.Id)).
                Select(x => new AccountUserControl(x, MainForm)).
                ToArray());

            AccountUserControls.RemoveAll(x => !accounts.Any(y => x.Account.Id == y.Id));
            AccountUserControls.ForEach(x => x.RefreshControl());
        }
    }
}
