using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnRepaso.Vistas
{	
	public partial class Inicio : ContentPage
	{	
		public Inicio ()
		{
			InitializeComponent ();
		}

       private void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
			string usuario = "Bienvenido "+ txtUsuario.Text;

			Navigation.PushAsync(new Registro(usuario));
        }
    }
}

