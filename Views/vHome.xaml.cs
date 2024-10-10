using System.Linq.Expressions;

namespace glasluisaS2B.Views;

public partial class vHome : ContentPage
{
    private object dFechas;

    public vHome()
	{
		InitializeComponent();
	}

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
		try
		{
			if (pkCiudades.SelectedIndex == -1)
			{
				DisplayAlert("Alerta", "No hay seleccion ", "Cerrar");
            }
			else
			{
                string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();//0.1.2
                DisplayAlert("Alerta", "SELECCIONASTE" + dato, "Cerrar");
            }

			//FECHAS
			string fecha = dpkFecha.Date.ToString();
            lblFecha.Text = "LA FECHA SELECCIONADA ES " + fecha;
		}
		catch(Exception ex)

    {
            //DisplayAlert ("Alerta", "No hay soluicion : error" +ex.Message, "Cerrar");

        }
    }
}


