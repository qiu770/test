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
    /// QueueTest.xaml 的交互逻辑
    /// </summary>
    public partial class QueueTest : Window
    {
        public QueueTest()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Queue<Object> list = new Queue<Object>();
            if (list.Count > 0)
            {
                Object obj = list.Dequeue();

                MessageBox.Show((obj == null).ToString());
            }
            else
            {
                MessageBox.Show("队列内不包含对象里，调用出队列方法Dequeue会报异常");
            }
        }
    }
}
