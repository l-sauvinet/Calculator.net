using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculateurLucas
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        float First_nb = 0;
        float Second_nb = 0;
        float Result = 0;
        int Operation = '0';

        private void BTN_Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string number = btn.Content.ToString();
            Display_nb(number);
        }

        private void BTN_plus_Click(object sender, RoutedEventArgs e)
        {
            First_nb = float.Parse(TB_display.Text);
            TB_display.Text = "";
            Operation = '+';
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            First_nb = float.Parse(TB_display.Text);
            TB_display.Text = "";
            Operation = '-';
        }

        private void BTN_Multiple_Click(object sender, RoutedEventArgs e)
        {
            First_nb = float.Parse(TB_display.Text);
            TB_display.Text = "";
            Operation = '*';
        }

        private void BTN_Divise_Click(object sender, RoutedEventArgs e)
        {
            First_nb = float.Parse(TB_display.Text);
            TB_display.Text = "";
            Operation = '/';
        }

        private void BTN_Egale_Click(object sender, RoutedEventArgs e)
        {
            Second_nb = float.Parse(TB_display.Text);

            switch (Operation)
            {
                case '+':
                    Result = First_nb + Second_nb;
                    break;
                case '-':
                    Result = First_nb - Second_nb;
                    break;
                case '*':
                    Result = First_nb * Second_nb;
                    break;
                case '/':
                    if (Second_nb != 0)
                        Result = First_nb / Second_nb;
                    else
                        MessageBox.Show("Division par zéro n'est pas autorisée.");
                    break;
            }

            TB_display.Text = Result.ToString();
        }

        private void BTN_Clr_Click(object sender, RoutedEventArgs e)
        {
            First_nb = 0;
            Second_nb = 0;
            Result = 0;
            Operation = '0';
            TB_display.Text = "";

        }

        public void Display_nb (string number)
        {
            if (TB_display.Text == "0")
            {
                TB_display.Text = number;
            }
            else
            {
                TB_display.Text = TB_display.Text + number;
            }
        }

        private void BTN_Virgule_Click(object sender, RoutedEventArgs e)
        {
            if (!TB_display.Text.Contains(","))
            {
                TB_display.Text = TB_display.Text + ",";
            }
        }

        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            float radians = valeur * (float)Math.PI / 180;
            Result = (float)Math.Sin(radians);
            TB_display.Text = Result.ToString();
        }

        private void BTN_Cos_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            float radians = valeur * (float)Math.PI / 180;
            Result = (float)Math.Cos(radians);
            TB_display.Text = Result.ToString();
        }

        private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            float radians = valeur * (float)Math.PI / 180;
            Result = (float)Math.Tan(radians);
            TB_display.Text = Result.ToString();
        }

        private void BTN_Carre_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            Result = valeur * valeur;
            TB_display.Text = Result.ToString();
        }

        private void BTN_Racine_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            if (valeur >= 0)
                Result = (float)Math.Sqrt(valeur);
            else
                MessageBox.Show("Racine carée d'un nombre négatif n'est pas autorisée.");
            TB_display.Text = Result.ToString();
        }

        private void BTN_Inverse_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            if (valeur != 0)
                Result = 1 / valeur;
            else
                MessageBox.Show("Division par zéro n'est pas autorisée.");
            TB_display.Text = Result.ToString();
        }

        private void BTN_Signe_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            Result = -valeur;
            TB_display.Text = Result.ToString();
        }

        private void BTN_Pourcentage_Click(object sender, RoutedEventArgs e)
        {
            float valeur = float.Parse(TB_display.Text);
            Result = valeur / 100;
            TB_display.Text = Result.ToString();
        }

        private void BTN_Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (TB_display.Text.Length > 1)
                TB_display.Text = TB_display.Text.Substring(0, TB_display.Text.Length - 1);
            else
                TB_display.Text = "0";
        }

        private void BTN_Pi_Click(object sender, RoutedEventArgs e)
        {
            TB_display.Text = Math.PI.ToString();
        }

        private void BTN_E_Click(object sender, RoutedEventArgs e)
        {
            TB_display.Text = Math.E.ToString();
        }
    }
}