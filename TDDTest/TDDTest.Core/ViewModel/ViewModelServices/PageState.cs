namespace TDDTest.Core.ViewModel.ViewModelServices
{
    public class PageState
    {
        public PageState(string statusName)
        {
            this.StatusName = statusName;
        }

        public string StatusName { get; private set; }
    }
}