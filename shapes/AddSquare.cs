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
    public partial class AddSquare : Form
    {
        private static int _numOfSquares = 0; // Counter for square
        private List<Geometry> list;
        public AddSquare(List<Geometry> geometryList)
        {
            InitializeComponent();
            list = geometryList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double side = 0, area = 0, perimeter = 0;

            if (double.TryParse(tbxSide.Text, out side))
            {
                area = Math.Round(side * side, 2);
                perimeter = Math.Round(side * 4, 2);
                list.Add(new Square(perimeter, area));
                _numOfSquares++;
            }
            else
            {
                MessageBox.Show("Invalid value of side");
            }

            lblArea.Text = area.ToString();
            lblPerimeter.Text = perimeter.ToString();

            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Red, 2);

            // The square starts at 70, 180            
            g.DrawRectangle(p, 70, 180, (float)side,(float)side); 
        }

        public int getNumOfSquares()
        {
            return _numOfSquares;
        }

        public List<Geometry> getUpdatedList()
        {
            return list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSide.Text = "";            
            lblArea.Text = "";
            lblPerimeter.Text = "";
            tbxSide.Focus();

            this.Invalidate();  // To delete a square
        }
    }
}
