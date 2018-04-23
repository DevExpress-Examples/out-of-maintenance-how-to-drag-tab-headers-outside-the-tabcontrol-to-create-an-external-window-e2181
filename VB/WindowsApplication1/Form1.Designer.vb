Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.webBrowser2 = New System.Windows.Forms.WebBrowser()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(827, 642)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
'			Me.xtraTabControl1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.xtraTabControl1_MouseUp);
'			Me.xtraTabControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.xtraTabControl1_MouseMove);
'			Me.xtraTabControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.xtraTabControl1_MouseDown);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(820, 614)
			Me.xtraTabPage1.Text = "http://www.devexpress.com/"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.webBrowser1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(820, 614)
			Me.panelControl1.TabIndex = 0
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.webBrowser1.Location = New System.Drawing.Point(2, 2)
			Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New System.Drawing.Size(816, 610)
			Me.webBrowser1.TabIndex = 0
			Me.webBrowser1.Url = New System.Uri("http://www.devexpress.com/", System.UriKind.Absolute)
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.panelControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(820, 614)
			Me.xtraTabPage2.Text = "http://www.devexpress.com/Support/Center/"
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.webBrowser2)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(820, 614)
			Me.panelControl2.TabIndex = 1
			' 
			' webBrowser2
			' 
			Me.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.webBrowser2.Location = New System.Drawing.Point(2, 2)
			Me.webBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser2.Name = "webBrowser2"
			Me.webBrowser2.Size = New System.Drawing.Size(816, 610)
			Me.webBrowser2.TabIndex = 0
			Me.webBrowser2.Url = New System.Uri("http://www.devexpress.com/Support/Center/", System.UriKind.Absolute)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(827, 642)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private webBrowser1 As System.Windows.Forms.WebBrowser
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private webBrowser2 As System.Windows.Forms.WebBrowser

	End Class
End Namespace

