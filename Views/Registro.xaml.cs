namespace jtoapantaExamen.Views;

public partial class Registro : ContentPage
{
    public Registro(string usuario)
    {
        InitializeComponent();
        lblNombre.Text = usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(txtmonto.Text, out double montoInicial) && montoInicial<1500)
        {
            double montoRestante = 1500-montoInicial;
            double porcentaje = 1500 * 0.04;
            double cuotas = (montoRestante / 4) + (porcentaje/4);

            txtPago.Text = "$ " +cuotas.ToString();
        }
        else
        {

            txtPago.Text = "El monto inicial no puede ser mayor a $1500";
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen());
    }
}