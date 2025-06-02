using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Validators
{
    public static class PreventEmptyField
    {
        public static bool ValidateNotEmpty(string input, out string errorMsg)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                errorMsg = "This field is required";
                return false;
            }

            errorMsg = "";
            return true;
        }
    }
}
