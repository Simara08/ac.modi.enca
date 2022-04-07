using System.Collections.Generic;

namespace Printable
{
   public   class Language
    {
        public Language(string name, int creationdate)
        {
            Name = name;
            CreationDate = creationdate;
        }
        private static string name;
        public string Name
        {
            get { return name; }
            set { value = name; }
        }
        private static int creationdate;
        public int CreationDate
        {
            get { return creationdate; }
            set { value = creationdate; }
        }
        public override string ToString()
        {
            return Name+ " ($" + CreationDate.ToString() + ")";
        }
    }
    public class LanguageDateComparer:IComparer<Language>
    {
        public int Compare(Language x, Language y)
        {
            if (x.CreationDate>y.CreationDate)
            
                return 1;
            
            if (x.CreationDate<y.CreationDate)
            
                return -1;
            return 0;

        }
    }
    public class LanguagetNameComparer : IComparer<Language>
    {
        public int Compare(Language x, Language y)
        {
            return x.Name.CompareTo(y.Name);
        }
            
    }

}