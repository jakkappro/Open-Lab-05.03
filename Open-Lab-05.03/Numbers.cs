using System;
using System.Collections.Generic;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            List<string> nums = new List<string>();
            string ret = "";
            string snum = num.ToString();
            int counter = 0;
            for (int i = snum.Length - 1; i >= 0; i--)
            {
               if(counter == 3)
                {
                    counter = 0;
                    nums.Add(",");
                }
                nums.Add(snum.ToCharArray()[i].ToString());
                counter++;
            }
            nums.Reverse();
            foreach (string s in nums)
                ret += s;
            return ret;
        }
    }
}
