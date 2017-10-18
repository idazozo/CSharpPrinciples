using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApplication
{
    /* An indexer allow an object to be indexed such as an array. 
       Properties return or set a specific data member, whereas indexers returns or sets 
       particular value from the object instance. In other words, it breaks the instance
       data into smaller parts and indexes each part, gets or sets each part.*/
    class IndexedNames
    {
        static public int size = 10;
        private string[] namelist = new string[size];
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        /* Indexers can be overloaded. Indexers can also be declared with multiple parameters
           and each parameter may be a different type. It is not necessary that the indexes 
           have to be integers. C# allows indexes to be of othr types, eg., a string. */
        public int this[string name]
        {
            get
            {
                int index = 0;
                while(index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            // using the first indexer with int parameter
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            // using the second indexer with the string parameter
            Console.WriteLine(names["Nuha"]);
            Console.ReadKey();
        }
    }
}
