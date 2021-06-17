namespace CPass
{
    partial class PassGen
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
            this.lblPass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barLength = new System.Windows.Forms.TrackBar();
            this.optSymbols = new System.Windows.Forms.CheckBox();
            this.optNumbers = new System.Windows.Forms.CheckBox();
            this.optLower = new System.Windows.Forms.CheckBox();
            this.optCapitals = new System.Windows.Forms.CheckBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(110, 39);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(196, 47);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.barLength);
            this.groupBox1.Controls.Add(this.optSymbols);
            this.groupBox1.Controls.Add(this.optNumbers);
            this.groupBox1.Controls.Add(this.optLower);
            this.groupBox1.Controls.Add(this.optCapitals);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length";
            // 
            // barLength
            // 
            this.barLength.Location = new System.Drawing.Point(6, 233);
            this.barLength.Maximum = 16;
            this.barLength.Minimum = 8;
            this.barLength.Name = "barLength";
            this.barLength.Size = new System.Drawing.Size(191, 69);
            this.barLength.TabIndex = 1;
            this.barLength.Value = 8;
            this.barLength.Scroll += new System.EventHandler(this.barLength_Scroll);
            // 
            // optSymbols
            // 
            this.optSymbols.AutoSize = true;
            this.optSymbols.Location = new System.Drawing.Point(11, 155);
            this.optSymbols.Name = "optSymbols";
            this.optSymbols.Size = new System.Drawing.Size(121, 27);
            this.optSymbols.TabIndex = 3;
            this.optSymbols.Text = "!@#$%^&*";
            this.optSymbols.UseVisualStyleBackColor = true;
            // 
            // optNumbers
            // 
            this.optNumbers.AutoSize = true;
            this.optNumbers.Location = new System.Drawing.Point(11, 112);
            this.optNumbers.Name = "optNumbers";
            this.optNumbers.Size = new System.Drawing.Size(77, 27);
            this.optNumbers.TabIndex = 2;
            this.optNumbers.Text = "0 - 9";
            this.optNumbers.UseVisualStyleBackColor = true;
            // 
            // optLower
            // 
            this.optLower.AutoSize = true;
            this.optLower.Location = new System.Drawing.Point(11, 70);
            this.optLower.Name = "optLower";
            this.optLower.Size = new System.Drawing.Size(78, 27);
            this.optLower.TabIndex = 1;
            this.optLower.Text = "a - z";
            this.optLower.UseVisualStyleBackColor = true;
            // 
            // optCapitals
            // 
            this.optCapitals.AutoSize = true;
            this.optCapitals.Location = new System.Drawing.Point(11, 31);
            this.optCapitals.Name = "optCapitals";
            this.optCapitals.Size = new System.Drawing.Size(80, 27);
            this.optCapitals.TabIndex = 0;
            this.optCapitals.Text = "A - Z";
            this.optCapitals.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(231, 127);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(167, 85);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Regenerate Password";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(231, 218);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(167, 79);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy Password";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(254, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 78);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(7, 279);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(21, 23);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "8";
            // 
            // PassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPass);
            this.Name = "PassGen";
            this.Text = "CPass - Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar barLength;
        private System.Windows.Forms.CheckBox optSymbols;
        private System.Windows.Forms.CheckBox optNumbers;
        private System.Windows.Forms.CheckBox optLower;
        private System.Windows.Forms.CheckBox optCapitals;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLength;
    }
}