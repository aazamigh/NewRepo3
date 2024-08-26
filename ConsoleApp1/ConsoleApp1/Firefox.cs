using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Firefox
    {
        public List<string> Names()
        {
            var list=new List<string>();
            for (int i = 0; i < 5; i++)
            {
                list.Add("Firefox"+i.ToString());
            }
            return list;
        }
    }
}
