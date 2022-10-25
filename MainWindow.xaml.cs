using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Input;

namespace PairOnHаnds
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer _soundPlayer = null;
        private Stream stream;



        public MainWindow()
        {
            InitializeComponent();


            _soundPlayer = new SoundPlayer();
            _soundPlayer.SoundLocation = "Vaga.wav";
            //_soundPlayer.Load();
            //_soundPlayer.PlayLooping();





        }
        Pair pair1 = new Pair();
        Pair pair2 = new Pair();
        Pair answer = new Pair();


        private void one_KeyUp(object sender, KeyEventArgs e)
        {
            int One = 0;

            if (e.Key == Key.Space)
            {
                try
                {
                    if (!(int.TryParse(one.Text, out One)))
                    {
                        throw new ArgumentException();

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;
                }
                if (One == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    one.Text = null;
                    return;
                }

                if (!(One % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    one.Text = null;
                    return;

                }
                pair1.One = One;

                two.IsReadOnly = false;
                two.IsEnabled = true;
                two.Focus();
                one.IsReadOnly = true;

            }




        }

        private void two_KeyUp(object sender, KeyEventArgs e)
        {
            int Two = 0;

            if (e.Key == Key.Space)
            {
                try
                {
                    if (!(int.TryParse(two.Text, out Two)))
                    {
                        throw new ArgumentException();

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;
                }
                if (Two == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    two.Text = null;
                    return;
                }
                if (!(Two % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    two.Text = null;

                    return;

                }


              
                pair1.Two = Two;
                three.IsReadOnly = false;
                three.IsEnabled = true;
                three.Focus();
                two.IsReadOnly = true;
            }

        }
        private void three_KeyUp(object sender, KeyEventArgs e)
        {
            int Three = 0;

            if (e.Key == Key.Space)
            {
                try
                {
                    if (!(int.TryParse(three.Text, out Three)))
                    {
                        throw new ArgumentException();

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;
                }
                if (Three == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    two.Text = null;
                    return;
                }


                if (!(Three % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    three.Text = null;
                    return;
                }
                pair2.One = Three;
                four.IsReadOnly = false;    
                four.IsEnabled = true;
                four.Focus();
                three.IsReadOnly = true;
            }
        }


        private void four_KeyUp(object sender, KeyEventArgs e)
        {
            int Four = 0;
            if (e.Key == Key.Space)
            {
                try
                {

                    if (!(int.TryParse(four.Text, out Four)))
                    {
                        throw new ArgumentException();

                    }





                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;

                }
                if (Four == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    two.Text = null;
                    return;
                }

                if (!(Four % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    four.Text = null;
                    return;

                }
                pair2.Two = Four;
                four.IsReadOnly = true; 

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Jumbo.Text = null;
            pair1.Multiplication(pair1, pair2, answer);
            Jumbo.Text += $"{pair1.One}*{pair2.One}="+Convert.ToString(answer.One) + ";\n ";
            Jumbo.Text += $"{pair2.One}*{pair1.One}="+Convert.ToString(answer.Two);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Jumbo.Text = null;
            pair1.Multiplication(pair1, answer);
            Jumbo.Text += $"Первая пара значений {answer.One};{answer.Two}";
            pair2.Multiplication(pair2, answer);
            Jumbo.Text += $"Вторая пара значений {answer.One};{answer.Two}";


        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разраб:Денисов Олег Андреевич\n Задание: Создать класс Pair (пара четных чисел). Создать необходимые методы и свойства. \r\nОпределить метод перемножения пар (а, b) * (с, d) = (а * c, b * d). Создать перегруженный метод для удвоения пары чисел");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Jumbo.IsReadOnly = true;
            one.Focus();
            two.IsEnabled = false;
            three.IsEnabled = false;
            four.IsEnabled = false;


        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            one.Text = null;
            one.IsReadOnly = false;
            one.Focus();
            two.Text = null;
            three.Text = null;
            four.Text = null;
            //two.IsReadOnly = false; 
            //three.IsReadOnly = false;
            //four.
        }
    }
}