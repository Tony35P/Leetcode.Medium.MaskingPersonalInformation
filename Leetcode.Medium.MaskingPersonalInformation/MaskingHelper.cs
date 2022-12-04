using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium.MaskingPersonalInformation
{
    public class MaskingHelper
    {
        public string MaskPII(string data)
        {
            int indexOfAt = data.IndexOf("@");
            if (indexOfAt > 0)
            {
                string lowerEmail = data.ToLower();

                string result = $"{lowerEmail.Substring(0, 1)}*****{lowerEmail.Substring(indexOfAt - 1)}";
                return result;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
