
namespace GADE_POE_task_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MapLabel = new System.Windows.Forms.Label();
            this.buttonUP1 = new System.Windows.Forms.Button();
            this.buttonRIGHT1 = new System.Windows.Forms.Button();
            this.buttonLEFT1 = new System.Windows.Forms.Button();
            this.buttonDown1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MapLabel
            // 
            this.MapLabel.AccessibleName = "MapLabel";
            this.MapLabel.AutoSize = true;
            this.MapLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapLabel.Location = new System.Drawing.Point(27, 39);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(38, 18);
            this.MapLabel.TabIndex = 0;
            this.MapLabel.Text = "Map";
            this.MapLabel.Click += new System.EventHandler(this.MapLabel_Click);
            // 
            // buttonUP1
            // 
            this.buttonUP1.Location = new System.Drawing.Point(675, 349);
            this.buttonUP1.Name = "buttonUP1";
            this.buttonUP1.Size = new System.Drawing.Size(40, 23);
            this.buttonUP1.TabIndex = 2;
            this.buttonUP1.Text = "^";
            this.buttonUP1.UseVisualStyleBackColor = true;
            this.buttonUP1.Click += new System.EventHandler(this.buttonUP1_Click);
            // 
            // buttonRIGHT1
            // 
            this.buttonRIGHT1.Location = new System.Drawing.Point(728, 376);
            this.buttonRIGHT1.Name = "buttonRIGHT1";
            this.buttonRIGHT1.Size = new System.Drawing.Size(40, 23);
            this.buttonRIGHT1.TabIndex = 3;
            this.buttonRIGHT1.Text = ">";
            this.buttonRIGHT1.UseVisualStyleBackColor = true;
            this.buttonRIGHT1.Click += new System.EventHandler(this.buttonRIGHT1_Click);
            // 
            // buttonLEFT1
            // 
            this.buttonLEFT1.Location = new System.Drawing.Point(620, 376);
            this.buttonLEFT1.Name = "buttonLEFT1";
            this.buttonLEFT1.Size = new System.Drawing.Size(40, 23);
            this.buttonLEFT1.TabIndex = 4;
            this.buttonLEFT1.Text = "<";
            this.buttonLEFT1.UseVisualStyleBackColor = true;
            this.buttonLEFT1.Click += new System.EventHandler(this.buttonLEFT1_Click);
            // 
            // buttonDown1
            // 
            this.buttonDown1.Location = new System.Drawing.Point(675, 408);
            this.buttonDown1.Name = "buttonDown1";
            this.buttonDown1.Size = new System.Drawing.Size(40, 23);
            this.buttonDown1.TabIndex = 5;
            this.buttonDown1.Text = "v";
            this.buttonDown1.UseVisualStyleBackColor = true;
            this.buttonDown1.Click += new System.EventHandler(this.buttonDown1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDown1);
            this.Controls.Add(this.buttonLEFT1);
            this.Controls.Add(this.buttonRIGHT1);
            this.Controls.Add(this.buttonUP1);
            this.Controls.Add(this.MapLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.Button buttonUP1;
        private System.Windows.Forms.Button buttonRIGHT1;
        private System.Windows.Forms.Button buttonLEFT1;
        private System.Windows.Forms.Button buttonDown1;
    }
}

