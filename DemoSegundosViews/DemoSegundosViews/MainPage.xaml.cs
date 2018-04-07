using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoSegundosViews
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}
        //public void picMusic_changed(object sender, EventArgs e)
        //{
        //    var elementoSeleccionado = pickMusic.SelectedItem.ToString();
        //    DisplayAlert("Musica", elementoSeleccionado, "Aceptar");
        //}
        //private void Simular(object sender, EventArgs e)
        //{
        //    var progreso = ProcessProgress.Progress;
        //    if (progreso == 1)
        //    {
        //        ProcessProgress.ProgressTo(.1, 250, Easing.Linear);
        //    }
        //    else
        //    {
        //        ProcessProgress.ProgressTo(1, 250, Easing.Linear);
        //    }

        //}
        //private void sbNombre_pressed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Search Bar", "Estoy buscando ....", "Aceptar");
        //}
        //private void sbNombre_changed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Cmbiando", "Estoy cambiando...", "Aceptar");
        //}
        //private void slEdad_change(object sender, EventArgs e)
        //{
        //    lbEdad.Text = sldEdad.Value.ToString();
        //}
        //private void stpCantidad_change(object sender, EventArgs e)
        //{
        //    lbCantidad.Text = stpEdad.Value.ToString();
        //}
        //private void swichEvent(object sender, EventArgs e)
        //{
        //    if (swiDEC.IsToggled)
        //    {
        //        DisplayAlert("Mensaje", "Estoy Activado", "Aceptar");
        //    }
        //    else
        //    {
        //        DisplayAlert("Mensaje", "Estoy desactivado", "Aceptar");
        //    }
        //}
        private async void wvActualidad_navigated(object sender, EventArgs e)
        {
            await DisplayAlert("WebView", "Ha finalizado la carga", "Aceptar");
        }

    }
}
