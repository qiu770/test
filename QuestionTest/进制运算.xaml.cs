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

namespace QuestionTest
{
    /// <summary>
    /// 进行运算.xaml 的交互逻辑
    /// </summary>
    public partial class 进制运算 : Window
    {
        public 进制运算()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            int i = 7;

            int o = -7;

            Byte[] by = BitConverter.GetBytes(i);

            Byte[] by2 = BitConverter.GetBytes(o);


            Console.WriteLine(by.Length + by2.Length);
            MessageBox.Show((1 * 2 ^ 2 ).ToString());
        }
    }
}
