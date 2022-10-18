using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    internal class Logic
    {
        public static int CalculateBranchHeight(Branch root)
        {
            

            if (root.branches.Count == 0)
            {
                return 1;
            }

            int max = 1;

            foreach (var branch in root.branches)
            {
                var currentBranchHeight = CalculateBranchHeight(branch);
                if (currentBranchHeight > max)
                {
                    max = currentBranchHeight;
                }
            }
            return max + 1;
        }
    }
}
