using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web
{
    public class CCommonFunction
    {
        public static string Create_Random_Session_ID()
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int LENGTH = 30;

            StringBuilder v_strRes = new StringBuilder();

            for (int i = 0; i < LENGTH; i++)
            {
                // Lấy kí tự ngẫu nhiên từ mảng chars
                string str = chars[rand.Next(chars.Length)].ToString();
                v_strRes.Append(str);
            }

            return v_strRes.ToString();
        }
    }
}
