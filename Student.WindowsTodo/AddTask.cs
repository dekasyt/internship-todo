using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student.WindowsTodo
{
    /// <summary>
    /// Окно добавления новой задачи.
    /// </summary>
    public partial class AddTask : Form
    {
        /// <summary>
        /// Новая задача.
        /// </summary>
        public Task NewTask { get; private set; }

        /// <summary>
        /// Инициализирует форму добавления задачи.
        /// </summary>
        public AddTask()
        {
            InitializeComponent();

            textBoxTitle.ForeColor = Color.Gray;
            textBoxTitle.Text = "Введите заголовок задачи...";

            textBoxTitle.GotFocus += (s, e) =>
            {
                if (textBoxTitle.ForeColor == Color.Gray)
                {
                    textBoxTitle.Text = "";
                    textBoxTitle.ForeColor = Color.Black;
                }
            };

            textBoxTitle.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
                {
                    textBoxTitle.Text = "Введите заголовок задачи...";
                    textBoxTitle.ForeColor = Color.Gray;
                }
            };

            textBoxDescription.ForeColor = Color.Gray;
            textBoxDescription.Text = "Введите описание задачи...";

            textBoxDescription.GotFocus += (s, e) =>
            {
                if (textBoxDescription.ForeColor == Color.Gray)
                {
                    textBoxDescription.Text = "";
                    textBoxDescription.ForeColor = Color.Black;
                }
            };

            textBoxDescription.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
                {
                    textBoxDescription.Text = "Введите описание задачи...";
                    textBoxDescription.ForeColor = Color.Gray;
                }
            };
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки ОК, создаёт задачу и закрывает окно.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            string description = textBoxDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || textBoxTitle.ForeColor == Color.Gray)
            {
                MessageBox.Show("Введите заголовок задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(description) || textBoxDescription.ForeColor == Color.Gray)
            {
                MessageBox.Show("Введите описание задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}