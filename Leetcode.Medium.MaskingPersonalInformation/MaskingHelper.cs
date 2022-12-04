using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                return MaskEmailAdress(data);
            }
            else
            {
                return MaskPhoneNumber(data);
            }
        }

        public string MaskPhoneNumber(string data)
        {
            string regexPhoneNumber = Regex.Replace(data, "[^0-9]", string.Empty);
            int phoneNumberLength = regexPhoneNumber.Length;
            string last4Yards = regexPhoneNumber.Substring(phoneNumberLength - 4);

            switch (phoneNumberLength)
            {
                case 10: return "***-***-" + last4Yards;
                case 11: return "+*-***-***-" + last4Yards;
                case 12: return "+**-***-***-" + last4Yards;
            }

            return "+***-***-***-" + last4Yards;
        }

        public string MaskEmailAdress(string data)
        {
            int indexOfAt = data.IndexOf("@");
            string lowerEmail = data.ToLower();

            string result = $"{lowerEmail.Substring(0, 1)}*****{lowerEmail.Substring(indexOfAt - 1)}";
            return result;
        }
    }
}
