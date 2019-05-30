using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
     public class Structs
    {
        public void Connection()
        {
            MainProgramm.SqlEssentials essentials = new MainProgramm.SqlEssentials();
            bool listCheck = false;
            if (!listCheck)
            {
                List<WindowsFormsApp3.Structs.Shop> listShop = new List<WindowsFormsApp3.Structs.Shop>();
                listCheck = true;
            }
            try
            {
                string connectionstring = essentials.ReturnConnectionString();



            }
            catch (System.Data.SqlClient.SqlException exc)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка " + exc.Message);
            }
        }
       public struct Shop
        {
            string ShopName;
            string Adress;
            int Article;
            string TovarName;
            int Count;
            int PricePerEach;
            int Price4All;
            public Shop(string _ShopName, string _Adress, int _Article, string _TovarName, int _Count, int _PricePerEach)
            {
                ShopName = _ShopName;
                Adress = _Adress;
                Article = _Article;
                TovarName = _TovarName;
                Count = _Count;
                PricePerEach = _PricePerEach;
                Price4All = _Count * _PricePerEach;
            }
        };
    }
}
