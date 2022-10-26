using System;
using System.Text;
using System.Threading;

namespace Project
{
    class Program
    {
        static void bai1()
        {
            Console.Clear();
            Console.WriteLine("KÉO - BÚA  - BAO\n");
            int Computer = new Random().Next(1, 3);
            string ComputerChoiceName = Computer == 1 ? "Kéo" : Computer == 2 ? "Búa" : "Bao";
        reinput1_1:
            Console.WriteLine("Nhập lựa chọn của bạn:");
            Console.WriteLine("[1] Kéo\t[2] Búa\t[3] Bao\t");
            ConsoleKeyInfo key;
            int Player;
            key = Console.ReadKey(true);
            string num = key.KeyChar.ToString();
            if (int.TryParse(num, out Player) == false)
            {
                Console.Clear();
                Console.WriteLine("Lựa chọn của bạn không tồn tại. Chỉ chấp nhận lựa chọn là số nguyên từ 1-3. Vui lòng chọn lại.");
                goto reinput1_1;
            }
            string PlayerChoiceName = Player== 1 ? "Kéo" : Player == 2 ? "Búa" : Player == 3 ? "Bao" : "";
            if (Player > 0 & Player < 4)
                if (Player == Computer)
                    Console.WriteLine("Lựa chọn của bạn là {0}, lựa chọn của máy là {1}. Kết quả: Hòa", PlayerChoiceName, ComputerChoiceName);
                else
                    if (Player == 1 & Computer == 3 || Player == 2 & Computer == 1 || Player == 3 & Computer == 2)
                    Console.WriteLine("Lựa chọn của bạn là {0}, lựa chọn của máy là {1}. Kết quả: Bạn thắng", PlayerChoiceName, ComputerChoiceName);
                else Console.WriteLine("1Lựa chọn của bạn là {0}, lựa chọn của máy là {1}. Kết quả: Máy thắng", PlayerChoiceName, ComputerChoiceName);
            else
            {
                Console.Clear();
                Console.WriteLine("Lựa chọn của bạn không tồn tại. Chỉ chấp nhận lựa chọn là số nguyên từ 1-3. Vui lòng chọn lại.");
                goto reinput1_1;
            }
        }
        static void bai2()
        {
            Console.Clear();
        reinput2_1:
            Console.Write("Nhập vào số thứ tự: ");
            string num = Console.ReadLine();
            int n;
            if (int.TryParse(num, out n) == false)
            {
                Console.WriteLine("Chỉ chấp nhận số nguyên dương khác 0. Vui lòng nhập lại.");
                goto reinput2_1;
            }
            if (n <= 0)
            {
                Console.WriteLine("Chỉ chấp nhận số nguyên dương khác 0. Vui lòng nhập lại.");
                goto reinput2_1;
            }
            Console.WriteLine("Số thứ tự {0} => có {1} dấu căn.\n", n, n % 10 + 1);
            double P = Math.Pow(n, 1 / (double)n);
            for (int i = n; i > 1; i--)
                P = Math.Pow((i - 1) + P, 1 / (double)n);
            Console.WriteLine("Kết Quả: {0}", 1 / P);
        }
        static void bai3()
        {
            Console.Clear();
        reinput3_1:
            Console.Write("Nhập vào bậc của đa thức: ");
            string num = Console.ReadLine();
            int level;
            if (int.TryParse(num, out level) == false)
            {
                Console.WriteLine("Chỉ chấp nhận số nguyên dương khác 0. Vui lòng nhập lại.");
                goto reinput3_1;
            }
            if (level <= 0)
            {
                Console.WriteLine("Chỉ chấp nhận số nguyên dương khác 0. Vui lòng nhập lại.");
                goto reinput3_1;
            }
            double[] F = new double[level + 1];
            for (int i = level; i > 0; i--)
            {
            reinput3_2:
                Console.Write("Nhập vào hệ số của số hạng bậc {0}: ", i);
                num = Console.ReadLine();
                if (double.TryParse(num, out F[i]) == false)
                {
                    Console.WriteLine("Nhập sai. Chỉ chấp nhận số. Vui lòng nhập lại.");
                    goto reinput3_2;
                }
            }
        reinput3_3:
            Console.Write("Nhập vào hệ số tự do: ");
            num = Console.ReadLine();
            if (double.TryParse(num, out F[0]) == false)
            {
                Console.WriteLine("Nhập sai. Chỉ chấp nhận số. Vui lòng nhập lại.");
                goto reinput3_3;
            }
        reinput3_4:
            Console.Write("Nhập vào giá trị của X: ");
            num = Console.ReadLine();
            if (double.TryParse(num, out double X) == false)
            {
                Console.WriteLine("Nhập sai. Chỉ chấp nhận số. Vui lòng nhập lại.");
                goto reinput3_4;
            }
            double result = 0;
            for (int i = level; i >= 0; i--)
                result = result + F[i] * Math.Pow(X, i);
            Console.WriteLine("Kết quả: {0}", result);
        }
        static void bai4()
        {
            Console.Clear();
        reinput4_1:
            Console.Write("Nhập vào kích thước ma trận vuông nxn: ");
            int size;
            string num = Console.ReadLine();
            if (int.TryParse(num, out size) == false)
            {
                Console.WriteLine("Nhập sai. Chỉ chấp nhận số nguyên >=0. Vui lòng nhập lại.");
                goto reinput4_1;
            }
            if (size <= 0)
            {
                Console.WriteLine("Kích thước ma trận không thể <=0. Vui lòng nhập lại.");
                goto reinput4_1;
            }
            {
                double[][] matrix = new double[size][];
                for (int i = 0; i < size; i++)
                    matrix[i] = new double[size];
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                    reinput4_2:
                        Console.Write("Nhập vào phần tử [{0},{1}]: ", i, j);
                        num = Console.ReadLine();
                        if (double.TryParse(num, out matrix[i][j]) == false)
                        {
                            Console.WriteLine("Nhập sai. Chỉ chấp nhận số. Vui lòng nhập lại.");
                            goto reinput4_2;
                        }
                    }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        Console.Write("{0,5}", matrix[i][j]);
                    Console.WriteLine();
                }
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        if (matrix[i][j] != matrix[j][i])
                        {
                            Console.WriteLine("Ma trận không đối xứng");
                            return;
                        }
                    }
                Console.WriteLine("Ma trận đối xứng");
            }

        }
        static void bai5()
        {
            Console.Clear();
            Console.Write("Nhập vào xâu S: ");
            string S = Console.ReadLine();
            Console.Write("Nhập vào xâu con s1: ");
            string s1 = Console.ReadLine();
            Console.Write("Nhập vào xâu con s2: ");
            string s2 = Console.ReadLine();
            string output = S.Replace(s1, s2);
            Console.WriteLine("Xâu sau khi được xử lý: " + output);
        }
        static void import(object[][] a, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                string input;
                int num;
                float score;
                Console.WriteLine("\nNhập thông tin cho sinh viên thứ {0}", i + 1);
                for (int j = 0; j < 3; j++)
                {
                reinput6_2:
                    switch (j)
                    {
                        case 0:
                            Console.Write("Nhập họ tên sinh viên: ");
                            a[i][j] = Console.ReadLine();
                            if ((string)a[i][j] == "")
                            {
                                Console.WriteLine("Họ tên không được để trống");
                                goto reinput6_2;
                            }
                            break;
                        case 1:
                            Console.Write("Nhập năm sinh sinh viên: "); input = Console.ReadLine();
                            if (int.TryParse(input, out num) == false)
                            {
                                Console.WriteLine("Năm sinh phải là số nguyên. Vui lòng nhập lại.");
                                goto reinput6_2;
                            };
                            if (num <= 0)
                            {
                                Console.WriteLine("Năm sinh không thể <=0. Vui lòng nhập lại.");
                                goto reinput6_2;
                            }
                            a[i][j] = num;
                            break;
                        case 2:
                            Console.Write("Nhập nhập điểm trung bình sinh viên (0-10): ");
                            input = Console.ReadLine();
                            if (float.TryParse(input, out score) == false)
                            {
                                Console.WriteLine("Điểm phải là số thực. Vui lòng nhập lại.");
                                goto reinput6_2;
                            };
                            if (score < 0)
                            {
                                Console.WriteLine("Điểm không thể <0. Vui lòng nhập lại.");
                                goto reinput6_2;
                            }
                            a[i][j] = score;
                            break;
                    }
                }
                score = Convert.ToSingle(a[i][2]);
                if (score >= 8)
                    a[i][3] = "Giỏi";
                else if (score >= 6.5 & score < 8)
                    a[i][3] = "Khá";
                else if (score >= 5 & score < 6.5)
                    a[i][3] = "Trung Bình";
                else a[i][3] = "Yếu";
                order(a, amount);
            }
        }
        static void order(object[][] a, int amount)
        {
            object[] temp = new object[5];
            for (int i = 0; i < amount - i; i++)
                for (int j = amount - 1; j > i; j--)
                {
                    if (Convert.ToSingle(a[i][2]) < Convert.ToSingle(a[j][2]))
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            for (int i = 0; i < amount; i++)
                a[i][4] = i + 1;
        }
        static void export(object[] a)
        {
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("BẢNG ĐIỂM TỐT NGHIỆP\n");
            Console.WriteLine("Cấp cho sinh viên {0}, năm sinh {1}.\n", (string)a[0], a[1]);
            Console.WriteLine("Trong kì thi tốt nghiệp 2021, sinh viên trên đã đạt điểm trung bình là {0}, và được xếp loại {1}. Sinh viên có thứ hạng {2} trong lớp.\n", a[2], (string)a[3], a[4]);
            Console.WriteLine("Hiệu Trưởng Trường Đại học ABC.\n\nKí tên, Đóng dấu.\n");
            Console.WriteLine("----------------------------------------------------------\n");
        }
        static void exportlist(object[][] a, int amount)
        {
            for (int i = 0; i < amount; i++)
                export(a[i]);
        }
        static void bai6()
        {
            Console.Clear();
            int amount;
        reinput6_1:
            Console.Write("Nhập vào số lượng sinh viên: ");
            string num = Console.ReadLine();
            if (int.TryParse(num, out amount) == false)
            {
                Console.WriteLine("Số lượng sinh viên phải là số nguyên. Vui lòng nhập lại.");
                goto reinput6_1;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Số lượng sinh viên không thể <=0. Vui lòng nhập lại");
                goto reinput6_1;
            }
            object[][] listsv = new object[amount][];
            for (int i = 0; i < amount; i++)
                listsv[i] = new object[5];
            import(listsv, amount);
            exportlist(listsv, amount);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        start:
            Console.Clear();
            string s = "44444444444444444444444444444444444444444444";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("ĐỒ ÁN: CƠ SỞ LẬP TRÌNH");
            Console.SetCursorPosition((Console.WindowWidth - s.Length - 15) / 2, Console.CursorTop);
            Console.WriteLine("SINH VIÊN: NGUYỄN QUỐC VIỆT, LỚP: DS001");
            Console.WriteLine("BÀI 1:\n\nBÀI 2:\n\nBÀI 3:\n\nBÀI 4:\n\nBÀI 5:\n\nBÀI 6:\n");
        reinput_main:
            Console.Write("Nhập lựa chọn của bạn (1-6): ");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            int task;
            string num = key.KeyChar.ToString();
            if (int.TryParse(num, out task) == false)
            {
                Console.WriteLine("Lựa chọn của bạn không tồn tại. Vui lòng nhập lại.");
                goto reinput_main;
            }
            if (task > 0 & task < 7)
                switch (task)
                {
                    case 1: Console.WriteLine("Lựa chọn của bạn: Bài 1"); Thread.Sleep(1000); bai1(); break;
                    case 2: Console.WriteLine("Lựa chọn của bạn: Bài 2"); Thread.Sleep(1000); bai2(); break;
                    case 3: Console.WriteLine("Lựa chọn của bạn: Bài 3"); Thread.Sleep(1000); bai3(); break;
                    case 4: Console.WriteLine("Lựa chọn của bạn: Bài 4"); Thread.Sleep(1000); bai4(); break;
                    case 5: Console.WriteLine("Lựa chọn của bạn: Bài 5"); Thread.Sleep(1000); bai5(); break;
                    case 6: Console.WriteLine("Lựa chọn của bạn: Bài 6"); Thread.Sleep(1000); bai6(); break;

                }
            else
            {
                Console.WriteLine("Lựa chọn của bạn không tồn tại. Vui lòng nhập lại.");
                goto reinput_main;
            }

            Console.Write("\nNhấn [1] để quay lại menu, nhấn phím bất kì để thoát: ");
            key = Console.ReadKey(true);
            string input = key.KeyChar.ToString();
            if (input == "1")
                goto start;
            else
                goto end;
            end:;
        }
    }
}


