namespace UnusualPlantsOfTheWorld
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Help = new System.Windows.Forms.Button();
            this.Field = new System.Windows.Forms.DataGridView();
            this.Greeting = new System.Windows.Forms.Label();
            this.Greeting1 = new System.Windows.Forms.Label();
            this.Greeting2 = new System.Windows.Forms.Label();
            this.BarForQuestion = new System.Windows.Forms.RichTextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.EnterFiled = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.White;
            this.Help.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.Location = new System.Drawing.Point(0, 0);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(40, 40);
            this.Help.TabIndex = 0;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // Field
            // 
            this.Field.AllowUserToAddRows = false;
            this.Field.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Field.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Field.BackgroundColor = System.Drawing.Color.White;
            this.Field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Field.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Field.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Field.DefaultCellStyle = dataGridViewCellStyle1;
            this.Field.EnableHeadersVisualStyles = false;
            this.Field.GridColor = System.Drawing.Color.White;
            this.Field.Location = new System.Drawing.Point(0, 0);
            this.Field.MultiSelect = false;
            this.Field.Name = "Field";
            this.Field.ReadOnly = true;
            this.Field.RowHeadersVisible = false;
            this.Field.Size = new System.Drawing.Size(634, 524);
            this.Field.TabIndex = 1;
            this.Field.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Field_CellClick);
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.BackColor = System.Drawing.Color.Transparent;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greeting.ForeColor = System.Drawing.Color.Green;
            this.Greeting.Location = new System.Drawing.Point(645, 260);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(231, 54);
            this.Greeting.TabIndex = 2;
            this.Greeting.Text = "Welcome!";
            // 
            // Greeting1
            // 
            this.Greeting1.AutoSize = true;
            this.Greeting1.BackColor = System.Drawing.Color.Transparent;
            this.Greeting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greeting1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Greeting1.Location = new System.Drawing.Point(650, 334);
            this.Greeting1.Name = "Greeting1";
            this.Greeting1.Size = new System.Drawing.Size(243, 22);
            this.Greeting1.TabIndex = 3;
            this.Greeting1.Text = "Click on any pink cell to start ";
            // 
            // Greeting2
            // 
            this.Greeting2.AutoSize = true;
            this.Greeting2.BackColor = System.Drawing.Color.Transparent;
            this.Greeting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greeting2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Greeting2.Location = new System.Drawing.Point(650, 356);
            this.Greeting2.Name = "Greeting2";
            this.Greeting2.Size = new System.Drawing.Size(228, 22);
            this.Greeting2.TabIndex = 3;
            this.Greeting2.Text = "solving a crossword puzzle ";
            // 
            // BarForQuestion
            // 
            this.BarForQuestion.BackColor = System.Drawing.Color.White;
            this.BarForQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarForQuestion.Enabled = false;
            this.BarForQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarForQuestion.ForeColor = System.Drawing.Color.Purple;
            this.BarForQuestion.Location = new System.Drawing.Point(654, 338);
            this.BarForQuestion.Name = "BarForQuestion";
            this.BarForQuestion.ReadOnly = true;
            this.BarForQuestion.Size = new System.Drawing.Size(336, 117);
            this.BarForQuestion.TabIndex = 4;
            this.BarForQuestion.Text = "";
            this.BarForQuestion.Visible = false;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Location = new System.Drawing.Point(654, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(336, 320);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            this.PictureBox.Visible = false;
            // 
            // EnterFiled
            // 
            this.EnterFiled.BackColor = System.Drawing.Color.White;
            this.EnterFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterFiled.Location = new System.Drawing.Point(654, 474);
            this.EnterFiled.Name = "EnterFiled";
            this.EnterFiled.Size = new System.Drawing.Size(234, 29);
            this.EnterFiled.TabIndex = 6;
            this.EnterFiled.Text = "Type here...";
            this.EnterFiled.Visible = false;
            this.EnterFiled.Enter += new System.EventHandler(this.EnterFiled_Enter);
            this.EnterFiled.Leave += new System.EventHandler(this.EnterFiled_Leave);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.White;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(894, 474);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(96, 29);
            this.Enter.TabIndex = 7;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Visible = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 524);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.EnterFiled);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.BarForQuestion);
            this.Controls.Add(this.Greeting2);
            this.Controls.Add(this.Greeting1);
            this.Controls.Add(this.Greeting);
            this.Controls.Add(this.Field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive crossword puzzle: Unusual Plants of the World";
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Label Greeting1;
        private System.Windows.Forms.Label Greeting2;
        private System.Windows.Forms.RichTextBox BarForQuestion;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox EnterFiled;
        private System.Windows.Forms.Button Enter;
        public System.Windows.Forms.DataGridView Field;
    }
}

