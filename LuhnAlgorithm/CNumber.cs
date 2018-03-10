using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class CNumber 
    {

        int[] Tab = null;

        public CNumber(string Enter){
            Tab = new int[Enter.Length];

            for (int i = 0; i < Enter.Length; i++){
                    Tab[i] = Convert.ToInt32(Enter.Substring(i, 1));
               
            }
        }

       
        public bool Verify(){
            int key = 0;

            for (int i = Tab.Length - 2; i != 1; i--)
            {
                if ((i % 2 == 0)){
                    if (Tab[i] * 2 >= 10)
                        key += (Tab[i] * 2 - 9);
                    else
                        key += Tab[i] * 2;
                }
                else{
                    key += Tab[i];
                }
                    
            }

            if (key % 10 == 0)
                return true;
            else
                return false;
                
        }

        
    }
}
