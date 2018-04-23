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
using DevExpress.Xpf.Ribbon;

namespace RibbonFromXaml {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            ResourceDictionary o = Application.LoadComponent(new Uri("RibbonResources1.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;
            ctrlRibbon.Items.Add(o["DefaultCategory"] as RibbonDefaultPageCategory);
            o = Application.LoadComponent(new Uri("RibbonResources2.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;
            ctrlRibbon.Items.Add(o["Category"] as RibbonPageCategory);
            o = Application.LoadComponent(new Uri("RibbonResources3.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;
            ctrlRibbon.Items.Add(o["Category"] as RibbonPageCategory);
        }
    }
}
