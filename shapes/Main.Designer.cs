namespace shapes
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpCreate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.rbtnRightTriangle = new System.Windows.Forms.RadioButton();
            this.tbpSummary = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountCircles = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountRectangles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountSquares = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountRightTriangles = new System.Windows.Forms.Label();
            this.tbpDetail = new System.Windows.Forms.TabPage();
            this.lbxInDetail = new System.Windows.Forms.ListBox();
            this.tbpSort = new System.Windows.Forms.TabPage();
            this.lbxInSort = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnSortByPerimeter = new System.Windows.Forms.RadioButton();
            this.rbtnSortByArea = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tbpCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpSummary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpDetail.SuspendLayout();
            this.tbpSort.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCreate);
            this.tabControl1.Controls.Add(this.tbpSummary);
            this.tabControl1.Controls.Add(this.tbpDetail);
            this.tabControl1.Controls.Add(this.tbpSort);
            this.tabControl1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpCreate
            // 
            this.tbpCreate.BackColor = System.Drawing.Color.Ivory;
            this.tbpCreate.Controls.Add(this.groupBox1);
            this.tbpCreate.Location = new System.Drawing.Point(4, 27);
            this.tbpCreate.Name = "tbpCreate";
            this.tbpCreate.Size = new System.Drawing.Size(653, 451);
            this.tbpCreate.TabIndex = 0;
            this.tbpCreate.Text = "Create";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCircle);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Controls.Add(this.rbtnSquare);
            this.groupBox1.Controls.Add(this.rbtnRightTriangle);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(178, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Shape to Create";
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(7, 126);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(72, 23);
            this.rbtnCircle.TabIndex = 3;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "&Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.rbtnCircle_CheckedChanged);
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Location = new System.Drawing.Point(7, 96);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(103, 23);
            this.rbtnRectangle.TabIndex = 2;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "&Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.rbtnRectangle_CheckedChanged);
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.AutoSize = true;
            this.rbtnSquare.Location = new System.Drawing.Point(7, 67);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(80, 23);
            this.rbtnSquare.TabIndex = 1;
            this.rbtnSquare.TabStop = true;
            this.rbtnSquare.Text = "&Square";
            this.rbtnSquare.UseVisualStyleBackColor = true;
            this.rbtnSquare.CheckedChanged += new System.EventHandler(this.rbtnSquare_CheckedChanged);
            // 
            // rbtnRightTriangle
            // 
            this.rbtnRightTriangle.AutoSize = true;
            this.rbtnRightTriangle.Location = new System.Drawing.Point(7, 37);
            this.rbtnRightTriangle.Name = "rbtnRightTriangle";
            this.rbtnRightTriangle.Size = new System.Drawing.Size(135, 23);
            this.rbtnRightTriangle.TabIndex = 0;
            this.rbtnRightTriangle.TabStop = true;
            this.rbtnRightTriangle.Text = "Right &Triangle";
            this.rbtnRightTriangle.UseVisualStyleBackColor = true;
            this.rbtnRightTriangle.CheckedChanged += new System.EventHandler(this.rbtnRightTriange_CheckedChanged);
            // 
            // tbpSummary
            // 
            this.tbpSummary.BackColor = System.Drawing.Color.Ivory;
            this.tbpSummary.Controls.Add(this.groupBox2);
            this.tbpSummary.Location = new System.Drawing.Point(4, 27);
            this.tbpSummary.Name = "tbpSummary";
            this.tbpSummary.Size = new System.Drawing.Size(653, 451);
            this.tbpSummary.TabIndex = 1;
            this.tbpSummary.Text = "Summary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCountCircles);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblCountRectangles);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCountSquares);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCountRightTriangles);
            this.groupBox2.Location = new System.Drawing.Point(178, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 210);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory Summary";
            // 
            // lblCountCircles
            // 
            this.lblCountCircles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountCircles.Location = new System.Drawing.Point(201, 140);
            this.lblCountCircles.Name = "lblCountCircles";
            this.lblCountCircles.Size = new System.Drawing.Size(40, 23);
            this.lblCountCircles.TabIndex = 7;
            this.lblCountCircles.Text = "0";
            this.lblCountCircles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(91, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Circles";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountRectangles
            // 
            this.lblCountRectangles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountRectangles.Location = new System.Drawing.Point(201, 101);
            this.lblCountRectangles.Name = "lblCountRectangles";
            this.lblCountRectangles.Size = new System.Drawing.Size(40, 23);
            this.lblCountRectangles.TabIndex = 5;
            this.lblCountRectangles.Text = "0";
            this.lblCountRectangles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(91, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rectangle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountSquares
            // 
            this.lblCountSquares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountSquares.Location = new System.Drawing.Point(201, 63);
            this.lblCountSquares.Name = "lblCountSquares";
            this.lblCountSquares.Size = new System.Drawing.Size(40, 23);
            this.lblCountSquares.TabIndex = 3;
            this.lblCountSquares.Text = "0";
            this.lblCountSquares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Right Triangles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Squares";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountRightTriangles
            // 
            this.lblCountRightTriangles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountRightTriangles.Location = new System.Drawing.Point(201, 26);
            this.lblCountRightTriangles.Name = "lblCountRightTriangles";
            this.lblCountRightTriangles.Size = new System.Drawing.Size(40, 23);
            this.lblCountRightTriangles.TabIndex = 1;
            this.lblCountRightTriangles.Text = "0";
            this.lblCountRightTriangles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpDetail
            // 
            this.tbpDetail.BackColor = System.Drawing.Color.Ivory;
            this.tbpDetail.Controls.Add(this.lbxInDetail);
            this.tbpDetail.Location = new System.Drawing.Point(4, 27);
            this.tbpDetail.Name = "tbpDetail";
            this.tbpDetail.Size = new System.Drawing.Size(653, 451);
            this.tbpDetail.TabIndex = 2;
            this.tbpDetail.Text = "Detail";
            // 
            // lbxInDetail
            // 
            this.lbxInDetail.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInDetail.FormattingEnabled = true;
            this.lbxInDetail.ItemHeight = 14;
            this.lbxInDetail.Location = new System.Drawing.Point(41, 42);
            this.lbxInDetail.Name = "lbxInDetail";
            this.lbxInDetail.Size = new System.Drawing.Size(572, 368);
            this.lbxInDetail.TabIndex = 2;
            // 
            // tbpSort
            // 
            this.tbpSort.BackColor = System.Drawing.Color.Ivory;
            this.tbpSort.Controls.Add(this.lbxInSort);
            this.tbpSort.Controls.Add(this.panel1);
            this.tbpSort.Location = new System.Drawing.Point(4, 27);
            this.tbpSort.Name = "tbpSort";
            this.tbpSort.Size = new System.Drawing.Size(653, 451);
            this.tbpSort.TabIndex = 3;
            this.tbpSort.Text = "Sort";
            // 
            // lbxInSort
            // 
            this.lbxInSort.Font = new System.Drawing.Font("Cambria", 9F);
            this.lbxInSort.FormattingEnabled = true;
            this.lbxInSort.ItemHeight = 14;
            this.lbxInSort.Location = new System.Drawing.Point(35, 95);
            this.lbxInSort.Name = "lbxInSort";
            this.lbxInSort.Size = new System.Drawing.Size(579, 312);
            this.lbxInSort.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnSortByPerimeter);
            this.panel1.Controls.Add(this.rbtnSortByArea);
            this.panel1.Location = new System.Drawing.Point(9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 62);
            this.panel1.TabIndex = 0;
            // 
            // rbtnSortByPerimeter
            // 
            this.rbtnSortByPerimeter.AutoSize = true;
            this.rbtnSortByPerimeter.Location = new System.Drawing.Point(4, 31);
            this.rbtnSortByPerimeter.Name = "rbtnSortByPerimeter";
            this.rbtnSortByPerimeter.Size = new System.Drawing.Size(146, 22);
            this.rbtnSortByPerimeter.TabIndex = 1;
            this.rbtnSortByPerimeter.TabStop = true;
            this.rbtnSortByPerimeter.Text = "Sort by Perimeter";
            this.rbtnSortByPerimeter.UseVisualStyleBackColor = true;
            this.rbtnSortByPerimeter.CheckedChanged += new System.EventHandler(this.rbtnSortByPerimeter_CheckedChanged);
            // 
            // rbtnSortByArea
            // 
            this.rbtnSortByArea.AutoSize = true;
            this.rbtnSortByArea.Location = new System.Drawing.Point(4, 4);
            this.rbtnSortByArea.Name = "rbtnSortByArea";
            this.rbtnSortByArea.Size = new System.Drawing.Size(111, 22);
            this.rbtnSortByArea.TabIndex = 0;
            this.rbtnSortByArea.TabStop = true;
            this.rbtnSortByArea.Text = "Sort by Area";
            this.rbtnSortByArea.UseVisualStyleBackColor = true;
            this.rbtnSortByArea.CheckedChanged += new System.EventHandler(this.rbtnSortByArea_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 485);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Fun with Shapes";
            this.tabControl1.ResumeLayout(false);
            this.tbpCreate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpSummary.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tbpDetail.ResumeLayout(false);
            this.tbpSort.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCreate;
        private System.Windows.Forms.TabPage tbpSummary;
        private System.Windows.Forms.TabPage tbpDetail;
        private System.Windows.Forms.TabPage tbpSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private System.Windows.Forms.RadioButton rbtnRightTriangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCountRightTriangles;
        private System.Windows.Forms.Label lblCountCircles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountRectangles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountSquares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnSortByPerimeter;
        private System.Windows.Forms.RadioButton rbtnSortByArea;
        private System.Windows.Forms.ListBox lbxInSort;
        private System.Windows.Forms.ListBox lbxInDetail;
        private System.Windows.Forms.Label label1;
    }
}

