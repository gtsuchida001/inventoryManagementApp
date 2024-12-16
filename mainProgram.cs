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

            // QuantityRange�C���X�^���X���쐬
            QuantityRange quantityRange = new QuantityRange();

            // MainQuantity��ݒ�
            quantityRange.MainQuantity = 0;

            // �͈̓`�F�b�N
            int checkedQuantity = quantityRange.CheckQuantityRange();

            //���s�R�}���h
            Application.Run(new MainForm(checkedQuantity));

        }
        public class MainForm : Form
        {
            private Label quantityLabel;
            public MainForm(int quantity)
            {
                // �t�H�[���̊�{�ݒ�
                this.Text = "Inventory Management App";
                this.Size = new System.Drawing.Size(400, 300);

                // quantity��\�����郉�x�����쐬
                quantityLabel = new Label();
                quantityLabel.Text = $"���ʁF{quantity}";
                quantityLabel.Location = new System.Drawing.Point(20, 20); // ���x���̕\���ʒu
                quantityLabel.AutoSize = true;

                // ���x�����t�H�[���ɒǉ�
                this.Controls.Add(quantityLabel);
            }
        }
    }
}
