namespace PR6._2
{
    partial class UrgentClothingRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrgentClothingRepair));
            this.btnBackUrgentClothingRepair = new System.Windows.Forms.Button();
            this.comboBoxRepairType = new System.Windows.Forms.ComboBox();
            this.labelRepairType = new System.Windows.Forms.Label();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.comboBoxTypeOfClothing = new System.Windows.Forms.ComboBox();
            this.labelTypeOfClothing = new System.Windows.Forms.Label();
            this.comboBoxUrgency = new System.Windows.Forms.ComboBox();
            this.labelUrgency = new System.Windows.Forms.Label();
            this.btnStartTheRepair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackUrgentClothingRepair
            // 
            this.btnBackUrgentClothingRepair.BackColor = System.Drawing.Color.White;
            this.btnBackUrgentClothingRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackUrgentClothingRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnBackUrgentClothingRepair.ForeColor = System.Drawing.Color.Black;
            this.btnBackUrgentClothingRepair.Location = new System.Drawing.Point(274, 197);
            this.btnBackUrgentClothingRepair.Name = "btnBackUrgentClothingRepair";
            this.btnBackUrgentClothingRepair.Size = new System.Drawing.Size(141, 46);
            this.btnBackUrgentClothingRepair.TabIndex = 33;
            this.btnBackUrgentClothingRepair.Text = "Назад";
            this.btnBackUrgentClothingRepair.UseVisualStyleBackColor = false;
            this.btnBackUrgentClothingRepair.Click += new System.EventHandler(this.btnBackUrgentClothingRepair_Click);
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
            // groupBoxChoose
            // 
            this.groupBoxChoose.BackColor = System.Drawing.Color.White;
            this.groupBoxChoose.Controls.Add(this.comboBoxTypeOfClothing);
            this.groupBoxChoose.Controls.Add(this.labelTypeOfClothing);
            this.groupBoxChoose.Controls.Add(this.comboBoxUrgency);
            this.groupBoxChoose.Controls.Add(this.labelUrgency);
            this.groupBoxChoose.Controls.Add(this.comboBoxRepairType);
            this.groupBoxChoose.Controls.Add(this.labelRepairType);
            this.groupBoxChoose.Location = new System.Drawing.Point(235, 6);
            this.groupBoxChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChoose.Size = new System.Drawing.Size(214, 185);
            this.groupBoxChoose.TabIndex = 51;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Выберите:";
            // 
            // comboBoxTypeOfClothing
            // 
            this.comboBoxTypeOfClothing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfClothing.FormattingEnabled = true;
            this.comboBoxTypeOfClothing.Location = new System.Drawing.Point(116, 49);
            this.comboBoxTypeOfClothing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTypeOfClothing.Name = "comboBoxTypeOfClothing";
            this.comboBoxTypeOfClothing.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTypeOfClothing.TabIndex = 47;
            // 
            // labelTypeOfClothing
            // 
            this.labelTypeOfClothing.AutoSize = true;
            this.labelTypeOfClothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeOfClothing.Location = new System.Drawing.Point(7, 49);
            this.labelTypeOfClothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeOfClothing.Name = "labelTypeOfClothing";
            this.labelTypeOfClothing.Size = new System.Drawing.Size(92, 17);
            this.labelTypeOfClothing.TabIndex = 46;
            this.labelTypeOfClothing.Text = "Тип одежды:";
            // 
            // comboBoxUrgency
            // 
            this.comboBoxUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrgency.FormattingEnabled = true;
            this.comboBoxUrgency.Location = new System.Drawing.Point(116, 73);
            this.comboBoxUrgency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxUrgency.Name = "comboBoxUrgency";
            this.comboBoxUrgency.Size = new System.Drawing.Size(92, 21);
            this.comboBoxUrgency.TabIndex = 45;
            // 
            // labelUrgency
            // 
            this.labelUrgency.AutoSize = true;
            this.labelUrgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUrgency.Location = new System.Drawing.Point(7, 73);
            this.labelUrgency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUrgency.Name = "labelUrgency";
            this.labelUrgency.Size = new System.Drawing.Size(82, 17);
            this.labelUrgency.TabIndex = 44;
            this.labelUrgency.Text = "Срочность:";
            // 
            // btnStartTheRepair
            // 
            this.btnStartTheRepair.BackColor = System.Drawing.Color.White;
            this.btnStartTheRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTheRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTheRepair.Location = new System.Drawing.Point(49, 117);
            this.btnStartTheRepair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartTheRepair.Name = "btnStartTheRepair";
            this.btnStartTheRepair.Size = new System.Drawing.Size(124, 26);
            this.btnStartTheRepair.TabIndex = 57;
            this.btnStartTheRepair.Text = "Начать ремонт";
            this.btnStartTheRepair.UseVisualStyleBackColor = false;
            this.btnStartTheRepair.Click += new System.EventHandler(this.btnStartTheRepair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR6._2.Properties.Resources.Ремонт_одежды;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // UrgentClothingRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2.Properties.Resources.Задний_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 258);
            this.Controls.Add(this.btnStartTheRepair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackUrgentClothingRepair);
            this.Controls.Add(this.groupBoxChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(464, 297);
            this.MinimumSize = new System.Drawing.Size(464, 297);
            this.Name = "UrgentClothingRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Срочный ремонт одежды";
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackUrgentClothingRepair;
        private System.Windows.Forms.ComboBox comboBoxRepairType;
        private System.Windows.Forms.Label labelRepairType;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.ComboBox comboBoxUrgency;
        private System.Windows.Forms.Label labelUrgency;
        private System.Windows.Forms.ComboBox comboBoxTypeOfClothing;
        private System.Windows.Forms.Label labelTypeOfClothing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartTheRepair;
    }
}