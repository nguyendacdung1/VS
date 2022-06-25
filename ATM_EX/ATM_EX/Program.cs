using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_ATM_VietNam
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 15000000, deposit, withdraw;
            int choice, pin = 0;
            bool continueAsk = true;
            Console.Write("Nhập số pin của bạn: ");
            pin = int.Parse(Console.ReadLine());
            if (pin != 1234)
            {
                Console.WriteLine("Sorry, dont correct PIN number. Please try again!");
                Console.Read();
                return;
            }
            while (continueAsk)
            {
                Console.WriteLine("********Welcome to ATM Service**************");
                Console.WriteLine("1. Kiểm tra số dư");
                Console.WriteLine("2. Rút tiền mặt");
                Console.WriteLine("3. Chuyển tiền");
                Console.WriteLine("4. Thoát");
                Console.WriteLine("*********************************************");
                Console.Write("Nhập lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("  SỐ DƯ CỦA BẠN TRONG NH : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine(" NHẬP SỐ TIỀN CẦN RÚT: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 10000 != 0)
                        {
                            Console.WriteLine(" VUI LÒNG NHẬP SỐ TIỀN THEO BỘI SỐ CỦA 100");
                        }
                        else if (withdraw > (amount - 50000)) 
                        {
                            Console.WriteLine(" SỐ DƯ KHÔNG ĐỦ");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine(" VUI LÒNG NHẬN TIỀN MẶT");
                            Console.WriteLine(" SỐ DƯ HIỆN TẠI CỦA BẠN LÀ {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine(" NHẬP SỐ TIỀN CẦN CHUYỂN");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount - deposit;
                        Console.WriteLine(" CHUYỂN TIỀN THÀNH CÔNG");
                        Console.WriteLine("SỐ DƯ CỦA BẠN LÀ {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine(" CẢM ƠN ĐÃ SỬ DỤNG ATM");
                        continueAsk = false;
                        break;
                }
            }
            Console.WriteLine(" CẢM ƠN BẠN ĐÃ SỬ DỤNG DỊCH VỤ ATM");
            Console.Read();
        }

       
        
        
    }
}

