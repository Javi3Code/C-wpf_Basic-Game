using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace JCode.Games
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public const string USER_PASS = "752B";

        public Login() => Initialize();

        /**
         * 
         * En el metodo initialize inicializamos los componentes.
         * Y le damos el foco al txtinput de usuario.
         * 
         */
        private void Initialize()
        {
            InitializeComponent();
            txtUser.Focus();
        }


        /**
         * 
         * Metodo manejado en un evento Click para cerrar la ventana de login.
         * Preguntamos para asegurar.
         * 
         * 
         */
        private void CloseLoginWindow(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(null, "¿Seguro que quieres salir?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification);

            if (result.Equals(MessageBoxResult.Yes))
            {
                Close();
            }
        }


        /**
         * 
         * Metodo para cambiar color de fuente, se maneja por eventos, MouseEnter y MouseLeave.
         * Dependiendo del color cambia a uno u otro al entrar y salir del rango del boton.
         * 
         */
        private void ChangeColorFont(object sender, MouseEventArgs e)
        {
            btnOk.Foreground = btnOk.Foreground.Equals(Brushes.WhiteSmoke) ? Brushes.DarkCyan : Brushes.WhiteSmoke;
        }

        /**
         * 
         * Metodo para validar datos y continuar e iniciar el juego, si todo esta en orden.
         * Se maneja por evento Click.
         * 
         */
        private void ValidateAndContinue(object sender, RoutedEventArgs e)
        {
            var userOk = true;
            var passOk = true;
            userOk = ValidateUser();
            passOk = ValidatePass();
            if (userOk && passOk)
            {
                InitGame();
            }
        }
        /**
         * 
         * Metodo para iniciar el juego.
         * Se cierra la ventana principal.
         * 
         */
        private void InitGame()
        {
            var qGame = new QuestionsGame();
            Close();
            qGame.Show();
        }

        /**
         * 
         * Metodo para validar el password.Si no es correcta se pone en rojo el borde.
         * Y aparece un texto encima de textbox lanzando un mensaje de advertencia.
         * 
         */
        private bool ValidatePass()
        {
            if (!txtPass.Password.ToString().Equals(USER_PASS))
            {
                passErrorLbl.Content = "Invalid password";
                txtPass.BorderBrush = Brushes.Red;
                return false;
            }

            return true;
        }

        /**
         * 
         * Metodo para validar el user. Si no es correcto se pone en rojo el borde.
         * Y aparece un texto encima de textbox lanzando un mensaje de advertencia.
         * 
         */
        private bool ValidateUser()
        {
            if (!txtUser.Text.Equals(USER_PASS))
            {
                userErrorLbl.Content = "Invalid username";
                txtUser.BorderBrush = Brushes.Red;
                return false;
            }

            return true;
        }

        /**
         * 
         * Metodo manejado por evento GotFocus, comprueba si los label de advertencia estan limpios.
         * Si no lo están quiere decir que anteriormente ha habido un error, con lo que procede a
         * limpiar tanto txtuser como txtpass, en el caso de "encenderse" el label de user, si es el de 
         * password solo se limpiara este.
         * Tambien se resetean los bordes.
         * 
         */
        private void Txt_FocusChanged(object sender, RoutedEventArgs e)
        {
            var empty = "";
            if (!userErrorLbl.Content.Equals(empty))
            {
                userErrorLbl.Content = empty;
                CleanTxtUser(empty);
                CleanTxtPass(empty);
                txtUser.BorderBrush = Brushes.WhiteSmoke;

            }
            if (!passErrorLbl.Content.Equals(empty))
            {
                passErrorLbl.Content = empty;
                CleanTxtPass(empty);
                txtPass.BorderBrush = Brushes.WhiteSmoke;

            }
        }

        /**
         * 
         * Metodo para limpiar txtuser. 
         * 
         */
        private void CleanTxtUser(string empty)
        {
            if (!txtUser.Text.Equals(empty))
            {
                txtUser.Text = empty;
            }
        }
        /**
       * 
       * Metodo para limpiar txtpass. 
       * 
       */
        private void CleanTxtPass(string empty)
        {
            if (!txtPass.Password.ToString().Equals(empty))
            {
                txtPass.Password = empty;
            }
        }
    }
}
