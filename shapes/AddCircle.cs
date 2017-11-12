using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shapes
{    
    public partial class AddCircle : Form
    {
        private static int _numOfCircles = 0; // Counter for circle       
        private List<Geometry> list;

        public AddCircle(List<Geometry> geometryList)
        {
            InitializeComponent();
            list = geometryList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double radius = 0, diameter = 0, area = 0, perimeter = 0;

            if (double.TryParse(tbxRadius.Text, out radius))
            {
                diameter = Math.Round(radius * 2, 2);
                area = Math.Round(radius * radius * Math.PI, 2);               
                perimeter = Math.Round(diameter * Math.PI, 2);
                list.Add(new Circle(perimeter, area));
                _numOfCircles++;
            }
            else
            {
                MessageBox.Show("Invalid value of radius");
            }

            lblDiameter.Text = diameter.ToString();
            lblArea.Text = area.ToString();
            lblPerimeter.Text = perimeter.ToString();

            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Red, 2);

            g.DrawEllipse(p, 70, 180, (float)radius, (float)radius);
        }

        public int getNumOfCircles()
        {
            return _numOfCircles;
        }

        public List<Geometry> getUpdatedList()
        {
            return list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxRadius.Text = "";            
            lblArea.Text = "";
            lblPerimeter.Text = "";
            tbxRadius.Focus();

            this.Invalidate();  // To delete a Circle
        }
    }
}
