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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passlist);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Passwords:";
            // 
            // passlist
            // 
            this.passlist.FormattingEnabled = true;
            this.passlist.ItemHeight = 23;
            this.passlist.Location = new System.Drawing.Point(6, 31);
            this.passlist.Name = "passlist";
            this.passlist.Size = new System.Drawing.Size(188, 441);
            this.passlist.TabIndex = 0;
            this.passlist.SelectedIndexChanged += new System.EventHandler(this.passlist_SelectedIndexChanged);
            // 
            // accountinfo
            // 
            this.accountinfo.FormattingEnabled = true;
            this.accountinfo.ItemHeight = 23;
            this.accountinfo.Location = new System.Drawing.Point(206, 52);
            this.accountinfo.Name = "accountinfo";
            this.accountinfo.Size = new System.Drawing.Size(320, 418);
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
            this.groupBox2.Location = new System.Drawing.Point(396, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 495);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Info";
            // 
            // showPass
            // 
            this.showPass.Location = new System.Drawing.Point(31, 205);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(156, 74);
            this.showPass.TabIndex = 3;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // editAccount
            // 
            this.editAccount.Location = new System.Drawing.Point(31, 314);
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(156, 75);
            this.editAccount.TabIndex = 5;
            this.editAccount.Text = "Edit Account";
            this.editAccount.UseVisualStyleBackColor = true;
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(31, 395);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(156, 75);
            this.deleteAccount.TabIndex = 3;
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = true;
            // 
            // copyPass
            // 
            this.copyPass.Location = new System.Drawing.Point(31, 127);
            this.copyPass.Name = "copyPass";
            this.copyPass.Size = new System.Drawing.Size(156, 75);
            this.copyPass.TabIndex = 4;
            this.copyPass.Text = "Copy Password";
            this.copyPass.UseVisualStyleBackColor = true;
            this.copyPass.Click += new System.EventHandler(this.button2_Click);
            // 
            // copyUser
            // 
            this.copyUser.Location = new System.Drawing.Point(31, 52);
            this.copyUser.Name = "copyUser";
            this.copyUser.Size = new System.Drawing.Size(156, 73);
            this.copyUser.TabIndex = 3;
            this.copyUser.Text = "Copy Username";
            this.copyUser.UseVisualStyleBackColor = true;
            this.copyUser.Click += new System.EventHandler(this.copyUser_Click);
            // 
            // PassGen
            // 
            this.PassGen.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassGen.Location = new System.Drawing.Point(232, 160);
            this.PassGen.Name = "PassGen";
            this.PassGen.Size = new System.Drawing.Size(158, 157);
            this.PassGen.TabIndex = 3;
            this.PassGen.Text = "Password Generator";
            this.PassGen.UseVisualStyleBackColor = true;
            this.PassGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // addAccount
            // 
            this.addAccount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccount.Location = new System.Drawing.Point(232, 22);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(158, 132);
            this.addAccount.TabIndex = 4;
            this.addAccount.Text = "Add Account";
            this.addAccount.UseVisualStyleBackColor = true;
            // 
            // lockVault
            // 
            this.lockVault.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockVault.Location = new System.Drawing.Point(232, 326);
            this.lockVault.Name = "lockVault";
            this.lockVault.Size = new System.Drawing.Size(158, 136);
            this.lockVault.TabIndex = 5;
            this.lockVault.Text = "Lock Vault";
            this.lockVault.UseVisualStyleBackColor = true;
            this.lockVault.Click += new System.EventHandler(this.lockVault_Click);
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 514);
            this.Controls.Add(this.lockVault);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.PassGen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}