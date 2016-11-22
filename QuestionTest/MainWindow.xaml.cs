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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuestionTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            QueueTest test = new QueueTest();
            test.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new 动画测试().ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            new 进制运算().ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            new 异步方法().ShowDialog();
        }
    }
}
