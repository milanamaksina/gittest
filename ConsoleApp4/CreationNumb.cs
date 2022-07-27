using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



public class CreationNumb
{

    int[] number = new int[10] { 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    public string CreatePhoneNumber(int[] number)
    {

        string phoneNumb = "";

        foreach (int n in number)
        {
            phoneNumb += n.ToString();
        }

        return string.Format("{0:(###) ###-####}", Convert.ToInt64(phoneNumb));

    }
=
}

