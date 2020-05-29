using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    /// <summary>
    /// Main View partial class
    /// Countains methods which allows us to view the database
    /// </summary>
    public partial class View : Form
    {
        /// <summary>
        /// InitializeComponent constructor
        /// </summary>
        public View()
        {
            InitializeComponent();
        }

        //Show's the data from database
        private void View_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'revenueAccountBookDataSet.RevenueExpenditureBooks' table.
            this.revenueExpenditureBooksTableAdapter.Fill(this.revenueAccountBookDataSet.RevenueExpenditureBooks);

        }

        //Sorts database by the given number
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
        {}
    }
}
