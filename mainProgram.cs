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

            // QuantityRangeインスタンスを作成
            QuantityRange quantityRange = new QuantityRange();

            // MainQuantityを設定
            quantityRange.MainQuantity = 0;

            // 範囲チェック
            int checkedQuantity = quantityRange.CheckQuantityRange();

            //実行コマンド
            Application.Run(new MainForm(checkedQuantity));

        }
        public class MainForm : Form
        {
            private Label quantityLabel;
            public MainForm(int quantity)
            {
                // フォームの基本設定
                this.Text = "Inventory Management App";
                this.Size = new System.Drawing.Size(400, 300);

                // quantityを表示するラベルを作成
                quantityLabel = new Label();
                quantityLabel.Text = $"数量：{quantity}";
                quantityLabel.Location = new System.Drawing.Point(20, 20); // ラベルの表示位置
                quantityLabel.AutoSize = true;

                // ラベルをフォームに追加
                this.Controls.Add(quantityLabel);
            }
        }
    }
}
