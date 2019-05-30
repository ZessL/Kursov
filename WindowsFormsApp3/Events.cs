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


        public Structs.Shop ShowStringFromBase(string _Article)
        {
            int listLength = listShop.Count;
            string Article = System.Text.RegularExpressions.Regex.Replace(_Article, "[^0-9]", "");
            Article = Article.ToString();
           // System.Windows.Forms.MessageBox.Show(Article);
            int article = ConvertToInt(Article);
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

       /* public int GetStruct(string _Article)
        {
            int listLength = listShop.Count;
            _Article = System.Text.RegularExpressions.Regex.Replace(_Article, "[^0-9]", string.Empty);
            int article = System.Convert.ToInt32(_Article);
            Structs.Shop[] shops = new Structs.Shop[listLength];
            Structs.Shop foundString;
            int i = 0;
            do
            {
                if (i >= listLength)
                {
                    return -1;
                }
                
                else if(i<listLength)
                {
                    shops[i] = (Structs.Shop)listShop[i];
                    if (shops[i].Article == article)
                    {
                        foundString = shops[i];
                        return i;
                    }
                }
                else
                {
                    return -10;
                }

            } while (i < listLength);
            return -100;
        }*/

        public int ConvertToInt(string Article)
        {
            int outString = System.Convert.ToInt32(Article);
            return outString;
        }
    }
}
