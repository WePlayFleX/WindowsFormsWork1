using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsWork1
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            Text = "Label Example";
            ClientSize = new Size(800, 600);

            Label label = new Label();
            label.Parent = this;
            label.BackColor = Color.Yellow;
            label.AutoSize = true;
            label.Size = new Size(780, 580);
            label.Location = new Point(10, 10);
            label.Font = new Font("Arial", 48);


            Button button = new Button

            {
                Parent = this,
                Location = new Point(10, 50),
                Size = new Size(100, 50),
                Text = "Text"
            };

            button.Click += Button_Click;


            private void Button_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Сложение");
            }
        }
    }

    
}
