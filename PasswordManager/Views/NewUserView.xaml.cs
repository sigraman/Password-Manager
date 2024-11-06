namespace PasswordManager.Views;

public partial class NewUserView : ContentPage
    {
        public NewUserView()
        {
            InitializeComponent();
        }

        private void NxtPage(object sender, EventArgs e)
        {

        }

        private void OldUsr(object sender, EventArgs e)
        {

        }

        private async void CreateAccBtn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView());
        }

        private void LoginBtn(object sender, EventArgs e)
        {

        }
    }
