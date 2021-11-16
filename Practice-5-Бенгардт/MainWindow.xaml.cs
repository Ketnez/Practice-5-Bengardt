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

namespace Practice_5_Бенгардт
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void СalculateTwoPairs_Click(object sender, RoutedEventArgs e)
        {
            Pair firstP = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            Pair secondP = new Pair(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Pair resultP = firstP.Substract(secondP);
            result.Text = (resultP.First, resultP.Second).ToString();
        }

        private void СalculateThreePairs_Click(object sender, RoutedEventArgs e)
        {
            Pair firstP = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            Pair secondP = new Pair(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Pair thirdP = new Pair(int.Parse(firstP3.Text), int.Parse(secondP3.Text));
            Pair resultP = firstP.Substract(secondP, thirdP);
            result.Text = (resultP.First, resultP.Second).ToString();
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Pair firstP = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            result.Text = firstP.Multiply().ToString();
        }

        private void IsPeer_Click(object sender, RoutedEventArgs e)
        {
            Pair firstP = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            result.Text = firstP.IsEuqual().ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
