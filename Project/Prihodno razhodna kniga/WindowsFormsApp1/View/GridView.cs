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

        //Show's the data from database
        private void GridView_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'revenueAccountBookDataSet.RevenueExpenditureBooks' table.
            this.revenueExpenditureBooksTableAdapter.Fill(this.revenueAccountBookDataSet.RevenueExpenditureBooks);

        }

        //Sorts the database by the given number
        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.revenueExpenditureBooksTableAdapter.FillBy(this.revenueAccountBookDataSet.RevenueExpenditureBooks, ((int)(Convert.ChangeType(ToolStripTextBox.Text, typeof(int)))));
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
