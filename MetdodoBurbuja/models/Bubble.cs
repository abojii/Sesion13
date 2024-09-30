using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetdodoBurbuja.models
{
    internal class Bubble
    {
        public void BubbleSort(int[] array)
        {
            try
            {
                for(int i=0; i<array.Length; i++)
                {
                    for(int j= i+1; j<array.Length; j++)
                    {
                        if(array[i] == array[j])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
