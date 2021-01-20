using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JCode.Games
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class QuestionsGame : Window
    {
        private Button[] arrayBtn;
        private RadioButton[] rdBtn1;
        private RadioButton[] rdBtn2;
        private RadioButton[] rdBtn3;
        private RadioButton[] rdBtn4;
        private RadioButton[] rdBtn5;
        private RadioButton[] rdBtn6;
        private RadioButton[] rdBtn7;
        public Dictionary<int, string> userResponses;//Diccionario con las respuestas del usuario
        public Dictionary<int, string> realResponses;//Diccionario con las respuestas verdaderas
        private int note; //Atributo donde guardaremos la nota
        private int wildCards;//Numero de comodines, se determina el valor desde XAML
        private bool answered = false;//Atributo para saber si ha sido respondido todo

        /**
         * Constructor
         */
        public QuestionsGame() => Initialize();

        /**
         * Metodo donde se inicializan los componentes, ponemos los botones-comodines en un array,
         * tambien los radiobutons, se inicializan los mapas de respuestas, y se establece cuantos comodines.
         */
        private void Initialize()
        {
            InitializeComponent();
            PutWildCardInArray();
            PutRdBtnsInArrays();
            InitializeRealResponses();
            InitializeUserResponsesMap();
            wildCards = int.Parse((string)lblComodinesCount.Content);
        }
        /**
         * Se inicializa el mapa de respuestas de usuario.
         */
        private void InitializeUserResponsesMap() => userResponses = new Dictionary<int, string>();
        /**
        * Se asigna el valor del mapa de respuestas verdaderas.
        */
        private void InitializeRealResponses() => realResponses = QuestionsUtils.GetInstance().ResponseMap;

        /**
         * Colocamos los radiobutton en sus arrays correspondientes.
         */
        private void PutRdBtnsInArrays()
        {
            rdBtn1 = new RadioButton[] { rdb11, rdb12, rdb13 };
            rdBtn2 = new RadioButton[] { rdb21, rdb22, rdb23 };
            rdBtn3 = new RadioButton[] { rdb31, rdb32, rdb33 };
            rdBtn4 = new RadioButton[] { rdb41, rdb42, rdb43 };
            rdBtn5 = new RadioButton[] { rdb51, rdb52, rdb53 };
            rdBtn6 = new RadioButton[] { rdb61, rdb62, rdb63 };
            rdBtn7 = new RadioButton[] { rdb71, rdb72, rdb73 };
        }

        /**
         * Colocamos los botones-comodin en un array.
         */
        private void PutWildCardInArray() => arrayBtn = new Button[] { btnComodin1, btnComodin2, btnComodin3, btnComodin4, btnComodin5, btnComodin6, btnComodin7 };

        /**
         * Metodo para cerrar la ventana principal si se quiere.
         */
        private void ClosePrincipalWindow(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(null, "¿Seguro que quieres salir?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification);

            if (result.Equals(MessageBoxResult.Yes))
            {
                Close();
            }
        }

        /**
         * Metodo manejado por evento de Click para iniciar el juego de comodin si esque quedan comodines.
         */
        private void InitComodinGame(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.IsEnabled = false;
            if (wildCards > 0)
            {
                RegulateCount();
                InitGame(int.Parse(btn.Name[btn.Name.Length - 1] + ""));
            }
        }

        /**
         * Metodo manejado por evento de Click para arrancar el ultimo juego.
         */
        private void InitUltimateGame(object sender, RoutedEventArgs e)
        {
            new UltimateGame().Show();
            Close();
        }

        /**
         * Metodo para regular la cuenta de comodines, se modifica el valor del label que indica la cantidad,
         * en caso de que no queden se deshabilita el resto de botones.
         */
        private void RegulateCount()
        {
            wildCards--;
            lblComodinesCount.Content = wildCards + "";
            if (wildCards == 0)
            {
                DisableWildCardBtns();
            }
        }

        /**
         * Se inicia el juego de Comodin, piedra, papel o tijera, se oculta esta ventana.
         */
        private void InitGame(int index)
        {
            new WildCardGame(this, index).Show();
            this.Visibility = Visibility.Hidden;
        }

        /**
         * Metodo para deshabilitar los botones-comodin restantes.
         */
        private void DisableWildCardBtns()
        {
            foreach (Button btn in arrayBtn)
            {
                if (btn.IsEnabled)
                {
                    btn.IsEnabled = false;
                }
            }
        }

        /**
         * Metodo manejado por evento MouseEnter, se cambia el tamaño del boton.
         */
        private void BtnEnterEffect(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            btn.Width = btn.Width - 3;
            btn.Height = btn.Height - 3;
        }

        /**
         * Metodo manejado por evento MouseLeave, se cambia el tamaño del boton.
         */
        private void BtnResetProps(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            btn.Width = btn.Width + 3;
            btn.Height = btn.Height + 3;
        }
        /**
         * Metodo manejado por evento Click, se validan respuestas y se obtiene la nota.
         * Dependiendo de la nota se hace una cosa u otra.
         */
        private void ValidateAndGetNote(object sender, RoutedEventArgs e)
        {
            CalculateNote();
            lblNote.Content = this.note + "";
            bool isBetween4And7 = this.note <= 6 && this.note >= 5;
            if (isBetween4And7)
            {
                lastChance.Visibility = Visibility.Visible;
            }
            else if (note == 7)
            {
                MessageBox.Show("Enhorabuena, has ganado!!\n Una Victoria absoluta, vuelve pronto " + Login.USER_PASS + ".");
                Close();
            }
            else if (answered)
            {
                MessageBox.Show("Vaya, que pena, has perdido!!\n No te vengas abajo, vuelve pronto " + Login.USER_PASS + ".");
                Close();
            }
        }

        /**
         * Metodo para calcular la nota. Se recorren y comparan los mapas.
         */
        private void CalculateNote()
        {
            if (userResponses.LongCount() == 7)
            {
                answered = true;
                for (var i = 1; i < 8; i++)
                {
                    var uRes = userResponses.GetValueOrDefault(i);
                    var rRes = realResponses.GetValueOrDefault(i);
                    if (uRes.Equals(rRes))
                    {
                        note++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes responder a todas las preguntas.");
            }

        }
        /**
         * Metodo manejado por evento Click, evento de cada radiobutton.
         * Se establece la respuesta y se deshabilitan los componentes relacionados
         * a esa pregunta.
         * Se añade la respuesta al mapa.
         */
        private void Rdb_Checked(object sender, RoutedEventArgs e)
        {
            var rdbtn = sender as RadioButton;
            var index = rdbtn.Name.Length - 2;
            var question = int.Parse(rdbtn.Name[index] + "");
            DisableComponentsOnQuestion(question);
            userResponses.Add(question, (string)rdbtn.Content);
        }

        /**
         * Se deshabilitan los radiobutton y el button-comodin relacionado a la pregunta.
         */
        public void DisableComponentsOnQuestion(int question)
        {
            switch (question)
            {
                case 1:
                    DisableRdbtn(rdBtn1);
                    DisableWildCardBtn(1);
                    break;
                case 2:
                    DisableRdbtn(rdBtn2);
                    DisableWildCardBtn(2);
                    break;
                case 3:
                    DisableRdbtn(rdBtn3);
                    DisableWildCardBtn(3);
                    break;
                case 4:
                    DisableRdbtn(rdBtn4);
                    DisableWildCardBtn(4);
                    break;
                case 5:
                    DisableRdbtn(rdBtn5);
                    DisableWildCardBtn(5);
                    break;
                case 6:
                    DisableRdbtn(rdBtn6);
                    DisableWildCardBtn(6);
                    break;
                case 7:
                    DisableRdbtn(rdBtn7);
                    DisableWildCardBtn(7);
                    break;
            }
        }

        /**
         * Se deshabilita el button-comodin de cierta pregunta.
         */
        private void DisableWildCardBtn(int value)
        {
            foreach (Button btn in arrayBtn)
            {
                var name = btn.Name;
                if (int.Parse("" + name[name.Length - 1]) == value)
                {
                    if (btn.IsEnabled)
                    {
                        btn.IsEnabled = false;
                    }
                }
            }
        }
        /**
        * Se deshabilitan los radiobutton de cierto array.Relacionado a la pregunta.
        */
        private void DisableRdbtn(RadioButton[] rdBtn)
        {
            foreach (RadioButton rdb in rdBtn)
            {
                rdb.IsEnabled = false;
            }
        }
    }

}
