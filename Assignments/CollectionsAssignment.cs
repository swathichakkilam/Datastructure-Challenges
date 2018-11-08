using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class CollectionsAssignment
    {
        List<string> flavors = new List<string>();

        public void UpdateFlowers() {
            flavors.Add("Mango");
            flavors.Add("strawberry");
            flavors.Add("butterscotch");
            flavors.Add("SweetCream");

            for (var idx = 0; idx < flavors.Count; idx++)
            {
                Console.WriteLine("-" + flavors[idx]);
            }
        }

    }
}
