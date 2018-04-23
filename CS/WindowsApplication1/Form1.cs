using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XtraTabPage dragPage;
        DragWindow dragWindow;

        private void xtraTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            dragPage = (sender as XtraTabControl).CalcHitInfo(e.Location).Page;
        }

        private void xtraTabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragPage != null & dragWindow == null)
                CreateDragWindow();
            if (dragWindow != null)
                dragWindow.Location = Control.MousePosition;
        }

        private void xtraTabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            XtraTabHitInfo hitInfo = (sender as XtraTabControl).CalcHitInfo(e.Location);
            if (hitInfo.HitTest == XtraTabHitTest.PageHeader)
            {
                if (dragWindow != null)
                {
                    dragPage.Controls.Add(dragWindow.ClonedPage.Controls[0]);
                    dragWindow.Close();
                }
            }
            else
            {
                FinalizeDragWindow();
            }
            dragPage = null;
            dragWindow = null;
        }
        private void CreateDragWindow()
        {
            if (dragWindow == null)
                dragWindow = new DragWindow(dragPage);
        }

        private void FinalizeDragWindow()
        {
            if (dragWindow == null) return;
            xtraTabControl1.TabPages.Remove(dragPage);
            dragWindow.FormBorderStyle = FormBorderStyle;
            dragWindow.Opacity = 100;
            dragWindow.WindowState = FormWindowState.Maximized;
        }
    }
}