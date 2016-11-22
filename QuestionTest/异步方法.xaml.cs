using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace QuestionTest
{
    /// <summary>
    /// 异步方法.xaml 的交互逻辑
    /// </summary>
    public partial class 异步方法 : Window
    {
        public 异步方法()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            Task<String> task = GetString();
            MessageBox.Show("   ");
            string str = await task;
            MessageBox.Show(str);
        }

        private Task<String> GetString()
        {
           return Task.Factory.StartNew(()=> {
               Thread.Sleep(3000);
                return "3333";
            });
        }



        private async Task<String> GetString2()
        {

            for (int i = 0; i < 11; i++)
            {
                Thread.Sleep(1000);
                await Task.Delay(1);
            }

            return "";
        }

    }
}
