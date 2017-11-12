namespace shapes
{
    partial class AddRectangle
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
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxSide1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSide2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerimeter.Location = new System.Drawing.Point(85, 125);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(100, 23);
            this.lblPerimeter.TabIndex = 24;
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Perimeter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Location = new System.Drawing.Point(85, 89);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 23);
            this.lblArea.TabIndex = 22;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnAdd.Location = new System.Drawing.Point(186, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Shape";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSide1
            // 
            this.tbxSide1.Location = new System.Drawing.Point(55, 17);
            this.tbxSide1.Name = "tbxSide1";
            this.tbxSide1.Size = new System.Drawing.Size(100, 20);
            this.tbxSide1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Side 1";
            // 
            // tbxSide2
            // 
            this.tbxSide2.Location = new System.Drawing.Point(55, 52);
            this.tbxSide2.Name = "tbxSide2";
            this.tbxSide2.Size = new System.Drawing.Size(100, 20);
            this.tbxSide2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Side 2";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(186, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(286, 447);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxSide1);
            this.Controls.Add(this.label1);
            this.Name = "AddRectangle";
            this.Text = "Add Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxSide1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSide2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}