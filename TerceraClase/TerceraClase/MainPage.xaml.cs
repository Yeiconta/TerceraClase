﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TerceraClase
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        async void handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            await DisplayAlert("Completado",
                               "Se ha completado la carga de la pagina",
                               "OK");
        }

    }
}
