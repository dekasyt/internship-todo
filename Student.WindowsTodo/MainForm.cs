using System;
using System.Windows.Forms;

namespace Student.WindowsTodo
{
    /// <summary>
    /// Главная форма приложения со списком задач.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект для управления задачами.
        /// </summary>
        private readonly TaskManager taskManager = new TaskManager();

        /// <summary>
        /// Инициализирует главную форму и настраивает таблицу задач.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dataGridViewTasks.Columns.Clear();

            dataGridViewTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleColumn",
                HeaderText = "Задача",
                ReadOnly = true
            });

            dataGridViewTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DescriptionColumn",
                HeaderText = "Описание",
                ReadOnly = true
            });

            dataGridViewTasks.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "",
                Text = "Удалить",
                UseColumnTextForButtonValue = true
            });
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.MultiSelect = false;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;

            RefreshTaskList();
        }

        /// <summary>
        /// Открывает форму добавления задачи.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddTask())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    taskManager.AddTask(addForm.NewTask);
                    RefreshTaskList();
                }
            }

        }

        /// <summary>
        /// Обрабатывает нажатие кнопки Удалить в таблице.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTasks.Columns["DeleteColumn"].Index)
            {
                using (var confirmForm = new RemoveTask())
                {
                    if (confirmForm.ShowDialog() == DialogResult.OK)
                    {
                        taskManager.RemoveTask(e.RowIndex);
                        RefreshTaskList();
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет таблицу задач в интерфейсе.
        /// </summary>
        private void RefreshTaskList()
        {
            dataGridViewTasks.Rows.Clear();
            foreach (var task in taskManager.GetTasks())
            {
                dataGridViewTasks.Rows.Add(task.Title, task.Description);
            }
        }
    }
}