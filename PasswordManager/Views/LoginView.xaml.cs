namespace PasswordManager.Views;

public partial class LoginView : ContentPage

    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void SignIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PasswordListView());
        }
    }
