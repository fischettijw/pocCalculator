namespace pocCalculator
{
    partial class FrmCalculatorPOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculatorPOC));
            this.TxtMemory = new System.Windows.Forms.TextBox();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.TxtOperation = new System.Windows.Forms.TextBox();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMemory
            // 
            this.TxtMemory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemory.Location = new System.Drawing.Point(29, 12);
            this.TxtMemory.Name = "TxtMemory";
            this.TxtMemory.Size = new System.Drawing.Size(314, 62);
            this.TxtMemory.TabIndex = 0;
            this.TxtMemory.Text = "01234567891";
            this.TxtMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDisplay.Location = new System.Drawing.Point(29, 92);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(436, 89);
            this.TxtDisplay.TabIndex = 1;
            this.TxtDisplay.Text = "012345678901";
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay.WordWrap = false;
            // 
            // TxtOperation
            // 
            this.TxtOperation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TxtOperation.Location = new System.Drawing.Point(376, 14);
            this.TxtOperation.Name = "TxtOperation";
            this.TxtOperation.ReadOnly = true;
            this.TxtOperation.Size = new System.Drawing.Size(89, 60);
            this.TxtOperation.TabIndex = 40;
            this.TxtOperation.TabStop = false;
            this.TxtOperation.Text = "+";
            this.TxtOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(253, 198);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(89, 80);
            this.Btn7.TabIndex = 41;
            this.Btn7.TabStop = false;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(29, 198);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(89, 80);
            this.Btn1.TabIndex = 42;
            this.Btn1.TabStop = false;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(141, 198);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(89, 80);
            this.Btn4.TabIndex = 43;
            this.Btn4.TabStop = false;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(376, 198);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(89, 80);
            this.BtnMultiply.TabIndex = 44;
            this.BtnMultiply.TabStop = false;
            this.BtnMultiply.Text = "X";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(376, 298);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(89, 80);
            this.BtnPlus.TabIndex = 45;
            this.BtnPlus.TabStop = false;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.Location = new System.Drawing.Point(29, 298);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(313, 80);
            this.BtnEqual.TabIndex = 46;
            this.BtnEqual.TabStop = false;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // FrmCalculatorPOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 408);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.TxtOperation);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.TxtMemory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculatorPOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proof of Concept - Calculator";
            this.Load += new System.EventHandler(this.FrmCalculatorPOC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMemory;
        private System.Windows.Forms.TextBox TxtDisplay;
        internal System.Windows.Forms.TextBox TxtOperation;
        internal System.Windows.Forms.Button Btn7;
        internal System.Windows.Forms.Button Btn1;
        internal System.Windows.Forms.Button Btn4;
        internal System.Windows.Forms.Button BtnMultiply;
        internal System.Windows.Forms.Button BtnPlus;
        internal System.Windows.Forms.Button BtnEqual;
    }
}

