using Leetcode.Medium.MaskingPersonalInformation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskingHelperTest
{
    public class MaskPIITest
    {
        [TestCase("LeetCode@LeetCode.com", "l*****e@leetcode.com")]
        [TestCase("AB@qq.com", "a*****b@qq.com")]
        [TestCase("1(234)567-890", "***-***-7890")]
        [TestCase("(02)1234-5678", "***-***-5678")]
        [TestCase("(02)12345678", "***-***-5678")]
        [TestCase("0912345678", "***-***-5678")]
        [TestCase("0912-345678", "***-***-5678")]
        [TestCase("0912-345-678", "***-***-5678")]
        [TestCase("+886-0912-343-672", "+***-***-***-3672")]
        [TestCase("(+886)0912-341-234", "+***-***-***-1234")]
        [TestCase("+886-0912-341-234", "+***-***-***-1234")]
        [TestCase("+1-0912-341-234", "+*-***-***-1234")]
        [TestCase("+81-0912-341-234", "+**-***-***-1234")]
        public void MostWordsFound_Foreach_ReturnExpected(string sentences, string expected)
        {
            var helper = new MaskingHelper();

            var actual = helper.MaskPII(sentences);

            Assert.AreEqual(expected, actual);
        }
    }
}
