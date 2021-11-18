using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace MauiTelerikControlsDisappear
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TelerikGrid.ItemsSource = new[]
            {
                new { Col1 = "AAA", Col2 = 50 },
                new { Col1 = "BBB", Col2 = 55 },
                new { Col1 = "CCC", Col2 = 60 },
            };
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Container.Children.Remove(TelerikGrid);
            Container.Children.Add(TelerikGrid);
        }
    }
}
