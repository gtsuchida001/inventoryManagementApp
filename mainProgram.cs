using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagementApp
{
    internal static class mainProgram
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            QuantityRange quantityRange = new QuantityRange();
            quantityRange.MainQuantity = 0;
            int checkedQuantity = quantityRange.CheckQuantityRange();
            Application.Run(new MainForm(checkedQuantity));

        }
        public class MainForm : Form
        {
            private Label quantityLabel;
            public MainForm(int quantity)
            {
                this.Text = "Inventory Management App";
                this.Size = new System.Drawing.Size(400, 300);

                quantityLabel = new Label();
                quantityLabel.Text = $"数量:{quantity}";
                quantityLabel.Location = new System.Drawing.Point(20, 20);
                quantityLabel.AutoSize = true;

                this.Controls.Add(quantityLabel);
            }
        }
    }
}