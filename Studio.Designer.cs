namespace PR6._2
{
    partial class Studio
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studio));
            this.btnEntrance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrance
            // 
            this.btnEntrance.BackColor = System.Drawing.Color.White;
            this.btnEntrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntrance.Location = new System.Drawing.Point(433, 289);
            this.btnEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(237, 75);
            this.btnEntrance.TabIndex = 0;
            this.btnEntrance.Text = "Вход в ателье";
            this.btnEntrance.UseVisualStyleBackColor = false;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2.Properties.Resources.vyveski_10_1000x1000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.btnEntrance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Studio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ателье";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrance;
    }
}

