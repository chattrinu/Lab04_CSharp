namespace Chattin_Udomsomporn_Ex02
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
            this.components = new System.ComponentModel.Container();
            this.bttInp = new System.Windows.Forms.Button();
            this.bttCle = new System.Windows.Forms.Button();
            this.bttRem = new System.Windows.Forms.Button();
            this.bttSum = new System.Windows.Forms.Button();
            this.bttAve = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttInp
            // 
            this.bttInp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInp.Location = new System.Drawing.Point(374, 117);
            this.bttInp.Name = "bttInp";
            this.bttInp.Size = new System.Drawing.Size(118, 43);
            this.bttInp.TabIndex = 1;
            this.bttInp.Text = "Input";
            this.bttInp.UseVisualStyleBackColor = true;
            this.bttInp.Click += new System.EventHandler(this.bttInp_Click);
            // 
            // bttCle
            // 
            this.bttCle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCle.Location = new System.Drawing.Point(374, 178);
            this.bttCle.Name = "bttCle";
            this.bttCle.Size = new System.Drawing.Size(118, 43);
            this.bttCle.TabIndex = 2;
            this.bttCle.Text = "Clear";
            this.bttCle.UseVisualStyleBackColor = true;
            this.bttCle.Click += new System.EventHandler(this.bttCle_Click);
            // 
            // bttRem
            // 
            this.bttRem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRem.Location = new System.Drawing.Point(374, 237);
            this.bttRem.Name = "bttRem";
            this.bttRem.Size = new System.Drawing.Size(118, 43);
            this.bttRem.TabIndex = 3;
            this.bttRem.Text = "Remove";
            this.bttRem.UseVisualStyleBackColor = true;
            this.bttRem.Click += new System.EventHandler(this.bttRem_Click);
            // 
            // bttSum
            // 
            this.bttSum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSum.Location = new System.Drawing.Point(374, 286);
            this.bttSum.Name = "bttSum";
            this.bttSum.Size = new System.Drawing.Size(118, 43);
            this.bttSum.TabIndex = 4;
            this.bttSum.Text = "Sum";
            this.bttSum.UseVisualStyleBackColor = true;
            this.bttSum.Click += new System.EventHandler(this.bttSum_Click);
            // 
            // bttAve
            // 
            this.bttAve.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAve.Location = new System.Drawing.Point(374, 335);
            this.bttAve.Name = "bttAve";
            this.bttAve.Size = new System.Drawing.Size(118, 43);
            this.bttAve.TabIndex = 5;
            this.bttAve.Text = "Average";
            this.bttAve.UseVisualStyleBackColor = true;
            this.bttAve.Click += new System.EventHandler(this.bttAve_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(374, 46);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(167, 30);
            this.txtnum1.TabIndex = 8;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.FormattingEnabled = true;
            this.num2.ItemHeight = 23;
            this.num2.Location = new System.Drawing.Point(33, 46);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(261, 303);
            this.num2.TabIndex = 9;
            this.num2.SelectedIndexChanged += new System.EventHandler(this.num2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.bttAve);
            this.Controls.Add(this.bttSum);
            this.Controls.Add(this.bttRem);
            this.Controls.Add(this.bttCle);
            this.Controls.Add(this.bttInp);
            this.Name = "Form1";
            this.Text = "Grade book form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttInp;
        private System.Windows.Forms.Button bttCle;
        private System.Windows.Forms.Button bttRem;
        private System.Windows.Forms.Button bttSum;
        private System.Windows.Forms.Button bttAve;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.ListBox num2;
    }
}

