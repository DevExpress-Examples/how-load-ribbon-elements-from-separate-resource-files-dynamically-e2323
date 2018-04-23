Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Ribbon

Namespace RibbonFromXaml
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim o As ResourceDictionary = TryCast(Application.LoadComponent(New Uri("RibbonResources1.xaml", UriKind.RelativeOrAbsolute)), ResourceDictionary)
			ctrlRibbon.Items.Add(TryCast(o("DefaultCategory"), RibbonDefaultPageCategory))
			o = TryCast(Application.LoadComponent(New Uri("RibbonResources2.xaml", UriKind.RelativeOrAbsolute)), ResourceDictionary)
			ctrlRibbon.Items.Add(TryCast(o("Category"), RibbonPageCategory))
			o = TryCast(Application.LoadComponent(New Uri("RibbonResources3.xaml", UriKind.RelativeOrAbsolute)), ResourceDictionary)
			ctrlRibbon.Items.Add(TryCast(o("Category"), RibbonPageCategory))
		End Sub
	End Class
End Namespace
