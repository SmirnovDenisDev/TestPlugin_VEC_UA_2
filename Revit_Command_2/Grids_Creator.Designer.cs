
namespace Revit_Command_2
{
    partial class Grids_Creator
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_GridVerNumber = new System.Windows.Forms.TextBox();
            this.textBox_GridVerDistance = new System.Windows.Forms.TextBox();
            this.textBox_GridHorNumber = new System.Windows.Forms.TextBox();
            this.textBox_GridHorDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create new grids!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_GridVerNumber
            // 
            this.textBox_GridVerNumber.Location = new System.Drawing.Point(25, 131);
            this.textBox_GridVerNumber.Name = "textBox_GridVerNumber";
            this.textBox_GridVerNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_GridVerNumber.TabIndex = 1;
            this.textBox_GridVerNumber.Text = "0";
            // 
            // textBox_GridVerDistance
            // 
            this.textBox_GridVerDistance.Location = new System.Drawing.Point(199, 131);
            this.textBox_GridVerDistance.Name = "textBox_GridVerDistance";
            this.textBox_GridVerDistance.Size = new System.Drawing.Size(100, 20);
            this.textBox_GridVerDistance.TabIndex = 2;
            this.textBox_GridVerDistance.Text = "0";
            // 
            // textBox_GridHorNumber
            // 
            this.textBox_GridHorNumber.Location = new System.Drawing.Point(25, 62);
            this.textBox_GridHorNumber.Name = "textBox_GridHorNumber";
            this.textBox_GridHorNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_GridHorNumber.TabIndex = 3;
            this.textBox_GridHorNumber.Text = "0";
            // 
            // textBox_GridHorDistance
            // 
            this.textBox_GridHorDistance.Location = new System.Drawing.Point(199, 62);
            this.textBox_GridHorDistance.Name = "textBox_GridHorDistance";
            this.textBox_GridHorDistance.Size = new System.Drawing.Size(100, 20);
            this.textBox_GridHorDistance.TabIndex = 4;
            this.textBox_GridHorDistance.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set number of Hor grids! (Max 25)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set number of Ver grids! (Max 25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Set distance for Hor grids!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Set distance for Ver grids!";
            // 
            // Grids_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 224);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_GridHorDistance);
            this.Controls.Add(this.textBox_GridHorNumber);
            this.Controls.Add(this.textBox_GridVerDistance);
            this.Controls.Add(this.textBox_GridVerNumber);
            this.Controls.Add(this.button1);
            this.Name = "Grids_Creator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_GridVerNumber;
        private System.Windows.Forms.TextBox textBox_GridVerDistance;
        private System.Windows.Forms.TextBox textBox_GridHorNumber;
        private System.Windows.Forms.TextBox textBox_GridHorDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}