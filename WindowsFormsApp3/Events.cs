using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp3
{
    public class TextBoxesCheck
    {
        public static Structs.Shop foundString;
        public static List<WindowsFormsApp3.Structs.Shop> listShop = new List<Structs.Shop>();
        public TextBoxesCheck()
        {
            
        }

        /*public void CheckBoxes()
        {
            MainProgramm.Form2 form = new MainProgramm.Form2();
            if(textBox1.)
        }*/


        public string[] CheckTextBoxes(string textbox3, string textbox5, string textbox6)
        {
            string cleanedtext3 = System.Text.RegularExpressions.Regex.Replace(textbox3, "[^0-9]", string.Empty);
            string cleanedtext5 = System.Text.RegularExpressions.Regex.Replace(textbox5, "[^0-9]", string.Empty);
            string cleanedtext6 = System.Text.RegularExpressions.Regex.Replace(textbox6, "[^0-9]", string.Empty);
            string[] returnCleaned = new string[3];
            returnCleaned[0] = cleanedtext3;
            returnCleaned[1] = cleanedtext5;
            returnCleaned[2] = cleanedtext6;
            return returnCleaned;
        }
        

        public void AddCaption(string _ShopName, string _Adress, int _Article, string _TovarName, int _Count, int _PricePerEach)
        {
            listShop.Add(new Structs.Shop(_ShopName, _Adress, _Article, _TovarName, _Count, _PricePerEach));
        }


        public Structs.Shop ShowStringFromBase(int _Article)
        {
            int listLength = listShop.Count;
            int article = _Article;
            Structs.Shop[] shops = new Structs.Shop[listLength];
            for(int i=0; i<listLength; i++)
            {
                shops[i] = (Structs.Shop)listShop[i];
                if (shops[i].Article == article)
                {
                    foundString = shops[i];
                }
                
            }
            return foundString;
        }




        public void RedactShopname(int _Article, string _ShopName)
        {
            Structs.Shop shop = ShowStringFromBase(_Article);
            shop.ShopName = _ShopName;
        }

        public void RedactAdress(int _Article, string _Adress)
        {
            Structs.Shop shop = ShowStringFromBase(_Article);
            shop.Adress = _Adress;
        }

        public void RedactArticle(int _Article)
        {
            Structs.Shop shop = ShowStringFromBase(_Article);
            shop.Article = _Article;
        }

        public void RedactTovarname(int _Article, string _TovarName)
        {
            Structs.Shop shop = ShowStringFromBase(_Article);
            shop.TovarName = _TovarName;
        }

        public void RedactCount(int _Article, int _Count)
        {
            Structs.Shop shop = ShowStringFromBase(_Article);
            shop.Count = _Count;
        }

        public void RedactPricePerEach(int _Article, int _Price)
        {
            Structs.Shop shop = ShowStringFromBase(_Article);
            shop.PricePerEach = _Price;
        }
    }
}
