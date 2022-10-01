namespace DemoMVC.Models
{
    public class GiaiPhuongTrinhBac2
    {
        public string GiaiPhuongTrinhBac1(string heSoA, string heSoB)
        {
            double a, b, x;
            string ThongBao;
            a = Convert.ToDouble(heSoA);
            b = Convert.ToDouble(heSoB);

            if (a == 0)
            {
                if (b == 0)
                {
                    ThongBao = "Phương trình vô số nghiệm!";
                }
                else
                {
                    ThongBao = "Phương trình vô nghiệm!";
                }

            }
            else
            {
                x = -b / a;
                ThongBao = "Phương trình có nghiệm x = " + x;
            }
            return ThongBao;


        }
        public string GiaiPhuongTrinhBacHai(string heSoA, string heSoB, string heSoC)
        {
            double a, b, c;
            double x1, x2, delta;
            string ThongBao;
            a = Convert.ToDouble(heSoA);
            b = Convert.ToDouble(heSoB);
            c = Convert.ToDouble(heSoC);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        ThongBao = "Phương trình vô số nghiệm!";
                    }
                    else
                    {
                        ThongBao = "Phương trình vô nghiệm!";
                    }

                }
                else
                {
                    x1 = (double)-c / b;
                    ThongBao = " Phương trình có nghiệm duy nhất x =" + Math.Round(x1, 2);
                }
            }
            else
            {
                delta = (b * b) - (4 * a * c);
                if (delta < 0)
                {
                    ThongBao = "Phương trình vô nghiệm!";
                }

                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    ThongBao = "Phương trình có nghiệm kép x1 = x2 = " + x1;
                }

                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ThongBao = "Phương trình có 2 nghiệm phân biệt là X1 = " + x1 + " và " + "X2 = " + x2;
                }
            }
            return ThongBao;

        }
    }
}
