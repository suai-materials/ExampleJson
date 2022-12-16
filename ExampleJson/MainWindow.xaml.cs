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
using Newtonsoft.Json;

namespace ExampleJson
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            List<Auth> auths = new()
            {
                new Auth(1, "Вася", "Панков", "+79627011087", "Колпино", "", 192168),
                new Auth(2, "Александр", "Пушкин", "Неизвестен", "Санкт-Петербург", "", 0)
            };
            RichTextBox.Text = JsonConvert.SerializeObject(auths);
        }
    }
}