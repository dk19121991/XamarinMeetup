﻿using System;
using Xamarin.Forms;

namespace PushPopPage
{
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

		async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Page2());
		}
	}
}
