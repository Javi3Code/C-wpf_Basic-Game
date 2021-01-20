using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace JCode.Games
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class WildCardGame : Window
    {
        /**
         * 
         * Atributos y constantes a utilizar durante el juego.
         * 
         */
        private RadioButton[] rdbtn;
        private const String CPU_STONE = "piedraR";
        private const String CPU_PAPER = "papelR";
        private const String CPU_SCISSORS = "tijeraR";
        private string[] cpuOption = { CPU_STONE, CPU_PAPER, CPU_SCISSORS };
        private QuestionsGame parent;
        private String userSelect = null;
        private String cpuSelect = null;
        private bool someOptionSelected = false;
        private int questIndex;

        /**
         * 
         * Constructor , tiene dos parametros, un QuestionsGame padre, y un entero index.
         * Dentro se llama al metodo initialize.
         * 
         */
        public WildCardGame(QuestionsGame questionsGame, int index) => Initialize(questionsGame, index);

        /**
         * 
         * Inicializamos los componentes, asignamos los parametros a sus atributos, para 
         * trabajar globalmente y agrupamos los radiobuttons en un array.
         * 
         */
        private void Initialize(QuestionsGame questionsGame, int index)
        {
            InitializeComponent();
            parent = questionsGame;
            questIndex = index;
            GroupRdbtn();
        }

        private void GroupRdbtn()
        {
            rdbtn = new RadioButton[] { piedra, papel, tijera };
        }

        /**
         * Metodo manejado por evento Click, si un radiobutton es seleccionado se actualiza la imagen
         * mostrada se asigna la seleccion del usuario y se activa el flag de que una opcion ha 
         * sido seleccionada.
         */
        private void ShowUserSelection(object sender, RoutedEventArgs e)
        {
            var selection = sender as RadioButton;
            var iBrush = new ImageBrush();
            LoadImgSelected(selection.Name, user);
            userSelect = selection.Name;
            someOptionSelected = true;
        }

        /*
         * 
         * Metodo manejado por evento Click, arranca el juego, si no se ha seleccionado niguna opcion,
         * simplemente se avisa al usuario que debe hacerlo.
         * De haberla, se asigna un valor de manera random a la seleccion de la cpu, se activa la imagen 
         * perteneciente a ese valor.
         * Si la propiedad suerte no es igual a null, se hacen las operaciones finales del juego.
         * 
         */
        private void StartGame(object sender, RoutedEventArgs e)
        {
            if (someOptionSelected)
            {
                cpuSelect = RandomSelection;
                LoadImgSelected(cpuSelect, cpu);
                if (Luck != null)
                {
                    MakeFinalGameOperations();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar alguna opción para jugar!!");
            }
        }

        /**
         * 
         * Si Luck es true se añade como buena la respuesta de la 
         * pregunta desde donde arranco la partida.
         * Se deshabilitan los radiobuttons de las respuestas, y se avisa de que ha ganado.
         * Por último se coloca una imagen para decorar un poco la victoria.
         * 
         * Si no ha habido suerte se advierte de ello.
         */
        private void MakeFinalGameOperations()
        {
            if (Luck == true)
            {
                parent.userResponses.Add(questIndex, parent.realResponses.GetValueOrDefault(questIndex));
                parent.DisableComponentsOnQuestion(questIndex);
                var message = "Enhorabuena, has ganado!\nLa pregunta se dará por acertada.";
                var img = "fond";
                SetImgFinal(message, img);
            }
            else
            {
                var message = "Ooohh, has perdido!\nAún puedes responder la pregunta, suerte!";
                var img = "loser";
                SetImgFinal(message, img);
            }
        }

        /**
         * 
         * metodo para establecer la imagen final del juego.
         * 
         */
        private void SetImgFinal(string message, string img)
        {
            var iBrush = new ImageBrush();
            var streamInfo = Application.GetResourceStream(new Uri("Rfirstgame\\" + img + ".png", UriKind.Relative));
            var temp = BitmapFrame.Create(streamInfo.Stream);
            imgUser.Source = temp;
            MessageBox.Show(message);
            ComodinClose();
        }

        /**
         * 
         * Propiedad que comprueba si hay empate, victoria,...
         * 
         */
        private bool? Luck
        {
            get
            {
                bool? victory = null;
                if (userSelect.Equals(cpuSelect.Substring(0, cpuSelect.Length - 1)))
                {
                    MessageBox.Show("EMPATE!!\nPrueba otra vez...");
                }
                else
                {
                    victory = DetermineWinner;
                }
                return victory;
            }
        }

        /**
         * 
         * Propiedad que determina el ganador, segun la seleccion del usuario
         * le pasa al metodo VictoryConfirmed el valor del material al que gana.
         * 
         */
        private bool? DetermineWinner
        {
            get
            {
                bool? victory = false;
                var stone = rdbtn[0].Name;
                switch (userSelect)
                {
                    case "piedra":
                        victory = VictoryConfirmed(CPU_SCISSORS);
                        break;
                    case "papel":
                        victory = VictoryConfirmed(CPU_STONE);
                        break;
                    case "tijera":
                        victory = VictoryConfirmed(CPU_PAPER);
                        break;
                }
                return victory;
            }
        }

        /**
         * Metodo que comprueba si la seleccion de la maquina es igual al material pasado
         * 
         */
        private bool VictoryConfirmed(String material)
        {
            return cpuSelect.Equals(material) ? true : false;
        }

        /**
         * Metodo para cargar la imagen del material correspondiente segun la seleccion.
         */
        private void LoadImgSelected(string str, Grid grid)
        {
            var iBrush = new ImageBrush();
            var pathToImage = "Rfirstgame\\" + str + ".png";
            var streamInfo = Application.GetResourceStream(new Uri(@pathToImage, UriKind.Relative));
            var temp = BitmapFrame.Create(streamInfo.Stream);
            iBrush.ImageSource = temp;
            grid.Background = iBrush;
        }

        /**
         *Metodo para generar la seleccion de la maquina de manera random. 
         */
        private string RandomSelection => cpuOption[RandomNumberGenerator.GetInt32(0, 3)];

        /**
         * Metodo para cerrar la ventana si se quiere.
         */
        private void CloseFGameWindow(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(null, "¿Seguro que quieres salir?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification);

            if (result.Equals(MessageBoxResult.Yes))
            {
                ComodinClose();
            }
        }

        /**
         * Metodo que cierra la ventana y hace visible a la ventana padre.
         */
        private void ComodinClose()
        {
            parent.Visibility = Visibility.Visible;
            Close();
        }
    }
}
