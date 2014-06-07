using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryProgram
{
    [Serializable]
    public class Magazine
    {
        string name;
        int issueYear;
        int issueNumber;
        int uniqueID;

        public Magazine(string name, int issueYear, int issueNumber, int uniqueID)
        {
            this.name = name;
            this.issueYear = issueYear;
            this.issueNumber = issueNumber;
            this.uniqueID = uniqueID;
        }
    }
}
