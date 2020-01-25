using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Backtracking
{
    class _93
    {
        public List<String> restoreIpAddresses(String s)
        {
            List<String> addresses = new List<string>();
            StringBuilder tempAddress = new StringBuilder();
            doRestore(0, tempAddress, addresses, s);
            return addresses;
        }

        private void doRestore(int k, StringBuilder tempAddress, List<String> addresses, String s)
        {
            if (k == 4 || s.Length == 0)
            {
                if (k == 4 && s.Length == 0)
                {
                    addresses.Add(tempAddress.ToString());
                }
                return;
            }
            for (int i = 0; i < s.Length && i <= 2; i++)
            {
                if (i != 0 && s[0] == '0')
                {
                    break;
                }
                String part = s.Substring(0, i + 1);
                if (Convert.ToInt32(part) <= 255)
                {
                    if (tempAddress.Length != 0)
                    {
                        part = "." + part;
                    }
                    tempAddress.Append(part);
                    doRestore(k + 1, tempAddress, addresses, s.Substring(i + 1));
                    tempAddress.Remove(tempAddress.Length - part.Length, part.Length);
                }
            }
        }
    }
}
