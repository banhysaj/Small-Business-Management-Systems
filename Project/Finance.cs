using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Finance : UserControl
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public Finance()
        {
            InitializeComponent();

        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void closeAddBtn_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            panel6.Visible=true;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            panel5.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button1.Visible = false;
            Print(this.panel4);
            button4.Visible=true;
            button1.Visible=true;
        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }
        public void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg,(pagearea.Width/2)-(this.panel4.Width/2),this.panel4.Location.Y);
        }
        Bitmap memoryimg;
        public void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width,pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0,0,pnl.Width,pnl.Height));

        }
    }
}
