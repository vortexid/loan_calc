using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestForms
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

            nameEntry.Text = "Kredit";
            amountEntry.Text = "100000.00";
            interestEntry.Text = "5.0";
            periodEntry.Text = "5";

        }

        private void Calc_Loan(object sender, EventArgs e) {

            Loan loan = new Loan()
            {
                name = nameEntry.Text,
                amount =  Decimal.Parse(amountEntry.Text),
                interest = Decimal.Parse(interestEntry.Text),
                period = Decimal.Parse(periodEntry.Text),

            };


            Double payment = CalcPayment((Double)loan.interest, (Double)loan.period, (Double)loan.amount);

            for(int i = 0; i < loan.period; i++)
            {

            }

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH)) {
                
                conn.CreateTable<Loan>();
                int cnt = conn.Insert(loan);

                if(cnt>0)
                    DisplayAlert("Saving loan", "Loan saved !", "Ok");
            }
        }

        private void CalcLoanPlan()
        {

        }

        private Double CalcInterest(double K, double a, double rate, int per) {
            double r =  Math.Pow((double)1 + rate, per);
            return ((K * r * rate) - (a * (r - 1)));
        }

        private double CalcPayment(double rate, double n, double K ) {
            double r1 = Math.Pow((double)1 + rate, n);
            double a = rate / (r1 - 1) * (K * r1);
            return a;
        }
    }
}
