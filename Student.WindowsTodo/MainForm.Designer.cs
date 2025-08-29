namespace Student.WindowsTodo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnAdd_Click = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.taskManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd_Click
            // 
            this.BtnAdd_Click.Location = new System.Drawing.Point(12, 12);
            this.BtnAdd_Click.Name = "BtnAdd_Click";
            this.BtnAdd_Click.Size = new System.Drawing.Size(118, 23);
            this.BtnAdd_Click.TabIndex = 2;
            this.BtnAdd_Click.Text = "Добавить задачу";
            this.BtnAdd_Click.UseVisualStyleBackColor = true;
            this.BtnAdd_Click.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(24, 41);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(346, 380);
            this.dataGridViewTasks.TabIndex = 4;
            // 
            // taskManagerBindingSource
            // 
            this.taskManagerBindingSource.DataSource = typeof(Student.WindowsTodo.TaskManager);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 433);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.BtnAdd_Click);
            this.Name = "MainForm";
            this.Text = "Тодо";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd_Click;
        private System.Windows.Forms.BindingSource taskManagerBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
    }
}