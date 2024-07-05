namespace PR6._2
{
    partial class SewingCurtains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SewingCurtains));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackSewingCurtains = new System.Windows.Forms.Button();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.comboBoxCurtainHeight = new System.Windows.Forms.ComboBox();
            this.comboBoxCurtainWidth = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeOfCurtains = new System.Windows.Forms.ComboBox();
            this.labelTypeOfCurtains = new System.Windows.Forms.Label();
            this.labelCurtainHeight = new System.Windows.Forms.Label();
            this.labelCurtainWidth = new System.Windows.Forms.Label();
            this.comboBoxFabricType = new System.Windows.Forms.ComboBox();
            this.labelFabricType = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(445, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 46);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnBackSewingCurtains
            // 
            this.btnBackSewingCurtains.BackColor = System.Drawing.Color.White;
            this.btnBackSewingCurtains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackSewingCurtains.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnBackSewingCurtains.ForeColor = System.Drawing.Color.Black;
            this.btnBackSewingCurtains.Location = new System.Drawing.Point(274, 197);
            this.btnBackSewingCurtains.Name = "btnBackSewingCurtains";
            this.btnBackSewingCurtains.Size = new System.Drawing.Size(141, 46);
            this.btnBackSewingCurtains.TabIndex = 52;
            this.btnBackSewingCurtains.Text = "Назад";
            this.btnBackSewingCurtains.UseVisualStyleBackColor = false;
            this.btnBackSewingCurtains.Click += new System.EventHandler(this.btnBackSewingCurtains_Click);
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.BackColor = System.Drawing.Color.White;
            this.groupBoxChoose.Controls.Add(this.comboBoxCurtainHeight);
            this.groupBoxChoose.Controls.Add(this.comboBoxCurtainWidth);
            this.groupBoxChoose.Controls.Add(this.comboBoxTypeOfCurtains);
            this.groupBoxChoose.Controls.Add(this.labelTypeOfCurtains);
            this.groupBoxChoose.Controls.Add(this.labelCurtainHeight);
            this.groupBoxChoose.Controls.Add(this.labelCurtainWidth);
            this.groupBoxChoose.Controls.Add(this.comboBoxFabricType);
            this.groupBoxChoose.Controls.Add(this.labelFabricType);
            this.groupBoxChoose.Location = new System.Drawing.Point(235, 6);
            this.groupBoxChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChoose.Size = new System.Drawing.Size(214, 185);
            this.groupBoxChoose.TabIndex = 53;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Выберите:";
            // 
            // comboBoxCurtainHeight
            // 
            this.comboBoxCurtainHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurtainHeight.FormattingEnabled = true;
            this.comboBoxCurtainHeight.Location = new System.Drawing.Point(116, 49);
            this.comboBoxCurtainHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCurtainHeight.Name = "comboBoxCurtainHeight";
            this.comboBoxCurtainHeight.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCurtainHeight.TabIndex = 51;
            // 
            // comboBoxCurtainWidth
            // 
            this.comboBoxCurtainWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurtainWidth.FormattingEnabled = true;
            this.comboBoxCurtainWidth.Location = new System.Drawing.Point(116, 24);
            this.comboBoxCurtainWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCurtainWidth.Name = "comboBoxCurtainWidth";
            this.comboBoxCurtainWidth.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCurtainWidth.TabIndex = 50;
            // 
            // comboBoxTypeOfCurtains
            // 
            this.comboBoxTypeOfCurtains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfCurtains.FormattingEnabled = true;
            this.comboBoxTypeOfCurtains.Location = new System.Drawing.Point(116, 98);
            this.comboBoxTypeOfCurtains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTypeOfCurtains.Name = "comboBoxTypeOfCurtains";
            this.comboBoxTypeOfCurtains.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTypeOfCurtains.TabIndex = 49;
            // 
            // labelTypeOfCurtains
            // 
            this.labelTypeOfCurtains.AutoSize = true;
            this.labelTypeOfCurtains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeOfCurtains.Location = new System.Drawing.Point(7, 98);
            this.labelTypeOfCurtains.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeOfCurtains.Name = "labelTypeOfCurtains";
            this.labelTypeOfCurtains.Size = new System.Drawing.Size(75, 17);
            this.labelTypeOfCurtains.TabIndex = 48;
            this.labelTypeOfCurtains.Text = "Тип штор:";
            // 
            // labelCurtainHeight
            // 
            this.labelCurtainHeight.AutoSize = true;
            this.labelCurtainHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurtainHeight.Location = new System.Drawing.Point(7, 49);
            this.labelCurtainHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurtainHeight.Name = "labelCurtainHeight";
            this.labelCurtainHeight.Size = new System.Drawing.Size(99, 17);
            this.labelCurtainHeight.TabIndex = 46;
            this.labelCurtainHeight.Text = "Высота штор:";
            // 
            // labelCurtainWidth
            // 
            this.labelCurtainWidth.AutoSize = true;
            this.labelCurtainWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurtainWidth.Location = new System.Drawing.Point(7, 24);
            this.labelCurtainWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurtainWidth.Name = "labelCurtainWidth";
            this.labelCurtainWidth.Size = new System.Drawing.Size(101, 17);
            this.labelCurtainWidth.TabIndex = 44;
            this.labelCurtainWidth.Text = "Ширина штор:";
            // 
            // comboBoxFabricType
            // 
            this.comboBoxFabricType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFabricType.FormattingEnabled = true;
            this.comboBoxFabricType.Location = new System.Drawing.Point(116, 73);
            this.comboBoxFabricType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFabricType.Name = "comboBoxFabricType";
            this.comboBoxFabricType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFabricType.TabIndex = 43;
            // 
            // labelFabricType
            // 
            this.labelFabricType.AutoSize = true;
            this.labelFabricType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFabricType.Location = new System.Drawing.Point(7, 73);
            this.labelFabricType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFabricType.Name = "labelFabricType";
            this.labelFabricType.Size = new System.Drawing.Size(79, 17);
            this.labelFabricType.TabIndex = 42;
            this.labelFabricType.Text = "Тип ткани:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(130, 111);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 26);
            this.btnStart.TabIndex = 55;
            this.btnStart.Text = "Запустить";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR6._2.Properties.Resources.Швейная_машинка;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // SewingCurtains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2.Properties.Resources.Задний_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 258);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackSewingCurtains);
            this.Controls.Add(this.groupBoxChoose);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(464, 297);
            this.MinimumSize = new System.Drawing.Size(464, 297);
            this.Name = "SewingCurtains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошив штор";
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackSewingCurtains;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.ComboBox comboBoxFabricType;
        private System.Windows.Forms.Label labelFabricType;
        private System.Windows.Forms.Label labelCurtainWidth;
        private System.Windows.Forms.ComboBox comboBoxTypeOfCurtains;
        private System.Windows.Forms.Label labelTypeOfCurtains;
        private System.Windows.Forms.Label labelCurtainHeight;
        private System.Windows.Forms.ComboBox comboBoxCurtainWidth;
        private System.Windows.Forms.ComboBox comboBoxCurtainHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
    }
}