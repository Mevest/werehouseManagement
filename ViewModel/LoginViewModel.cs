using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Security;
using System.Runtime.InteropServices;
using System.Windows;
using System.Net.Mail;
using System.Net;

namespace warehouseManagement.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private SecureString _password;
        private string _errorMessage = "Wrong password";
        private bool _isViewVisible = true;


        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }

            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }


        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverPassCommand("",""));
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;

            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
            {
                validData = false;
            }
            else
                validData = true;

            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            string correctPassword = "admin";
            SecureString securePassword = new SecureString();
            foreach(char c in correctPassword)
            {
                securePassword.AppendChar(c);
            }



            if(Username == "admin" && IsPasswordValid(securePassword,_password))
            IsViewVisible = false;
            else
            {
                MessageBox.Show(ErrorMessage);
                CreateTimeoutTestMessage();
                Application.Current.Shutdown();
            }
        }

        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

        private bool IsPasswordValid(SecureString referencePassword, SecureString password)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(password);
                string plainTextPassword = Marshal.PtrToStringUni(valuePtr);

                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(referencePassword);
                string plainTextReferencePassword = Marshal.PtrToStringUni(valuePtr);

                return plainTextReferencePassword.Equals(plainTextPassword, StringComparison.Ordinal);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        public static void CreateTimeoutTestMessage()
        {
            string to = "maciej.ciemienga@gmail.com";
            string from = "warehousemanagementmaciejtest@gmail.com";
            string subject = "Secure Information";
            string body = @"Someone try to log in to your warehouse. Please check out the cameras";
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.google.com");
            client.Port = 587;
            Console.WriteLine("Changing time out from {0} to 100.", client.Timeout);
            client.Timeout = 100;
            // Credentials are necessary if the server requires the client 
            // to authenticate before it will send e-mail on the client's behalf.
            client.Credentials = CredentialCache.DefaultNetworkCredentials;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTimeoutTestMessage(): {0}",
                      ex.ToString());
            }
        }

    }
}