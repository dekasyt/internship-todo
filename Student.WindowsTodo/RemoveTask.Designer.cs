namespace Student.WindowsTodo
{
    partial class RemoveTask
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
            this.BtnConfirmDeletionTask_Clik = new System.Windows.Forms.Button();
            this.BtnCancelDeletionTask_Clik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirmDeletionTask_Clik
            // 
            this.BtnConfirmDeletionTask_Clik.Location = new System.Drawing.Point(52, 107);
            this.BtnConfirmDeletionTask_Clik.Name = "BtnConfirmDeletionTask_Clik";
            this.BtnConfirmDeletionTask_Clik.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmDeletionTask_Clik.TabIndex = 0;
            this.BtnConfirmDeletionTask_Clik.Text = "Да";
            this.BtnConfirmDeletionTask_Clik.UseVisualStyleBackColor = true;
            this.BtnConfirmDeletionTask_Clik.Click += new System.EventHandler(this.btnConfirmDeletionTask_Clik);
            // 
            // BtnCancelDeletionTask_Clik
            // 
            this.BtnCancelDeletionTask_Clik.Location = new System.Drawing.Point(170, 107);
            this.BtnCancelDeletionTask_Clik.Name = "BtnCancelDeletionTask_Clik";
            this.BtnCancelDeletionTask_Clik.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelDeletionTask_Clik.TabIndex = 1;
            this.BtnCancelDeletionTask_Clik.Text = "Нет";
            this.BtnCancelDeletionTask_Clik.UseVisualStyleBackColor = true;
            this.BtnCancelDeletionTask_Clik.Click += new System.EventHandler(this.btnCancelDeletionTask_Clik);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы действительно хотите удалить задачу?";
            // 
            // RemoveTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelDeletionTask_Clik);
            this.Controls.Add(this.BtnConfirmDeletionTask_Clik);
            this.Name = "RemoveTask";
            this.Text = "Удалить задачу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmDeletionTask_Clik;
        private System.Windows.Forms.Button BtnCancelDeletionTask_Clik;
        private System.Windows.Forms.Label label1;

    }
}