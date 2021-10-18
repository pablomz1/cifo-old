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


namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Button_Click_resta(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "-";


            // int valor1 = int.Parse(operaciones.Text);
            // int valor2 = int.Parse(resultados.Text);
            // int resta = valor1 - valor2;
            // MessageBox.Show(resta.ToString());
        }

        private void Button_Click_suma(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "+";

            //int valor1 = int.Parse(operaciones.Text);
            //int valor2 = int.Parse(resultados.Text);
            //int suma = valor1 + valor2;
            //MessageBox.Show(suma.ToString());
        }

        private void Button_Click_multiplicar(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "*";
            //int valor1 = int.Parse(operaciones.Text);
            //int valor2 = int.Parse(resultados.Text);
            //int multiplicacion = valor1 * valor2;
            //MessageBox.Show(multiplicacion.ToString());
        }

       
        private void Button_Click_dividir(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "/";
            //int valor1 = int.Parse(operaciones.Text);
            //int valor2 = int.Parse(resultados.Text);
            //int division = valor1 / valor2;
            //MessageBox.Show(division.ToString());
        }
        private void Button_Click_uno(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "1";
                }
        private void Button_Click_dos(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "2";
        }

        private void Button_Click_tres(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "3";
        }

        private void Button_Click_cuatro(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "4";
        }

        private void Button_Click_cinco(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "5";
        }

        private void Button_Click_seis(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "6";
        }

        private void Button_Click_siete(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "7";
        }

        private void Button_Click_ocho(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "8";
        }

        private void Button_Click_nueve(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "9";
        }

        private void Button_Click_cero(object sender, RoutedEventArgs e)
        {
            operaciones.Text = operaciones.Text + "0";
        }

        private void Button_Click_retroceso(object sender, RoutedEventArgs e)
        {
            //borrar ultimo caracter
            if (operaciones.Text.Length > 0)
            {
                operaciones.Text = operaciones.Text.Substring(0, operaciones.Text.Length - 1);
            }
        }


        private void text_changed_operaciones(object sender, TextChangedEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números

            //char_add_operaciones(sender, );
        }

        private void char_add_operaciones(object sender, KeyEventArgs e)
        {
            //Para obligar a que sólo se introducan números:
            //var c = Convert.ToString ((char)e.Key.); no funciona!!!
            var c = e.Key.ToString();
            //MessageBox.Show(c);

            if (char.IsDigit(c))
            {
            //  MessageBox.Show("teclado");
              MessageBox.Show("es numero");
            // operaciones.Text = operaciones.Text.Substring(0, operaciones.Text.Length - 1);
            // e.Handled = true;

            }
            else
            {
             MessageBox.Show("no es numero");
            }
        }
    }
}
