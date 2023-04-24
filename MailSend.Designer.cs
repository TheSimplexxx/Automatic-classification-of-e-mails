namespace Test
{
    partial class MailSend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Button();
            this.MailRev = new System.Windows.Forms.Panel();
            this.ToWhom = new System.Windows.Forms.TextBox();
            this.Tema = new System.Windows.Forms.TextBox();
            this.MailText = new System.Windows.Forms.TextBox();
            this.Review = new System.Windows.Forms.Button();
            this.SendPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.MailRev.SuspendLayout();
            this.SendPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(102)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.Send);
            this.panel1.Controls.Add(this.MailRev);
            this.panel1.Controls.Add(this.Review);
            this.panel1.Controls.Add(this.SendPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 899);
            this.panel1.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.AutoSize = true;
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Send.FlatAppearance.BorderSize = 2;
            this.Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(63)))));
            this.Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(189)))), ((int)(((byte)(71)))));
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(434, 745);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(142, 43);
            this.Send.TabIndex = 13;
            this.Send.Text = "Надіслати";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // MailRev
            // 
            this.MailRev.BackColor = System.Drawing.Color.Green;
            this.MailRev.Controls.Add(this.ToWhom);
            this.MailRev.Controls.Add(this.Tema);
            this.MailRev.Controls.Add(this.MailText);
            this.MailRev.Location = new System.Drawing.Point(12, 181);
            this.MailRev.Name = "MailRev";
            this.MailRev.Size = new System.Drawing.Size(564, 558);
            this.MailRev.TabIndex = 12;
            // 
            // ToWhom
            // 
            this.ToWhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ToWhom.Location = new System.Drawing.Point(3, 63);
            this.ToWhom.Name = "ToWhom";
            this.ToWhom.Size = new System.Drawing.Size(558, 53);
            this.ToWhom.TabIndex = 2;
            this.ToWhom.Enter += new System.EventHandler(this.ToWhom_Enter);
            this.ToWhom.Leave += new System.EventHandler(this.ToWhom_Leave);
           
            // 
            // Tema
            // 
            this.Tema.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tema.Location = new System.Drawing.Point(3, 3);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(558, 53);
            this.Tema.TabIndex = 1;
            this.Tema.Enter += new System.EventHandler(this.Tema_Enter);
            this.Tema.Leave += new System.EventHandler(this.Tema_Leave);
       
            // 
            // MailText
            // 
            this.MailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailText.Location = new System.Drawing.Point(3, 123);
            this.MailText.Multiline = true;
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(558, 430);
            this.MailText.TabIndex = 0;
            this.MailText.Enter += new System.EventHandler(this.MailText_Enter);
            this.MailText.Leave += new System.EventHandler(this.MailText_Leave);
           
            // 
            // Review
            // 
            this.Review.AutoSize = true;
            this.Review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.Review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Review.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Review.FlatAppearance.BorderSize = 2;
            this.Review.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(63)))));
            this.Review.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(189)))), ((int)(((byte)(71)))));
            this.Review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Review.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review.Location = new System.Drawing.Point(12, 132);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(246, 43);
            this.Review.TabIndex = 11;
            this.Review.Text = "Переглянути пошту";
            this.Review.UseVisualStyleBackColor = false;
            this.Review.Click += new System.EventHandler(this.Review_Click);
            // 
            // SendPanel
            // 
            this.SendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
            this.SendPanel.Controls.Add(this.CloseButton);
            this.SendPanel.Controls.Add(this.label1);
            this.SendPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SendPanel.Location = new System.Drawing.Point(0, 0);
            this.SendPanel.Name = "SendPanel";
            this.SendPanel.Size = new System.Drawing.Size(588, 126);
            this.SendPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(561, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 24);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(240)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Надіслати листа ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MailSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 899);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MailRev.ResumeLayout(false);
            this.MailRev.PerformLayout();
            this.SendPanel.ResumeLayout(false);
            this.SendPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SendPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Review;
        private System.Windows.Forms.Panel MailRev;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.TextBox Tema;
        private System.Windows.Forms.TextBox ToWhom;
    }
}