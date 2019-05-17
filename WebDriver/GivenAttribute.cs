using System;

namespace WebDriver_Specflow
{
    internal class GivenAttribute : Attribute
    {
        private string v;

        public GivenAttribute(string v)
        {
            this.v = v;
        }
    }
}