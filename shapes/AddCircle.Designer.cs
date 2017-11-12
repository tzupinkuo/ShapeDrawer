namespace shapes
{
    partial class AddCircle
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnAdd.Location = new System.Drawing.Point(197, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Shape";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(63, 16);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Radius";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerimeter.Location = new System.Drawing.Point(85, 123);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(100, 23);
            this.lblPerimeter.TabIndex = 23;
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Perimeter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Location = new System.Drawing.Point(85, 85);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 23);
            this.lblArea.TabIndex = 21;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Area";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiameter
            // 
            this.lblDiameter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiameter.Location = new System.Drawing.Point(85, 49);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(100, 23);
            this.lblDiameter.TabIndex = 19;
            this.lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label8.Location = new System.Drawing.Point(15, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Diameter";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(197, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(286, 447);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxRadius);
            this.Controls.Add(this.label1);
            this.Name = "AddCircle";
            this.Text = "Add Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
    }
}