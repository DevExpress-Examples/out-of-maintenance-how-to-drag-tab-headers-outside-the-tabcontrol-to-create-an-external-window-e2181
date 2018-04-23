Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private dragPage As XtraTabPage
		Private dragWindow As DragWindow

		Private Sub xtraTabControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles xtraTabControl1.MouseDown
			dragPage = (TryCast(sender, XtraTabControl)).CalcHitInfo(e.Location).Page
		End Sub

		Private Sub xtraTabControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles xtraTabControl1.MouseMove
			If dragPage IsNot Nothing And dragWindow Is Nothing Then
				CreateDragWindow()
			End If
			If dragWindow IsNot Nothing Then
				dragWindow.Location = Control.MousePosition
			End If
		End Sub

		Private Sub xtraTabControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles xtraTabControl1.MouseUp
			Dim hitInfo As XtraTabHitInfo = (TryCast(sender, XtraTabControl)).CalcHitInfo(e.Location)
			If hitInfo.HitTest = XtraTabHitTest.PageHeader Then
				If dragWindow IsNot Nothing Then
					dragPage.Controls.Add(dragWindow.ClonedPage.Controls(0))
					dragWindow.Close()
				End If
			Else
				FinalizeDragWindow()
			End If
			dragPage = Nothing
			dragWindow = Nothing
		End Sub
		Private Sub CreateDragWindow()
			If dragWindow Is Nothing Then
				dragWindow = New DragWindow(dragPage)
			End If
		End Sub

		Private Sub FinalizeDragWindow()
			If dragWindow Is Nothing Then
				Return
			End If
			xtraTabControl1.TabPages.Remove(dragPage)
			dragWindow.FormBorderStyle = FormBorderStyle
			dragWindow.Opacity = 100
			dragWindow.WindowState = FormWindowState.Maximized
		End Sub
	End Class
End Namespace