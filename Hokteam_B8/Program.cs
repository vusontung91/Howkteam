using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hokteam_B8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chuyển kiểu ngầm định
            //int k = 10;
            //long l = k; //chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int
            //float f = 10.9f;
            //double d = f; //chuyển kiểu ngầm định vì double có miền giá trị lớn hơn float
            #endregion

            #region Chuyển kiểu tường minh
            int i = 300; // có mã nhị phân là 100101100
            byte b = (byte)i; //do kiểu byte có giới hạn đến giá trị 225 thôi nên ko thể chứa số 300 đc mà kiểu byte có kích thước 1 byte = 8 bit. Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là đc. Mã nhị phân 300 là 100101100 cắt từ phải qua ta đc 00101100 ( đủ 8 bit) tương đương với sô 44. Cuối cùng b mang giá trị 44.

            Console.WriteLine("i=" + i);
            Console.WriteLine("b=" + b);

            double d= 2 / 3;// kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện chia 2 lấy phần nguyên với 3 được 0
            double k = (double)2 / 3; //ép kiểu 2 từ số nguyên sang số thực, như vậy phép chia sẽ ra số thực
            double t = 1.0 * 2 / 3;// thực hiện phép nhân với 1.0 để biến số 2 từ kiểu nguyên sang thực
            Console.WriteLine("d=" + d);
            Console.WriteLine("k=" + k);
            Console.WriteLine("t=" + t);
            Console.ReadKey();
            #endregion

            #region Parse

            #endregion
        }
    }
}
