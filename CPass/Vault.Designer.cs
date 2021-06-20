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
            this.passlist = new System.Windows.Forms.ListBox();
            this.accountinfo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showPass = new System.Windows.Forms.Button();
            this.editAccount = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.copyPass = new System.Windows.Forms.Button();
            this.copyUser = new System.Windows.Forms.Button();
            this.PassGen = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.lockVault = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passlist);
            this.groupBox1.Controls.Add(this.deleteAccount);
            this.groupBox1.Controls.Add(this.editAccount);
            this.groupBox1.Controls.Add(this.addAccount);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Passwords:";
            // 
            // passlist
            // 
            this.passlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.passlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passlist.ForeColor = System.Drawing.Color.White;
            this.passlist.FormattingEnabled = true;
            this.passlist.ItemHeight = 23;
            this.passlist.Location = new System.Drawing.Point(6, 31);
            this.passlist.Name = "passlist";
            this.passlist.Size = new System.Drawing.Size(188, 437);
            this.passlist.TabIndex = 0;
            this.passlist.SelectedIndexChanged += new System.EventHandler(this.passlist_SelectedIndexChanged);
            // 
            // accountinfo
            // 
            this.accountinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.accountinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountinfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountinfo.ForeColor = System.Drawing.Color.White;
            this.accountinfo.FormattingEnabled = true;
            this.accountinfo.ItemHeight = 30;
            this.accountinfo.Location = new System.Drawing.Point(243, 43);
            this.accountinfo.Name = "accountinfo";
            this.accountinfo.Size = new System.Drawing.Size(320, 390);
            this.accountinfo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showPass);
            this.groupBox2.Controls.Add(this.PassGen);
            this.groupBox2.Controls.Add(this.copyPass);
            this.groupBox2.Controls.Add(this.copyUser);
            this.groupBox2.Controls.Add(this.accountinfo);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(396, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 490);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Info";
            // 
            // showPass
            // 
            this.showPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.showPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPass.ForeColor = System.Drawing.Color.White;
            this.showPass.Location = new System.Drawing.Point(31, 205);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(156, 74);
            this.showPass.TabIndex = 3;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = false;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // editAccount
            // 
            this.editAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.editAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.editAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAccount.ForeColor = System.Drawing.Color.White;
            this.editAccount.Location = new System.Drawing.Point(206, 112);
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(156, 75);
            this.editAccount.TabIndex = 5;
            this.editAccount.Text = "Edit Account";
            this.editAccount.UseVisualStyleBackColor = false;
            this.editAccount.Click += new System.EventHandler(this.editAccount_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.deleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.deleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccount.ForeColor = System.Drawing.Color.White;
            this.deleteAccount.Location = new System.Drawing.Point(206, 193);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(156, 75);
            this.deleteAccount.TabIndex = 3;
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = false;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // copyPass
            // 
            this.copyPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.copyPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.copyPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPass.ForeColor = System.Drawing.Color.White;
            this.copyPass.Location = new System.Drawing.Point(31, 127);
            this.copyPass.Name = "copyPass";
            this.copyPass.Size = new System.Drawing.Size(156, 75);
            this.copyPass.TabIndex = 4;
            this.copyPass.Text = "Copy Password";
            this.copyPass.UseVisualStyleBackColor = false;
            this.copyPass.Click += new System.EventHandler(this.button2_Click);
            // 
            // copyUser
            // 
            this.copyUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.copyUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.copyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyUser.ForeColor = System.Drawing.Color.White;
            this.copyUser.Location = new System.Drawing.Point(31, 43);
            this.copyUser.Name = "copyUser";
            this.copyUser.Size = new System.Drawing.Size(156, 82);
            this.copyUser.TabIndex = 3;
            this.copyUser.Text = "Copy Username";
            this.copyUser.UseVisualStyleBackColor = false;
            this.copyUser.Click += new System.EventHandler(this.copyUser_Click);
            // 
            // PassGen
            // 
            this.PassGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.PassGen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.PassGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassGen.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassGen.ForeColor = System.Drawing.Color.White;
            this.PassGen.Location = new System.Drawing.Point(29, 313);
            this.PassGen.Name = "PassGen";
            this.PassGen.Size = new System.Drawing.Size(158, 157);
            this.PassGen.TabIndex = 3;
            this.PassGen.Text = "Password Generator";
            this.PassGen.UseVisualStyleBackColor = false;
            this.PassGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // addAccount
            // 
            this.addAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.addAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.addAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccount.ForeColor = System.Drawing.Color.White;
            this.addAccount.Location = new System.Drawing.Point(206, 31);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(156, 75);
            this.addAccount.TabIndex = 4;
            this.addAccount.Text = "Add Account";
            this.addAccount.UseVisualStyleBackColor = false;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // lockVault
            // 
            this.lockVault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.lockVault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.lockVault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockVault.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockVault.ForeColor = System.Drawing.Color.White;
            this.lockVault.Location = new System.Drawing.Point(218, 376);
            this.lockVault.Name = "lockVault";
            this.lockVault.Size = new System.Drawing.Size(158, 136);
            this.lockVault.TabIndex = 5;
            this.lockVault.Text = "Lock Vault";
            this.lockVault.UseVisualStyleBackColor = false;
            this.lockVault.Click += new System.EventHandler(this.lockVault_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 34);
            this.panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(951, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(986, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lockVault);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPass - Your Vault";
            this.Activated += new System.EventHandler(this.Vault_Activated);
            this.Load += new System.EventHandler(this.Vault_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox passlist;
        private System.Windows.Forms.ListBox accountinfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyPass;
        private System.Windows.Forms.Button copyUser;
        private System.Windows.Forms.Button showPass;
        private System.Windows.Forms.Button editAccount;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Button PassGen;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.Button lockVault;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}