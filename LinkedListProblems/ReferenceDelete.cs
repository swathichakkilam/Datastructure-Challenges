using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class ReferenceDelete
    {
        public static void DeleteReference(Node nodeToDel)
        {
            var temp = nodeToDel.nxtlink;

            if (temp == null)
            {
                nodeToDel = null;
            }

            nodeToDel.value = temp.value;
            nodeToDel.nxtlink = temp.nxtlink;
            temp= null;
        }
    }
}
