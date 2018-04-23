Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace Lesson1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub NewDocumentButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.CreateNewDocument()
		End Sub

		Private Sub SaveDocumentButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.SaveDocumentAs()
		End Sub

		Private Sub LoadDocumentButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.LoadDocument()
		End Sub
	End Class
End Namespace
