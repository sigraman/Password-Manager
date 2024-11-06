using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PasswordManager.Views;

public partial class PasswordListView : ContentPage
    {
        public ObservableCollection<PasswordRow> Passwords { get; set; }

        public PasswordListView()
        {
            InitializeComponent();

            Passwords = new ObservableCollection<PasswordRow>
        {
            new PasswordRow { UserID = 1, PasswordID = 1, Platform = "Facebook", Password = "sk2ksn0!" },
            new PasswordRow { UserID = 1, PasswordID = 2, Platform = "Google", Password = "g0gl#123!" },
            new PasswordRow { UserID = 1, PasswordID = 3, Platform = "Spotify", Password = "m#si#4me!" },
            new PasswordRow { UserID = 1, PasswordID = 4, Platform = "YouTube", Password = "yt#ube$pass" },
            new PasswordRow { UserID = 1, PasswordID = 5, Platform = "Apple", Password = "app!e$2023" }
        };

            BindingContext = this;
            MyCollectionView.ItemsSource = Passwords;
        }

        private void CopyPassToClipboard(object sender, EventArgs e)
        {
        }

        private void EditPassword(object sender, EventArgs e)
        {
        }

        private void DeletePassword(object sender, EventArgs e)
        {
        }

        private async void AddNewPassword(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPasswordView());
        }

        public class PasswordRow : BindableObject, INotifyPropertyChanged
        {
            public int UserID { get; set; }
            public int PasswordID { get; set; }
            public string Platform { get; set; } = "";
            private string _pass = "";
            private bool _isShown = false;
            private bool _editing = false;

            public string Password
            {
                get => _pass;
                set
                {
                    _pass = value;
                    OnPropertyChanged();
                }
            }

            public bool IsShown
            {
                get => _isShown;
                set
                {
                    _isShown = value;
                    OnPropertyChanged(nameof(IsShown));
                    OnPropertyChanged(nameof(ShowPass));
                }
            }

            public bool ShowPass => !_isShown;

            public bool Editing
            {
                get => _editing;
                set
                {
                    _editing = value;
                    OnPropertyChanged(nameof(Editing));
                    OnPropertyChanged(nameof(ShowToggle));
                }
            }

            public bool ShowToggle => !_editing;
        }
    }
