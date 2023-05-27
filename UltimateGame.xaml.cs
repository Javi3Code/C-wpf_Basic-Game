using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JCode.Games
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class UltimateGame : Window
    {
        /**
         * Determinados atributos que usaremos a lo largo del codigo.
         * el tablero, un array tridimensional, img, un array de imagenes(solo las referenciamos
         * en esa estructura de datos para facilitar las cosas). Los turnos, la ronda del juego.
         * 
         */
        private bool?[,] board;
        private Image[] img = new Image[9];
        private const bool STUDENT_TURN = true;
        private const bool TEACHER_TURN = false;
        private int round = 0;

        /**
         * 
         * Propiedad de la clase, turno actual.
         * 
         */
        private bool Turn { get; set; } = true;

        /**
         * 
         * Constructor: Inicializamos los componentes, cargamos el array tridimensional y
         * el array de imagenes.
         * 
         */
        public UltimateGame()
        {
            InitializeComponent();
            LoadBoolArrays();
            LoadImageArray();
        }


        /**
         * Metodo en el que se guardan las referencias a las imagenes de los botones.
         * 
         */
        private void LoadImageArray() => img = new Image[] { ce, on, tw, th, fo, fi, si, se, ei };

        /**
         * Metodo para cargar el tablero, array tridimensional. Todos los valores bool inicializados a null.
         */
        private void LoadBoolArrays() => board = new bool?[3, 3] { { null, null, null }, { null, null, null }, { null, null, null } };


        /**
         * 
         * Metodo principal del juego, manejado por evento Click, en el setea la ronda.
         * Se pone la imagen que corresponde al boton clickado. Ponemos el valor en el tablero, 
         * a partir de la ronda 5, que es cuando ya puede haber un ganador, comprobamos si lo 
         * hay. En cada ronda se termina por llamar al metodo Shift, que hace los cambios de turno
         * correspondientes.
         * Si se llega a la ronda 9 y hay empate se inicia el juego de nuevo.
         * 
         */
        private void Click(object sender, RoutedEventArgs e)
        {
            round++;
            var btn = sender as Button;
            PutImage(btn);
            PutValue(btn.Name[btn.Name.Length - 2], btn.Name[btn.Name.Length - 1]);
            bool winner = false;
            if (round >= 5)
            {
                winner = CheckIfThereIsAWinner();
            }
            if (!winner && round == 9)
            {
                MessageBox.Show("Empate, prueba otra vez...");
                new UltimateGame().Show();
                Thread.Sleep(300);
                this.Close();
            }
            Shift();
        }

        /**
         * 
         * Metodo para comprobar si existe ganador. Lo comprueba, de haberlo comprueba quien es 
         * y lanza mensaje correspondiente, para despues cerrar la aplicacion.
         * 
         */
        private bool CheckIfThereIsAWinner()
        {
            var winner = false;
            winner = CheckBoard();
            if (winner)
            {
                string message = null;
                if (Turn)
                {
                    message = "Enhorabuena!!...Has ganado!!\nSupiste cómo aprovechar la oportunidad.\nSigue así.";
                }
                else
                {
                    message = "Vaya...Seguro que pronto lo logras.\nHas estado muy cerca\nNos vemos pronto";
                }
                MessageBox.Show(message);
                Close();
            }
            return winner;
        }

        /**
         * 
         * Metodo donde se comprueba si hay ganador, se recorre una lista de combinaciones posibles.
         * Recorro la lista de dos formas, comentada usando Linq, y con programación funcional.
         * Sencillamente se busca el valor true y se devuelve si tiene valor.
         * 
         */
        private bool CheckBoard()
        {
            List<bool?> lst = LstOfCombinations();
            return lst.Find(e => e == true).HasValue;
            // var query = from value in lst where value == true select value;
            //return query.Count() > 0;
        }


        /**
         * 
         * Metodo que devuelve una lista de combinaciones posibles.
         * 
         */
        private List<bool?> LstOfCombinations()
        {
            var lst = new List<bool?>();
            lst.Add(board[0, 0] != null && board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2]);
            lst.Add(board[1, 0] != null && board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2]);
            lst.Add(board[2, 0] != null && board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2]);
            lst.Add(board[0, 0] != null && board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0]);
            lst.Add(board[0, 1] != null && board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1]);
            lst.Add(board[0, 2] != null && board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2]);
            lst.Add(board[0, 0] != null && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]);
            lst.Add(board[0, 2] != null && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]);
            return lst;
        }

        /**
         * Metodo para poner el valor en el tablero segun el turno que toque. 
         */
        private void PutValue(char column, char row)
        {
            board[int.Parse(column + ""), int.Parse(row + "")] = Turn;
        }

        /**
         * 
         * Metodo para poner la imagen en el boton.
         * 
         */
        private void PutImage(Button btn)
        {

            foreach (Image image in img)
            {
                if (btn.Name.StartsWith(image.Name))
                {
                    image.Source = Piece;
                }
            }
        }

        /**
         * 
         * Propiedad Shape, devuelve la url que corresponda para la imagen que toca poner.
         * 
         */
        private String Shape
        {
            get
            {
                if (Turn)
                {
                    return "Rsecondgame/circle.png";
                }
                return "Rsecondgame/cruise.png";
            }
        }

        /**
         * 
         * Metodo shift, cambia la alarma de turno, establece el valor de turno.
         * 
         */
        private void Shift()
        {
            ChangeAlarm(); ;
            Turn = Turn != STUDENT_TURN;
        }

        /**
         * 
         * Metodo para cambiar la imagen del piloto que marca quien tiene el turno.
         * 
         */
        private void ChangeAlarm()
        {
            var imgS = turnStudent.Source;
            var imgT = turnTeacher.Source;
            turnStudent.Source = imgT;
            turnTeacher.Source = imgS;
        }

        /**
         * 
         * Metodo para cerrar la aplicacion, se advierte antes.
         * 
         */
        private void Close(object sender, RoutedEventArgs e)
        {

            var result = MessageBox.Show(null, "¿Seguro que quieres salir?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification);

            if (result.Equals(MessageBoxResult.Yes))
            {
                Close();
            }
        }

        /**
         * 
         * Propiedad Pieza retorna la correspondiente según el turno.
         * 
         */
        public ImageSource Piece
        {
            get
            {
                return Turn ? circle.Source : cruise.Source;
            }

        }

    }


}
