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

namespace idkprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Content = @"1
Cibuli oloupeme, nakrájíme nadrobno a osmahneme na oleji do růžova.Přisypeme papriku, přidáme očištěné na kostky nakrájené maso, které orestujeme.Pak přidáme sůl a kmín, podlijeme horkou vodou a dusíme.Když je maso skoro měkké, zaprášíme ho moukou, kterou necháme osmahnout.Přilijeme trochu vody, přidáme utřený česnek.
RADA: Jak udržet omáčku teplou

2
Maso vyjmeme, omáčku rozšleháme.Opět přidáme maso a dusíme doměkka. Uvařený guláš dochutíme majoránkou a podáváme s houskovými knedlíky.
RADA: Jak uvařit ty nejlepší knedlíky: Klasické kynuté, bramborové i karlovarské

3
Jestli zvolíte jinou formu zahuštění, nechávám na vás.My máme rádi guláš takto.";
            label1.FontSize = 12;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            label1.FontSize += 1;
            InitializeComponent();
            Window1 w1 = new Window1();
            w1.Show();
            this.Close();

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
