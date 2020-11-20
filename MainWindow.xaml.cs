using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace _2dRubiksCube
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string PATH = @".\moveData.txt";
        private List<string> moves = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            if(!File.Exists(PATH))
            {
                using (StreamWriter sw = File.CreateText(PATH))
                {
                    sw.WriteLine("Data of moves:\n");
                }
            }

            //using (StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine("HELP");
            //}
        }

        private void Line1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line1Color = Line1.Stroke;
            Brush Line5Color = Line5.Stroke;
            Brush Line8Color = Line8.Stroke;
            Brush Line4Color = Line4.Stroke;

            if(!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M1");
                Line1.Stroke = Line4Color;
                Line5.Stroke = Line1Color;
                Line8.Stroke = Line5Color;
                Line4.Stroke = Line8Color;
            }
            else
            {
                moves.Add("M1'");
                Line1.Stroke = Line5Color;
                Line5.Stroke = Line8Color;
                Line8.Stroke = Line4Color;
                Line4.Stroke = Line1Color;
            }
        }

        private void Line4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line4.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line11.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line18_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line18.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line2Color = Line2.Stroke;
            Brush Line6Color = Line6.Stroke;
            Brush Line9Color = Line9.Stroke;
            Brush Line5Color = Line5.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M2");
                Line2.Stroke = Line5Color;
                Line6.Stroke = Line2Color;
                Line9.Stroke = Line6Color;
                Line5.Stroke = Line9Color;
            }
            else
            {
                moves.Add("M2'");
                Line2.Stroke = Line6Color;
                Line6.Stroke = Line9Color;
                Line9.Stroke = Line5Color;
                Line5.Stroke = Line2Color;
            }
        }

        private void Line5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line5.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line12.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line19_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line19.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line3Color = Line3.Stroke;
            Brush Line7Color = Line7.Stroke;
            Brush Line10Color = Line10.Stroke;
            Brush Line6Color = Line6.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M3");
                Line3.Stroke = Line6Color;
                Line7.Stroke = Line3Color;
                Line10.Stroke = Line7Color;
                Line6.Stroke = Line10Color;
            }
            else
            {
                moves.Add("M3'");
                Line3.Stroke = Line7Color;
                Line7.Stroke = Line10Color;
                Line10.Stroke = Line6Color;
                Line6.Stroke = Line3Color;
            }
        }

        private void Line6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line6.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line13.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line20_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line20.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line7.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line14.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line21_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line21.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line8Color = Line8.Stroke;
            Brush Line12Color = Line12.Stroke;
            Brush Line15Color = Line15.Stroke;
            Brush Line11Color = Line11.Stroke;
            
            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M4");
                Line8.Stroke = Line11Color;
                Line12.Stroke = Line8Color;
                Line15.Stroke = Line12Color;
                Line11.Stroke = Line15Color;
            }
            else
            {
                moves.Add("M4'");
                Line8.Stroke = Line12Color;
                Line12.Stroke = Line15Color;
                Line15.Stroke = Line11Color;
                Line11.Stroke = Line8Color;
            }
        }

        private void Line9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line9Color = Line9.Stroke;
            Brush Line13Color = Line13.Stroke;
            Brush Line16Color = Line16.Stroke;
            Brush Line12Color = Line12.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M5");
                Line9.Stroke = Line12Color;
                Line13.Stroke = Line9Color;
                Line16.Stroke = Line13Color;
                Line12.Stroke = Line16Color;
            }
            else
            {
                moves.Add("M5'");
                Line9.Stroke = Line13Color;
                Line13.Stroke = Line16Color;
                Line16.Stroke = Line12Color;
                Line12.Stroke = Line9Color;
            }
        }

        private void Line10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line10Color = Line10.Stroke;
            Brush Line14Color = Line14.Stroke;
            Brush Line17Color = Line17.Stroke;
            Brush Line13Color = Line13.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M6");
                Line10.Stroke = Line13Color;
                Line14.Stroke = Line10Color;
                Line17.Stroke = Line14Color;
                Line13.Stroke = Line17Color;
            }
            else
            {
                moves.Add("M6'");
                Line10.Stroke = Line14Color;
                Line14.Stroke = Line17Color;
                Line17.Stroke = Line13Color;
                Line13.Stroke = Line10Color;
            }
        }

        private void Line15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line15Color = Line15.Stroke;
            Brush Line19Color = Line19.Stroke;
            Brush Line22Color = Line22.Stroke;
            Brush Line18Color = Line18.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M7");
                Line15.Stroke = Line18Color;
                Line19.Stroke = Line15Color;
                Line22.Stroke = Line19Color;
                Line18.Stroke = Line22Color;
            }
            else
            {
                moves.Add("M7'");
                Line15.Stroke = Line19Color;
                Line19.Stroke = Line22Color;
                Line22.Stroke = Line18Color;
                Line18.Stroke = Line15Color;
            }
        }

        private void Line16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line16Color = Line16.Stroke;
            Brush Line20Color = Line20.Stroke;
            Brush Line23Color = Line23.Stroke;
            Brush Line19Color = Line19.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M8");
                Line16.Stroke = Line19Color;
                Line20.Stroke = Line16Color;
                Line23.Stroke = Line20Color;
                Line19.Stroke = Line23Color;
            }
            else
            {
                moves.Add("M8'");
                Line16.Stroke = Line20Color;
                Line20.Stroke = Line23Color;
                Line23.Stroke = Line19Color;
                Line19.Stroke = Line16Color;
            }
        }

        private void Line17_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Brush Line17Color = Line17.Stroke;
            Brush Line21Color = Line21.Stroke;
            Brush Line24Color = Line24.Stroke;
            Brush Line20Color = Line20.Stroke;

            if (!Keyboard.IsKeyDown(Key.LeftShift))
            {
                moves.Add("M9");
                Line17.Stroke = Line20Color;
                Line21.Stroke = Line17Color;
                Line24.Stroke = Line21Color;
                Line20.Stroke = Line24Color;
            }
            else
            {
                moves.Add("M9'");
                Line17.Stroke = Line21Color;
                Line21.Stroke = Line24Color;
                Line24.Stroke = Line20Color;
                Line20.Stroke = Line17Color;
            }
        }

        private void Line22_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line22.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line23_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line23.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void Line24_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Line24.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            moves.Clear();

            Line1.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);
            Line2.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);
            Line3.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);

            Line4.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            Line5.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Green);
            Line6.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            Line7.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Green);

            Line8.Stroke = new SolidColorBrush(System.Windows.Media.Colors.White);
            Line9.Stroke = new SolidColorBrush(System.Windows.Media.Colors.White);
            Line10.Stroke = new SolidColorBrush(System.Windows.Media.Colors.White);

            Line11.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            Line12.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Green);
            Line13.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            Line14.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Green);

            Line15.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);
            Line16.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);
            Line17.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);

            Line18.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            Line19.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Green);
            Line20.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            Line21.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Green);

            Line22.Stroke = new SolidColorBrush(System.Windows.Media.Colors.White);
            Line23.Stroke = new SolidColorBrush(System.Windows.Media.Colors.White);
            Line24.Stroke = new SolidColorBrush(System.Windows.Media.Colors.White);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (moves.Count() != 0)
            {
                using (StreamWriter sw = File.AppendText(PATH))
                {
                    moves.ForEach(m => sw.Write(m + " "));
                    sw.WriteLine("DONE.");
                }
            }
        }
    }
}
