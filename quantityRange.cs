using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagementApp
{
    internal class QuantityRange
    {
        // プライベートフィールド
        private int mainQuantity;
        
        // MainQuantityプロパティ
        public int MainQuantity
        {
            get { return mainQuantity; }
            set { mainQuantity = value; }
        }

        // 数量の範囲をチェックするメソッド
        public int CheckQuantityRange()
        {
            if (mainQuantity <= 0)
            {
                return 0;
            }
            else if (mainQuantity >= 9999)
            {
                return 9999;
            }
            else
            {
                return mainQuantity;
            }
        }
    }
}
