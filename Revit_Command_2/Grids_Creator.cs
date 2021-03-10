using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revit_Command_2
{
    public partial class Grids_Creator : Form
    {
        private int gridHorNumber;
        public int GridHorNumber 
        {
            get
            {
                return gridHorNumber;
            }
            set
            {
                if (value <= 25 && value > 0)
                {
                    gridHorNumber = value;
                }
                else
                {
                    MessageBox.Show("Set wrong number for Ver grid!");
                }
            }
        }
        public double GridHorDistance { get; set; }
        private int gridVerNumber;
        public int GridVerNumber
        {
            get
            {
                return gridVerNumber;
            }
            set
            {
                if (value <= 25 && value > 0)
                {
                    gridVerNumber = value;
                }
                else
                {
                    MessageBox.Show("Set wrong number for Ver grid!");
                }
            }
        }
        public double GridVerDistance { get; set; }
        public Grids_Creator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GridHorNumber = Convert.ToInt32(textBox_GridHorNumber.Text);
                GridHorDistance = Convert.ToDouble(textBox_GridHorDistance.Text);
                GridVerNumber = Convert.ToInt32(textBox_GridVerNumber.Text);
                GridVerDistance = Convert.ToDouble(textBox_GridVerDistance.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong value!\nTry again.\n" + (ex).ToString());
            }
            finally
            {
                textBox_GridHorNumber.Text = "0";
                textBox_GridHorDistance.Text = "0";
                textBox_GridVerNumber.Text = "0";
                textBox_GridVerDistance.Text = "0";
            }

            if (textBox_GridHorNumber != null && textBox_GridHorDistance != null
                && textBox_GridVerNumber != null && textBox_GridVerDistance != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all forms!");
            }
        }
    }
}
