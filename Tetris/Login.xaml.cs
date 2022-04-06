using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tetris
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, RoutedEventArgs e)
        {
            string usuario = loginbox.Text;
            string senha = passbox.Password.ToString();

            if (usuario == "joaozinhogamer" && senha == "123")
            {
                MainWindow janela = new MainWindow();
                janela.ShowDialog();
            }
        }
    }
}
