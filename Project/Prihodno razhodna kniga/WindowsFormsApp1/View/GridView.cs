using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'revenueAccountBookDataSet.RevenueExpenditureBooks' table. You can move, or remove it, as needed.
            this.revenueExpenditureBooksTableAdapter.Fill(this.revenueAccountBookDataSet.RevenueExpenditureBooks);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.revenueExpenditureBooksTableAdapter.FillBy(this.revenueAccountBookDataSet.RevenueExpenditureBooks, ((int)(System.Convert.ChangeType(spartaToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
