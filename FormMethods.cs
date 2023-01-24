using System;
using System.Drawing;
using System.Windows.Forms;

namespace MosEnergo2._0
{
    public class FormMethods
    {
        public static Form panelForm;
        public static void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            Control label = sender as Control;
            label.ForeColor = Color.Red;
        }

        public static void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            Control label = sender as Control;
            label.ForeColor = Color.Silver;
        }

        public static Point LastPoint;
        public static void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        public static void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Form trackingForm;
            if (sender is Panel)
            {
                Panel mainPanel = sender as Panel;
                trackingForm = mainPanel.FindForm();
            }
            else
            {
                trackingForm = sender as Form;
            }
            
            if (e.Button == MouseButtons.Left)
            {
                trackingForm.Location = new Point(Cursor.Position.X - LastPoint.X,
                    Cursor.Position.Y - LastPoint.Y);
            }
        }
    }
}
