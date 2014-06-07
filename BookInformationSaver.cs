using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryProgram
{
    public class BookInformationSaver
    {
        public void SaveInformation(Book book)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();

            if (!string.IsNullOrWhiteSpace(saveFile.FileName))
            {
                Stream stream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, book);
                stream.Close();
            }
            else
                return;
        }

        public void LoadInformation()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openFile.FileName))
            {
                Stream stream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                IFormatter formatter = new BinaryFormatter();

                try
                {
                    Book deserializedBook = (Book)formatter.Deserialize(stream);

                    CashRegister register = new CashRegister();
                    register.DisplayInformation(deserializedBook);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Invalid file type please choose a valid file.");
                }
            }
        }
    }
}