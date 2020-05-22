using System;
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

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.revenueExpenditureBooksTableAdapter.FillBy(this.revenueAccountBookDataSet.RevenueExpenditureBooks, ((int)(Convert.ChangeType(spartaToolStripTextBox.Text, typeof(int)))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
