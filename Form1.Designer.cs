namespace Chat_Messenger_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name:";
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(175, 264);
            this.userTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(303, 22);
            this.userTxtBox.TabIndex = 1;
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(175, 333);
            this.passTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(303, 22);
            this.passTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(139, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Messenger Plus";
            // 
            // logoIcon
            // 
            this.logoIcon.BackColor = System.Drawing.Color.Transparent;
            this.logoIcon.BackgroundImage = global::Chat_Messenger_Client.Properties.Resources.chatBubble;
            this.logoIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoIcon.Location = new System.Drawing.Point(261, 98);
            this.logoIcon.Name = "logoIcon";
            this.logoIcon.Size = new System.Drawing.Size(133, 115);
            this.logoIcon.TabIndex = 8;
            this.logoIcon.TabStop = false;
            // 
            // connectBtn
            // 
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Image = global::Chat_Messenger_Client.Properties.Resources.connectBtn;
            this.connectBtn.Location = new System.Drawing.Point(215, 402);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(231, 43);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            this.connectBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.connectBtn_MouseDown);
            this.connectBtn.MouseLeave += new System.EventHandler(this.connectBtn_MouseLeave);
            this.connectBtn.MouseHover += new System.EventHandler(this.connectBtn_MouseHover);
            this.connectBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.connectBtn_MouseUp);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::Chat_Messenger_Client.Properties.Resources.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(215, 501);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(231, 43);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseDown);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
            this.exitBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseUp);
            // 
            // signUpBtn
            // 
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Image = global::Chat_Messenger_Client.Properties.Resources.signUpBtn;
            this.signUpBtn.Location = new System.Drawing.Point(215, 451);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(231, 43);
            this.signUpBtn.TabIndex = 2;
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signUpBtn_MouseDown);
            this.signUpBtn.MouseLeave += new System.EventHandler(this.signUpBtn_MouseLeave);
            this.signUpBtn.MouseHover += new System.EventHandler(this.signUpBtn_MouseHover);
            this.signUpBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.signUpBtn_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat_Messenger_Client.Properties.Resources.back_plate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 568);
            this.ControlBox = false;
            this.Controls.Add(this.logoIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logoIcon;
    }
}

