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

namespace OOPinWPF
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
            // 监听Button类提供的Click事件
            // sender 为 button
            ((Button)sender).Content = "Clicked!";  // Object类强制转换为Button类 修改Content属性
            Button newButton = new Button();    // new Button类实例
            newButton.Content = "New Button!";
            newButton.Margin = new Thickness(10, 10, 200, 200); //Margin属性使用Thickness对象配置
            newButton.Click += newButton_Click; // 添加事件处理程序以响应newButton的Click事件
            ((Grid)((Button)sender).Parent).Children.Add(newButton);    // 父对象转换为Grid类添加至窗口
        }
        private void newButton_Click(object sender,RoutedEventArgs e)
        {
            // 监听newButton类提供的Click事件
            ((Button)sender).Content = "Clicked!";
        }
    }
}
