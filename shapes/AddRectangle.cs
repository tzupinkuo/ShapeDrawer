using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRectangle : Form
    {
        private static int _numOfRectangles = 0; // Counter for Rectangle       
        private List<Geometry> list;
        public AddRectangle(List<Geometry> geometryList)
        {
            InitializeComponent();
            list = geometryList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double side1 = 0, side2 = 0, area = 0, perimeter = 0;

            if (double.TryParse(tbxSide1.Text, out side1))
            {
                if (double.TryParse(tbxSide2.Text, out side2))
                {
                    area = Math.Round(side1 * side2, 2);
                    perimeter = Math.Round((side1 + side2) * 2, 2);
                    list.Add(new Rectangle(perimeter, area));
                    _numOfRectangles++;
                }
                else
                {
                    MessageBox.Show("Invalid value of side 2");
                }
            }
            else
            {
                MessageBox.Show("Invalid value of side 1");
            }

            lblArea.Text = area.ToString();
            lblPerimeter.Text = perimeter.ToString();

            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Red, 2);

            // The rectangle starts at 70, 180            
            g.DrawRectangle(p, 70, 180, (float)side1, (float)side2);
        }

        public int getNumOfRectangles()
        {
            return _numOfRectangles;
        }

        public List<Geometry> getUpdatedList()
        {
            return list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSide1.Text = "";
            tbxSide2.Text = "";            
            lblArea.Text = "";
            lblPerimeter.Text = "";
            tbxSide1.Focus();

            this.Invalidate();  // To delete a drawn rectangle
        }
    }
}
