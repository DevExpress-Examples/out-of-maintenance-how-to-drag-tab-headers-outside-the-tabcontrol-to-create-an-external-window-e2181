Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab

Namespace WindowsApplication1
	Partial Public Class DragWindow
		Inherits Form
		Public ReadOnly ClonedPage As XtraTabPage
		Public Sub New(ByVal page As XtraTabPage)

			InitializeComponent()
			ClonedPage = ClonePage(page)
			xtraTabControl1.TabPages.Add(ClonedPage)
			Show()
		End Sub



		Private Function ClonePage(ByVal page As XtraTabPage) As XtraTabPage
			Dim resultPage As New XtraTabPage()
			 resultPage.Text = page.Text
			 page.Controls(0).Parent = resultPage
				'assign necessary settings here
			 Return resultPage
		End Function

	End Class
End Namespace