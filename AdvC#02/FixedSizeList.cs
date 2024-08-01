using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_02
{
    internal class FixedSizeList<T>
    {
        public T[] List { get; set; }
        public int fixedcapacity { get; set; }
        public int Count { get; set; }
        public FixedSizeList(int Fixedcapacity )
        {
            fixedcapacity=Fixedcapacity;
            Count = 0;
            List = new T[Fixedcapacity];

        }
        public  void  Add(T item) 
        {
            
            if (List is not null && Count<fixedcapacity)
            {
                List.Append(item);
                Count++;
                
            }
           
        }
        public T Get(int index) 
        {

            return List[index];
        }
      
    }
}
