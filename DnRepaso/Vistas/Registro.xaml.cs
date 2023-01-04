using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnRepaso.Vistas
{	
	public partial class Registro : ContentPage
	{	
		public Registro (string usuario)
		{
			InitializeComponent ();
			lblUsuario.Text = usuario;

		}

       private void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
			try
			{
				string ap = "";
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                double valor = precio * cantidad;
                DisplayAlert("Valor Total del Producto", "El valor total es " + valor.ToString(), "Cerrar");
            }
			catch (Exception ex)
			{
				DisplayAlert("Alerta", ex.Message, "Cerra");
			}
			
        }
    }
}

