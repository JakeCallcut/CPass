namespace CPass
{
    partial class Vault
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropdownpasses = new System.Windows.Forms.ComboBox();
            this.passlist = new System.Windows.Forms.ListBox();
            this.accountinfo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyUser = new System.Windows.Forms.Button();
            this.copyPass = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.editAccount = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passlist);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Passwords:";
            // 
            // dropdownpasses
            // 
            this.dropdownpasses.FormattingEnabled = true;
            this.dropdownpasses.Location = new System.Drawing.Point(12, 12);
            this.dropdownpasses.Name = "dropdownpasses";
            this.dropdownpasses.Size = new System.Drawing.Size(200, 28);
            this.dropdownpasses.TabIndex = 0;
            // 
            // passlist
            // 
            this.passlist.FormattingEnabled = true;
            this.passlist.ItemHeight = 23;
            this.passlist.Location = new System.Drawing.Point(6, 25);
            this.passlist.Name = "passlist";
            this.passlist.Size = new System.Drawing.Size(188, 372);
            this.passlist.TabIndex = 0;
            // 
            // accountinfo
            // 
            this.accountinfo.FormattingEnabled = true;
            this.accountinfo.ItemHeight = 23;
            this.accountinfo.Location = new System.Drawing.Point(199, 59);
            this.accountinfo.Name = "accountinfo";
            this.accountinfo.Size = new System.Drawing.Size(299, 372);
            this.accountinfo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showPass);
            this.groupBox2.Controls.Add(this.editAccount);
            this.groupBox2.Controls.Add(this.deleteAccount);
            this.groupBox2.Controls.Add(this.copyPass);
            this.groupBox2.Controls.Add(this.copyUser);
            this.groupBox2.Controls.Add(this.accountinfo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 449);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Info";
            // 
            // copyUser
            // 
            this.copyUser.Location = new System.Drawing.Point(31, 59);
            this.copyUser.Name = "copyUser";
            this.copyUser.Size = new System.Drawing.Size(138, 62);
            this.copyUser.TabIndex = 3;
            this.copyUser.Text = "Copy Username";
            this.copyUser.UseVisualStyleBackColor = true;
            // 
            // copyPass
            // 
            this.copyPass.Location = new System.Drawing.Point(31, 127);
            this.copyPass.Name = "copyPass";
            this.copyPass.Size = new System.Drawing.Size(138, 62);
            this.copyPass.TabIndex = 4;
            this.copyPass.Text = "Copy Password";
            this.copyPass.UseVisualStyleBackColor = true;
            this.copyPass.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(31, 370);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(138, 61);
            this.deleteAccount.TabIndex = 3;
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = true;
            // 
            // editAccount
            // 
            this.editAccount.Location = new System.Drawing.Point(31, 301);
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(138, 63);
            this.editAccount.TabIndex = 5;
            this.editAccount.Text = "Edit Account";
            this.editAccount.UseVisualStyleBackColor = true;
            // 
            // showPass
            // 
            this.showPass.Location = new System.Drawing.Point(31, 195);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(138, 63);
            this.showPass.TabIndex = 3;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dropdownpasses);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vault";
            this.Text = "CPass - Your Vault";
            this.Load += new System.EventHandler(this.Vault_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox passlist;
        private System.Windows.Forms.ComboBox dropdownpasses;
        private System.Windows.Forms.ListBox accountinfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyPass;
        private System.Windows.Forms.Button copyUser;
        private System.Windows.Forms.Button showPass;
        private System.Windows.Forms.Button editAccount;
        private System.Windows.Forms.Button deleteAccount;
    }
}