namespace Student.WindowsTodo
{
    partial class AddTask
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.BtnCancel_Click = new System.Windows.Forms.Button();
            this.BtnSave_Click = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(63, 53);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(249, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // BtnCancel_Click
            // 
            this.BtnCancel_Click.Location = new System.Drawing.Point(216, 226);
            this.BtnCancel_Click.Name = "BtnCancel_Click";
            this.BtnCancel_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel_Click.TabIndex = 1;
            this.BtnCancel_Click.Text = "Отмена";
            this.BtnCancel_Click.UseVisualStyleBackColor = true;
            this.BtnCancel_Click.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnSave_Click
            // 
            this.BtnSave_Click.Location = new System.Drawing.Point(297, 226);
            this.BtnSave_Click.Name = "BtnSave_Click";
            this.BtnSave_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnSave_Click.TabIndex = 2;
            this.BtnSave_Click.Text = "Сохранить";
            this.BtnSave_Click.UseVisualStyleBackColor = true;
            this.BtnSave_Click.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(63, 110);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(249, 75);
            this.textBoxDescription.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(60, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Заголовок задачи:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(60, 94);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(98, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание задачи:";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.BtnSave_Click);
            this.Controls.Add(this.BtnCancel_Click);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "AddTask";
            this.Text = "Новая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button BtnCancel_Click;
        private System.Windows.Forms.Button BtnSave_Click;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
    }
}