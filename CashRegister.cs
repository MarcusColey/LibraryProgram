using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryProgram
{
    public class CashRegister
    {
        const float taxPercentage = 0.13f;

        public float CalculatePrice(float price)
        {
            float tax = price * taxPercentage;
            float total = price + tax;

            return total;
        }

        public void DisplayPrice(float price, TextBox textBox)
        {
            textBox.Text = price.ToString();
        }

        public void DisplayInformation(Book book)
        {
            string bookName = null;
            string bookAuthor = null;
            CommonFields.Genres genre = new CommonFields.Genres();
            CommonFields.BookType coverType = new CommonFields.BookType();
            float price = 0;
            int uniqueID = 0;
            DateTime date = new DateTime();

            book.GetInfo(out bookName, out bookAuthor, out genre, out coverType, out price, out uniqueID, out date);
 
            MessageBox.Show("Book name : " + bookName + "\n" +
                "Book author : " + bookAuthor + "\n" +
                "Book genre : " + genre + "\n" +
                "Cover type : " + coverType + "\n" +
                "Book price : " + "$" + price + "\n" +
                "Book ID : " + uniqueID + "\n" + 
                "Information storage date : " + date);
        }
    }
}
