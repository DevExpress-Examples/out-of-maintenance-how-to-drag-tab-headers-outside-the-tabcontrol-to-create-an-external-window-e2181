using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace WindowsApplication1
{
    public partial class DragWindow : Form
    {
        public readonly XtraTabPage ClonedPage;
        public DragWindow(XtraTabPage page)
        {

            InitializeComponent();
            ClonedPage = ClonePage(page);
            xtraTabControl1.TabPages.Add(ClonedPage);
            Show();
        }


    
        XtraTabPage ClonePage(XtraTabPage page)
        {
            XtraTabPage resultPage = new XtraTabPage();
             resultPage.Text = page.Text;
             page.Controls[0].Parent = resultPage;
                //assign necessary settings here
             return resultPage;
        }

    }
}