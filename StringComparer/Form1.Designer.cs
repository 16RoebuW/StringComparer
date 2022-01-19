namespace StringComparer
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxStringX = new System.Windows.Forms.TextBox();
            this.tbxStringY = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 40F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(785, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STRING COMpARER!!!! ultimate";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxStringX
            // 
            this.tbxStringX.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tbxStringX.Location = new System.Drawing.Point(135, 194);
            this.tbxStringX.Name = "tbxStringX";
            this.tbxStringX.Size = new System.Drawing.Size(519, 53);
            this.tbxStringX.TabIndex = 1;
            this.tbxStringX.Text = "String X input";
            // 
            // tbxStringY
            // 
            this.tbxStringY.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tbxStringY.Location = new System.Drawing.Point(135, 253);
            this.tbxStringY.Name = "tbxStringY";
            this.tbxStringY.Size = new System.Drawing.Size(519, 53);
            this.tbxStringY.TabIndex = 2;
            this.tbxStringY.Text = "String Y input";
            this.tbxStringY.TextChanged += new System.EventHandler(this.tbxStringY_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnCalculate.Location = new System.Drawing.Point(135, 312);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(252, 53);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tbxOutput.Location = new System.Drawing.Point(393, 312);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(261, 53);
            this.tbxOutput.TabIndex = 4;
            this.tbxOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxStringY);
            this.Controls.Add(this.tbxStringX);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxStringX;
        private System.Windows.Forms.TextBox tbxStringY;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxOutput;
    }
}

