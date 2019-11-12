using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Activatated( object sender, EventArgs args)
        {
            Navigation.PushAsync(new MyPage());
        }

        // comment added
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Loan>();
                var loans = conn.Table<Loan>().ToList();
                loanListView.ItemsSource = loans;
            }

        }
    }
}
