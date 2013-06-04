using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AttachedBehavior.Helpers;

namespace AttachedBehavior.ViewModels
{
    class ViewModel : INotifyPropertyChanged
    {
        private ICommand showMessageCommand;
        private string message;
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ViewModel()
        {
            this.Message = "Initialize!";
        }

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.message = value;
                    this.OnPropertyChanged("Message");
                }
            }
        }
        
        public ICommand ShowMessage
        {
            get
            {
                if (this.showMessageCommand == null)
                {
                    this.showMessageCommand = new RelayCommand(() =>
                    {
                        this.Message = string.Format("Command Executed at {0: HH:MM:ss}",DateTime.Now);
                    });
                }
                return this.showMessageCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
