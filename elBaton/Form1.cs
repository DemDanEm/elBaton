using Microsoft.VisualBasic.Logging;

namespace elBaton
{

    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();
        int selectedIdx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1)
            {
                return;
            }

            tasks.Add(new Task(textBox1.Text, comboBox1.SelectedIndex + 1));

            update();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIdx = listBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tasks[selectedIdx].active = false;
            update();
        }

        private void update()
        {
            if (radioButton1.Checked)
            {
                tasks = tasks.OrderBy(task => task.prio).ToList();
            }
            else if (radioButton2.Checked)
            {
                tasks = tasks.OrderBy(task => task.text).ToList();

            }

            listBox1.Items.Clear();

            foreach (Task task in tasks)
            {
                if (checkBox1.Checked)
                {
                    listBox1.Items.Add($"Task: {task.text}; Prio: {task.prio}; Status: {task.active}");
                }
                else
                {
                    if (task.active)
                    {
                        listBox1.Items.Add($"Task: {task.text}; Prio: {task.prio}; Status: {task.active}");
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }

    public class Task
    {
        public string text;
        public int prio;
        public bool active = true;

        public Task(string ntext, int nprio) 
        {
            text = ntext;
            prio = nprio;
        }
    }

}
