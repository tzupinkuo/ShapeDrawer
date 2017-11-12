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
    public partial class AddRightTriangle : Form
    {
        private static int _numOfRightTriangles = 0; // Counter for right triangle        
        private List<Geometry> list;

        public AddRightTriangle(List<Geometry> geometryList)
        {
            InitializeComponent();
            list = geometryList;            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double side1 = 0, side2 = 0, hypotenuse = 0, area = 0, perimeter = 0;

            if (double.TryParse(tbxSide1.Text, out side1))
            {
                if (double.TryParse(tbxSide2.Text, out side2))
                {
                    hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
                    area = Math.Round(side1 * side2 / 2.0, 2);
                    perimeter = Math.Round(side1 + side2 + hypotenuse, 2);                     
                    list.Add(new RightTriangle(perimeter, area));                                                    
                    _numOfRightTriangles++;
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


            lblHypotenuse.Text = hypotenuse.ToString();
            lblArea.Text = area.ToString();
            lblPerimeter.Text = perimeter.ToString();

            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Red, 2);

            // Draw a right triangle with vertices at
            // (100, 250), (100 + (float)side1, 250), and (100, 250 + (float)side2)
            g.DrawLine(p, 100, 250, 100 + (float)side1, 250);
            g.DrawLine(p, 100 + (float)side1, 250, 100, 250 + (float)side2);
            g.DrawLine(p, 100, 250 + (float)side2, 100, 250);            
        }

        public int getNumOfRightTriangles()
        {
            return _numOfRightTriangles;
        }

        public List<Geometry> getUpdatedList()
        {
            return list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {            
            tbxSide1.Text = "";
            tbxSide2.Text = "";
            lblHypotenuse.Text = "";
            lblArea.Text = "";
            lblPerimeter.Text = "";
            tbxSide1.Focus();
            
            this.Invalidate();  // To delete a drawn right triangle
        }
    }
}
