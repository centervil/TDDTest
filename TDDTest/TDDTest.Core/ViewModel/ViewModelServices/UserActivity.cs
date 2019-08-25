namespace TDDTest.Core.ViewModel.ViewModelServices
{
    public class UserActivity
    {
        public UserActivity(string commandName)
        {
            this.CommandName = commandName;
        }

        public string CommandName { get; private set; }
    }
}