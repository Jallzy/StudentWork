using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsoccuring2
{
    public partial class Form1 : Form
    {

        private TaskManager taskManager = new TaskManager();
         private void UpdateTaskList()
        {
            listBoxTasks.DataSource = null;

            listBoxTasks.DataSource = taskManager.GetTasks();
        }
        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            using (TaskEntryForm taskEntryForm = new TaskEntryForm())
            {
                if (taskEntryForm.ShowDialog() == DialogResult.OK)
                {
                    Task t = new Task(taskEntryForm.TaskTitle,
                                      taskEntryForm.TaskDescription,
                                      taskEntryForm.TaskDueDate);
                    taskManager.AddTask(t);
                    UpdateTaskList();
                }
            }
        }
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem is Task selectedTask)
            {
                using (TaskEntryForm taskEntryForm = new TaskEntryForm())
                {
                    //populate the form
                    taskEntryForm.TaskTitle = selectedTask.Title;
                    taskEntryForm.TaskDescription = selectedTask.Description;
                    taskEntryForm.TaskDueDate = selectedTask.DueDate;

                    if (taskEntryForm.ShowDialog() == DialogResult.OK)
                    {
                        //if updated, repopulate the task and update
                        selectedTask.Title = taskEntryForm.TaskTitle;
                        selectedTask.Description = taskEntryForm.TaskDescription;
                        selectedTask.DueDate = taskEntryForm.TaskDueDate;
                        UpdateTaskList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a task to edit!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

            if (listBoxTasks.SelectedItem is Task selectedTask)
            {
                var result = MessageBox.Show("Are you sure you want to delete the task?",
                                         "Deleting task",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    taskManager.RemoveTask(selectedTask);
                    UpdateTaskList();
                }
            }

            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
    }
}
