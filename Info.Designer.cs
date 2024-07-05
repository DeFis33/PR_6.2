namespace PR6._2
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.btnBack = new System.Windows.Forms.Button();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.email = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.developer = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(69, 330);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(257, 69);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // emailLink
            // 
            this.emailLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.emailLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLink.AutoSize = true;
            this.emailLink.BackColor = System.Drawing.Color.White;
            this.emailLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLink.ForeColor = System.Drawing.Color.Black;
            this.emailLink.LinkColor = System.Drawing.Color.Black;
            this.emailLink.Location = new System.Drawing.Point(103, 200);
            this.emailLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(223, 25);
            this.emailLink.TabIndex = 30;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "https://vk.com/nee_gear";
            this.emailLink.VisitedLinkColor = System.Drawing.Color.White;
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.email.Location = new System.Drawing.Point(57, 200);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 25);
            this.email.TabIndex = 29;
            this.email.Text = "VK:";
            // 
            // specialization
            // 
            this.specialization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialization.AutoSize = true;
            this.specialization.BackColor = System.Drawing.Color.White;
            this.specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specialization.Location = new System.Drawing.Point(57, 155);
            this.specialization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(634, 25);
            this.specialization.TabIndex = 28;
            this.specialization.Text = "Специальность: Информационные системы и программирование";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title.Location = new System.Drawing.Point(180, 42);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(403, 29);
            this.title.TabIndex = 27;
            this.title.Text = "Программа <<Работа ателье>>";
            // 
            // developer
            // 
            this.developer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.developer.AutoSize = true;
            this.developer.BackColor = System.Drawing.Color.White;
            this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.developer.Location = new System.Drawing.Point(57, 113);
            this.developer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(236, 25);
            this.developer.TabIndex = 26;
            this.developer.Text = "Разработал: Пирогов Д.";
            // 
            // picture
            // 
            this.picture.Image = global::PR6._2.Properties.Resources.Швейная_фабрика;
            this.picture.Location = new System.Drawing.Point(366, 200);
            this.picture.Margin = new System.Windows.Forms.Padding(4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(380, 224);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 32;
            this.picture.TabStop = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2.Properties.Resources.Задний_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.emailLink);
            this.Controls.Add(this.email);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.title);
            this.Controls.Add(this.developer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label specialization;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label developer;
    }
}