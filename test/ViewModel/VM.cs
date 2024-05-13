using System.ComponentModel;
using System.Windows.Input;

namespace k11
{
    public class VM
    {
        ICommand EnterButton { get; }
        ICommand CreateAccountButton { get; }

        private string messageBlock;
        public string MessageBlock
        {
            get { return messageBlock; }
            set
            {
                messageBlock = value;
                //OnPropertyChanged(nameof(MessageBox));
            }
        }

        public VM()
        {
            EnterButton = new RelayCommand(Enter);
            CreateAccountButton = new RelayCommand(CreateAccount);

            messageBlock = "test";
        }

        private void Enter(object parameter) {}
        private void CreateAccount(object parameter) { }
    }
}
