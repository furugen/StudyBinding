using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace BindingStudy
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void SourceUpdatedHandler(object sender, DataTransferEventArgs args)
        {
            UpdatedLog("SourceUpdatedHandler", args);
        }

        private void TargetUpdatedHandler(object sender, DataTransferEventArgs args)
        {
            UpdatedLog("TargetUpdatedHandler", args);
        }

        private void UpdatedLog(string msg, DataTransferEventArgs args)
        {
            Debug.WriteLine("------------------------------------------------------");
            Debug.WriteLine("method:" + msg);
            Debug.WriteLine("Source [" + ((TextBox)args.Source).Name + "] = " + args.Source.ToString());
            Debug.WriteLine("TargetObject [" + ((TextBox)args.TargetObject).Name + "] = " + args.TargetObject.ToString());
            Debug.WriteLine("------------------------------------------------------");
        }

        private void Expression_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = ((TextBox)txtExpressoin).GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }
    }
}
