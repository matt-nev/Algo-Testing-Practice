using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public class DoubleChecker
    {
        // arr[10,2,5,3] true output 
        //arr[0][1][2]

        // [3,1,7,11] false output 
        public bool IsDouble(int[] arr)
        {
            int num = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == 2 * arr[j])
                    return true;
                }
            }
            return false;

        }
    }
}



/*check if there exists two indices i and j such that:
i != j
0 <= i, j < arr.length
arr[i] == 2 * arr[j]*/