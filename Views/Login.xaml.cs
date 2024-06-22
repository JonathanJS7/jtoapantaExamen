namespace jtoapantaExamen.Views;

public partial class Login : ContentPage
{
    string[] usuarios = { "estudiante", "uisrael"};
    string[] contrasenas = { "moviles", "2024"};

    public Login()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        bool credencialesValidas = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuario && contrasenas[i] == contrasena)
            {
                credencialesValidas = true;
                break;
            }
        }

        if (credencialesValidas)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO O CONTRASEÑA INCORRECTOS", "OK");
        }
    }
}

