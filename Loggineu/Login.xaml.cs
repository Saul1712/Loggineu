using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loggineu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if(usuario == "usaul" && contraseña == "ss7845")
            {
                Navigation.PushAsync(new Inicio());

            }
            else
            {
                DisplayAlert("Alerta","El usuario/contraseña Incorrectos ", "Cerrar");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                
            }
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}