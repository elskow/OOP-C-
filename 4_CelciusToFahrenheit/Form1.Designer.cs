namespace _4_CelciusToFahrenheit
{
    partial class CelciusToFahrenheit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CelciusToFahrenheit));
            this.label1 = new System.Windows.Forms.Label();
            this.Celcius = new System.Windows.Forms.TextBox();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF UI  Text G 4", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celcius";
            // 
            // Celcius
            // 
            this.Celcius.Font = new System.Drawing.Font("SF UI  Text G 3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celcius.Location = new System.Drawing.Point(159, 63);
            this.Celcius.Name = "Celcius";
            this.Celcius.Size = new System.Drawing.Size(100, 25);
            this.Celcius.TabIndex = 1;
            this.Celcius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Celcius.TextChanged += new System.EventHandler(this.Celcius_TextChanged);
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Font = new System.Drawing.Font("SF UI  Text G 3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fahrenheit.Location = new System.Drawing.Point(159, 156);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(100, 25);
            this.Fahrenheit.TabIndex = 3;
            this.Fahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fahrenheit.TextChanged += new System.EventHandler(this.Fahrenheit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF UI  Text G 4", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("SF UI  Text G 4", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(172, 103);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 38);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CelciusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 259);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Celcius);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF UI  Text G 4", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CelciusToFahrenheit";
            this.Text = "Celcius To Fahrenheit";
            this.Load += new System.EventHandler(this.CelciusToFahrenheit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Celcius;
        private System.Windows.Forms.TextBox Fahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertButton;
    }
}

