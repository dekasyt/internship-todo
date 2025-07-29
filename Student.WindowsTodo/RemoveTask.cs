using System;
using System.Windows.Forms;

namespace Student.WindowsTodo
{
    /// <summary>
    /// Окно подтверждения удаления задачи.
    /// </summary>
    public partial class RemoveTask : Form
    {
        /// <summary>
        /// Инициализирует форму подтверждения удаления.
        /// </summary>
        public RemoveTask()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Подтверждает удаление задачи и закрывает окно.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Отменяет удаление задачи и закрывает окно.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void buttonNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}