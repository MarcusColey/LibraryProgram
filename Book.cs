using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryProgram
{
    [Serializable]
    public abstract class Book
    {
        protected string bookName;
        protected string bookAuthor;
        //enum Genre { } // Could be string - This is subject to change
        protected CommonFields.Genres bookGenre;
        protected CommonFields.BookType bookType;
        protected float bookPrice;
        protected int bookUniqueID;
        protected DateTime date;

        public abstract void CreateBook(string name, string author, CommonFields.Genres genre, CommonFields.BookType coverType, float price, int uniqueID);
        public void GetInfo(out string name, out string author, out CommonFields.Genres genre, out CommonFields.BookType coverType, out float price, out int uniqueID, out DateTime date)
        {
            name = this.bookName;
            author = this.bookAuthor;
            genre = this.bookGenre;
            coverType = this.bookType;
            price = this.bookPrice;
            uniqueID = this.bookUniqueID;
            date = this.date;
        }
   
    }
}
