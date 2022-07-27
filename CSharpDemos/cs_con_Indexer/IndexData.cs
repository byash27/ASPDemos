using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Indexer
{
    internal class IndexData
    {
        // Aggregated Collection
        private string[] _names;

        public IndexData()
        {
            _names = new string[] { "" +
                "Ben Stokes",
                "Joe Root",
                "Jos Buttler",
                "Moin Ali"
            };

            // _names[3] = _names[3].ToUpper();
        }

        // Property 
        public string FirstName
        {
            get
            {
                return _names[0];
            }
            set
            {
                _names[0] = value;
            }
        }

        public string GetName(int id)
        {
            return _names[id];
        }

        public void SetName(int id, string newname)
        {
            _names[id] = newname;
        }


        // Indexer
        public string this[int id]
        {
            get
            {
                return _names[id];
            }
            set
            {
                _names[id] = value;
            }
        }

        public void DisplayNames()
        {
            foreach (string name in _names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}