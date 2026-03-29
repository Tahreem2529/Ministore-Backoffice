using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WinForms.Views;

namespace App.WinForms.Forms
{
    public partial class MainForm : Form
 {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void flpNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
        }

        private void statusStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_4(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void flpNav_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_5(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductsView());
        }
        private void ShowView<T>(Func<T> factory) where T:UserControl
        {
            var key = typeof(T);
         
            if(!_views.TryGetValue(key, out var view))
            {
                view =  factory();
        _views[key] = view;
            view.Dock = DockStyle.Fill;

            }
        pnlContent.Controls.Clear();
        pnlContent.Controls.Add(view);
        }

        private void pnlContent_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
