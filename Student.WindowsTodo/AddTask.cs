using System;
using System.Windows.Forms;

namespace Student.WindowsTodo
{
    /// <summary>
    /// Окно добавления новой задачи.
    /// </summary>
    public partial class AddTask : Form
    {
        /// <summary>
        /// Получает созданную задачу после нажатия ОК.
        /// </summary>
        public Task NewTask { get; private set; }

        /// <summary>
        /// Инициализирует форму добавления задачи.
        /// </summary>
        public AddTask()
        {
            InitializeComponent();
            textBoxTitle.MaxLength = 25;
            textBoxDescription.MaxLength = 50;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки ОК, создаёт задачу и закрывает окно.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            string description = textBoxDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введите название задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (title.Length > 25)
            {
                MessageBox.Show("Заголовок не может превышать 25 символов.");
                return;
            }
            if (description.Length > 50)
            {
                MessageBox.Show("Описание не может превышать 50 символов.");
                return;
            }
            NewTask = new Task(title, description);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Отменяет создание задачи и закрывает окно.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}