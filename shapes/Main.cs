using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shapes
{
    public partial class Main : Form
    {
        static List<Geometry> geometryList = new List<Geometry>(); 

        public Main()
        {
            InitializeComponent();           
        }

        private void rbtnRightTriange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRightTriangle.Checked)
            {
                AddRightTriangle frmTriangle = new AddRightTriangle(geometryList);
                frmTriangle.ShowDialog();
                rbtnRightTriangle.Checked = false;                           
                lblCountRightTriangles.Text = (frmTriangle.getNumOfRightTriangles()).ToString();  // shows the number of right triangles

                geometryList = frmTriangle.getUpdatedList();  // To update the geometryList
                displayOnListBox(geometryList);    // To display the content of list on listBox in detail tab                             
            }                    
        }

        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSquare.Checked)
            {
                AddSquare frmSquare = new AddSquare(geometryList);
                frmSquare.ShowDialog();
                rbtnSquare.Checked = false;
                lblCountSquares.Text = (frmSquare.getNumOfSquares()).ToString();

                geometryList = frmSquare.getUpdatedList();  // To update the geometryList
                displayOnListBox(geometryList);    // To display the content of list on listBox in detail tab
            }
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRectangle.Checked)
            {
                AddRectangle frmRectangle = new AddRectangle(geometryList);
                frmRectangle.ShowDialog();
                rbtnRectangle.Checked = false;
                lblCountRectangles.Text = (frmRectangle.getNumOfRectangles()).ToString();

                geometryList = frmRectangle.getUpdatedList();  // To update the geometryList
                displayOnListBox(geometryList);    // To display the content of list on listBox in detail tab 
            }
        }        

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCircle.Checked)
            {
                AddCircle frmCircle = new AddCircle(geometryList);
                frmCircle.ShowDialog();
                rbtnCircle.Checked = false;
                lblCountCircles.Text = (frmCircle.getNumOfCircles()).ToString();

                geometryList = frmCircle.getUpdatedList();  // To update the geometryList
                displayOnListBox(geometryList);    // To display the content of list on listBox in detail tab 
            }
        }       

        private void rbtnSortByArea_CheckedChanged(object sender, EventArgs e)
        {
            lbxInSort.Items.Clear();  // Clears previous listbox items in Sort tab 

            Geometry temp;
            for (int i = 0; i < geometryList.Count; i++)
            {
                for (int j = i + 1; j < geometryList.Count; j++)
                {
                    if (geometryList[i].Area < geometryList[j].Area)
                    {
                        temp = geometryList[i];
                        geometryList[i] = geometryList[j];
                        geometryList[j] = temp;
                    }
                }              
            }
                                           
            foreach (Geometry element in geometryList)
                lbxInSort.Items.Add(element.toString());  // Adds all elements on lbxInSort

            rbtnSortByArea.Checked = false;
        }

        private void rbtnSortByPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            lbxInSort.Items.Clear();  // Clears previous listbox items in Sort tab 

            Geometry temp;
            for (int i = 0; i < geometryList.Count; i++)
            {
                for (int j = i + 1; j < geometryList.Count; j++)
                {
                    if (geometryList[i].Perimeter < geometryList[j].Perimeter)
                    {
                        temp = geometryList[i];
                        geometryList[i] = geometryList[j];
                        geometryList[j] = temp;
                    }
                }
            }

            foreach (Geometry element in geometryList)
                lbxInSort.Items.Add(element.toString());  // Adds all elements on lbxInSort

            rbtnSortByPerimeter.Checked = false;
        }

        private void displayOnListBox(List<Geometry> list)
        {
            lbxInDetail.Items.Clear();  // Clears previous listbox items in Detail tab
            lbxInSort.Items.Clear();    // Clears previous listbox items in Sort tab                                 
            foreach (Geometry element in list)
                lbxInDetail.Items.Add(element.toString());  // Adds all elements on lbxInDetail            
        }
    }
}
