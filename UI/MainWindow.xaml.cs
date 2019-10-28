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
using Engine.ViewModels;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Logic _logic = new Logic();


        public MainWindow()
        {
            InitializeComponent();
            DataContext = _logic;
        }

        private void OnClick_Roll(object sender, RoutedEventArgs e)
        {
            _logic.Roll();
        }
        private void OnClick_Result(object sender, RoutedEventArgs e)
        {
            try
            {
                int roll = int.Parse(RollInput.Text);
                _logic.ManualRoll(roll);
            }
            catch
            {
                MessageBox.Show("The Roll value should always be a number");
            }
        }
    }
}
