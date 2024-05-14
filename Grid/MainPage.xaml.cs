using Microsoft.Maui.Controls;
using System;

namespace Grid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNumeroClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var numero = (string)button.CommandParameter;
            numeroLabel.Text += numero;
        }

        private void OnDialClicked(object sender, EventArgs e)
        {
            numeroLabel.Text = "";
        }
    }
}
