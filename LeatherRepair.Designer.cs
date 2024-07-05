namespace PR6._2
{
    partial class LeatherRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeatherRepair));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackLeatherRepair = new System.Windows.Forms.Button();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.comboBoxSkinColor = new System.Windows.Forms.ComboBox();
            this.labelSkinColor = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.labelProductType = new System.Windows.Forms.Label();
            this.comboBoxRepairType = new System.Windows.Forms.ComboBox();
            this.labelRepairType = new System.Windows.Forms.Label();
            this.btnStartTheRepair = new System.Windows.Forms.Button();
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
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnBackLeatherRepair
            // 
            this.btnBackLeatherRepair.BackColor = System.Drawing.Color.White;
            this.btnBackLeatherRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackLeatherRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnBackLeatherRepair.ForeColor = System.Drawing.Color.Black;
            this.btnBackLeatherRepair.Location = new System.Drawing.Point(274, 197);
            this.btnBackLeatherRepair.Name = "btnBackLeatherRepair";
            this.btnBackLeatherRepair.Size = new System.Drawing.Size(141, 46);
            this.btnBackLeatherRepair.TabIndex = 52;
            this.btnBackLeatherRepair.Text = "Назад";
            this.btnBackLeatherRepair.UseVisualStyleBackColor = false;
            this.btnBackLeatherRepair.Click += new System.EventHandler(this.btnBackLeatherRepair_Click);
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.BackColor = System.Drawing.Color.White;
            this.groupBoxChoose.Controls.Add(this.comboBoxSkinColor);
            this.groupBoxChoose.Controls.Add(this.labelSkinColor);
            this.groupBoxChoose.Controls.Add(this.comboBoxProductType);
            this.groupBoxChoose.Controls.Add(this.labelProductType);
            this.groupBoxChoose.Controls.Add(this.comboBoxRepairType);
            this.groupBoxChoose.Controls.Add(this.labelRepairType);
            this.groupBoxChoose.Location = new System.Drawing.Point(235, 6);
            this.groupBoxChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChoose.Size = new System.Drawing.Size(214, 185);
            this.groupBoxChoose.TabIndex = 53;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Выберите:";
            // 
            // comboBoxSkinColor
            // 
            this.comboBoxSkinColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkinColor.FormattingEnabled = true;
            this.comboBoxSkinColor.Location = new System.Drawing.Point(116, 73);
            this.comboBoxSkinColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSkinColor.Name = "comboBoxSkinColor";
            this.comboBoxSkinColor.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSkinColor.TabIndex = 47;
            // 
            // labelSkinColor
            // 
            this.labelSkinColor.AutoSize = true;
            this.labelSkinColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkinColor.Location = new System.Drawing.Point(7, 73);
            this.labelSkinColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkinColor.Name = "labelSkinColor";
            this.labelSkinColor.Size = new System.Drawing.Size(81, 17);
            this.labelSkinColor.TabIndex = 46;
            this.labelSkinColor.Text = "Цвет кожи:";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(116, 49);
            this.comboBoxProductType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxProductType.TabIndex = 45;
            // 
            // labelProductType
            // 
            this.labelProductType.AutoSize = true;
            this.labelProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductType.Location = new System.Drawing.Point(7, 49);
            this.labelProductType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductType.Name = "labelProductType";
            this.labelProductType.Size = new System.Drawing.Size(96, 17);
            this.labelProductType.TabIndex = 44;
            this.labelProductType.Text = "Тип изделия:";
            // 
            // comboBoxRepairType
            // 
            this.comboBoxRepairType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRepairType.FormattingEnabled = true;
            this.comboBoxRepairType.Location = new System.Drawing.Point(116, 24);
            this.comboBoxRepairType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRepairType.Name = "comboBoxRepairType";
            this.comboBoxRepairType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxRepairType.TabIndex = 43;
            // 
            // labelRepairType
            // 
            this.labelRepairType.AutoSize = true;
            this.labelRepairType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepairType.Location = new System.Drawing.Point(7, 24);
            this.labelRepairType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRepairType.Name = "labelRepairType";
            this.labelRepairType.Size = new System.Drawing.Size(97, 17);
            this.labelRepairType.TabIndex = 42;
            this.labelRepairType.Text = "Тип ремонта:";
            // 
            // btnStartTheRepair
            // 
            this.btnStartTheRepair.BackColor = System.Drawing.Color.White;
            this.btnStartTheRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTheRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTheRepair.Location = new System.Drawing.Point(57, 121);
            this.btnStartTheRepair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartTheRepair.Name = "btnStartTheRepair";
            this.btnStartTheRepair.Size = new System.Drawing.Size(124, 26);
            this.btnStartTheRepair.TabIndex = 58;
            this.btnStartTheRepair.Text = "Начать ремонт";
            this.btnStartTheRepair.UseVisualStyleBackColor = false;
            this.btnStartTheRepair.Click += new System.EventHandler(this.btnStartTheRepair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR6._2.Properties.Resources.Кожаное_изделие;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // LeatherRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2.Properties.Resources.Задний_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 258);
            this.Controls.Add(this.btnStartTheRepair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackLeatherRepair);
            this.Controls.Add(this.groupBoxChoose);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(464, 297);
            this.MinimumSize = new System.Drawing.Size(464, 297);
            this.Name = "LeatherRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт кожаных изделий";
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackLeatherRepair;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.ComboBox comboBoxRepairType;
        private System.Windows.Forms.Label labelRepairType;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Label labelProductType;
        private System.Windows.Forms.ComboBox comboBoxSkinColor;
        private System.Windows.Forms.Label labelSkinColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartTheRepair;
    }
}