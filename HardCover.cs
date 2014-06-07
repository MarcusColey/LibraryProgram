using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryProgram
{
    [Serializable]
    public class HardCover : Book
    {
        public override void CreateBook(string name, string author, CommonFields.Genres genre, CommonFields.BookType coverType, float price, int uniqueID)
        {
            bookName = name;
            bookAuthor = author;
            bookGenre = genre;
            bookType = coverType;
            bookPrice = price;
            bookUniqueID = uniqueID;
            date = DateTime.Now;
        }
    }
}
