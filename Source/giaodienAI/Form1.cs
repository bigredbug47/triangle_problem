using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace giaodienAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        public void rules1(double a, double ha,ref double S, int flag)
        {
            S = -1;
            S = 0.5 * a * ha;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có a = " + a + ". ha = " + ha + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * a * ha \r\n";
                        textBox2.Text += "Ta có S = " + S + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có b = " + a + ". hb = " + ha + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * b * hb.\r\n";
                        textBox2.Text += " Ta có S = " + S + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có c = " + a + ". hc = " + ha + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * c * hc.\r\n";
                        textBox2.Text += "Ta có S = " + S + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }

        //Tính ha
        public void rules2(double a, double S,ref double ha, int flag)
        {
            ha = -1;
            ha = S * 2 / a;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có a = " + a + ". S = " + S + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * a * ha.\r\n";
                        textBox2.Text += "Ta có ha = " + ha + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có b = " + a + ". S = " + S + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * b * hb.\r\n";
                        textBox2.Text += "Ta có hb = " + ha + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có c = " + a + ". S = " + S + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * c * hc.\r\n";
                        textBox2.Text += "Ta có hc = " + ha + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }

        //Tính a
        public void rules3(double ha, double S,ref double a, int flag)
        {
            a = -1;
            a = S * 2 / ha;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có ha = " + ha + ". S = " + S + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * a * ha.\r\n";
                        textBox2.Text += "Ta có a = " + a + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có hb = " + ha + ". S = " + S + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * b * hb.\r\n";
                        textBox2.Text += "Ta có b = " + a + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có hc = " + ha + ". S = " + S + "\r\n";
                        textBox2.Text += "Áp dụng công thức : S = 1/2 * c * hc.\r\n";
                        textBox2.Text += "Ta có c = " + a + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }
        // R1 S= 1/2 * a * ha


        //Tính ha
        public void rules4(double b, double C,ref double ha, int flag)
        {
            ha = -1;
            double sinC;
            sinC = Math.PI * C / 180.0;
            ha = b * Math.Sin(sinC);
            switch (flag)
            {
                case 1:
                    textBox2.Text += "Ta có b = " + b + ". Góc C = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : ha = b * sinC.\r\n";
                    textBox2.Text += "Ta có ha = " + ha + "\r\n";
                    break;
                case 2:
                    textBox2.Text += "Ta có c = " + b + ". Góc B = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : ha = c * sinB.\r\n";
                    textBox2.Text += "Ta có ha = " + ha + "\r\n";
                    break;
                case 3:
                    textBox2.Text += "Ta có c = " + b + ". Góc A = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hb = c * sinA.\r\n";
                    textBox2.Text += "Ta có hb = " + ha + "\r\n";
                    break;
                case 4:
                    textBox2.Text += "Ta có a = " + b + ". Góc C = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hb = a * sinC.\r\n";
                    textBox2.Text += "Ta có hb = " + ha + "\r\n";
                    break;
                case 5:
                    textBox2.Text += "Ta có a = " + b + ". Góc B = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hc = a * sinB.\r\n";
                    textBox2.Text += "Ta có hc = " + ha + "\r\n";
                    break;
                case 6:
                    textBox2.Text += "Ta có b = " + b + ". Góc A = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hc = b * sinA.\r\n";
                    textBox2.Text += "Ta có hc = " + ha + "\r\n";
                    break;
                default:
                    break;
            }
        }

        //Tính b    
        public void rules5(double ha, double C,ref double b, int flag)
        {
            b = -1;
            double sinC;
            sinC = Math.PI * C / 180.0;
            b = ha / Math.Sin(sinC);
            switch (flag)
            {
                case 1:
                    textBox2.Text += "Ta có ha = " + ha + ". Góc C = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : ha = b * sinC.\r\n";
                    textBox2.Text += "Ta có b = " + b + "\r\n";
                    break;
                case 2:
                    textBox2.Text += "Ta có ha = " + ha + ". Góc B = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : ha = c * sinB.\r\n";
                    textBox2.Text += "Ta có c = " + b + "\r\n";
                    break;
                case 3:
                    textBox2.Text += "Ta có hb = " + ha + ". Góc A = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hb = c * sinA.\r\n";
                    textBox2.Text += "Ta có c = " + b + "\r\n";
                    break;
                case 4:
                    textBox2.Text += "Ta có hb = " + ha + ". Góc C = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hb = a * sinC.\r\n";
                    textBox2.Text += "Ta có a = " + b + "\r\n";
                    break;
                case 5:
                    textBox2.Text += "Ta có hc = " + ha + ". Góc B = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hc = a * sinB.\r\n";
                    textBox2.Text += "Ta có a = " + b + "\r\n";
                    break;
                case 6:
                    textBox2.Text += "Ta có hc = " + ha + ". Góc A = " + C + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hc = b * sinA.\r\n";
                    textBox2.Text += "Ta có b = " + b + "\r\n";
                    break;
                default:
                    break;
            }
        }

        //Tính C
        public void rules6(double b, double ha, ref double Z, int flag)
        {
            Z = -1;
            double sinZ;
            sinZ = ha / b;
            Z = Math.Asin(sinZ);
            double temp;
            temp = Z * 180 / Math.PI;
            Z = temp;
            switch (flag)
            {
                case 1:
                    textBox2.Text += "Ta có b = " + b + ". Đường cao ha = " + ha + "\r\n";
                    textBox2.Text += "Áp dụng công thức : ha = b * sinC.\r\n";
                    textBox2.Text += "Ta có C = " + temp + "\r\n";
                    break;
                case 2:
                    textBox2.Text += "Ta có c = " + b + ". Đường cao ha = " + ha + "\r\n";
                    textBox2.Text += "Áp dụng công thức : ha = c * sinB.\r\n";
                    textBox2.Text += "Ta có B = " + temp + "\r\n";
                    break;
                case 3:
                    textBox2.Text += "Ta có c = " + b + ". Đường cao hb = " + ha + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hb = c * sinA.\r\n";
                    textBox2.Text += "Ta có A = " + temp + "\r\n";
                    break;
                case 4:
                    textBox2.Text += "Ta có a = " + b + ". Đường cao hb = " + ha + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hb = a * sinC.\r\n";
                    textBox2.Text += "Ta có C = " + temp + "\r\n";
                    break;
                case 5:
                    textBox2.Text += "Ta có a = " + b + ". Đường cao hc = " + ha + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hc = a * sinB.\r\n";
                    textBox2.Text += "Ta có B = " + temp + "\r\n";
                    break;
                case 6:
                    textBox2.Text += "Ta có b = " + b + ". Đường cao hc = " + ha + "\r\n";
                    textBox2.Text += "Áp dụng công thức : hc = b * sinA.\r\n";
                    textBox2.Text += "Ta có A = " + temp + "\r\n";
                    break;
                default:
                    break;
            }
        }
        // R2 ha = b*sinC

        //Tính S 
        public void rules7(double a, double b, double c, ref double S)
        {
            S = -1;
            S = Math.Sqrt((a + b + c) * (a + b - c) * (b + c - a) * (c + a - b)) / 4;
            textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + "\r\n";
            textBox2.Text += "Áp dụng công thức : S = Sqrt((a + b + c) * (a + b - c) * (b + c - a) * (c + a - b)) / 4 \r\n";
            textBox2.Text += "Ta có S = " + S + "\r\n";
        }
        //R3 S = sqrt((a+b+c)*(a+b-c)*(b+c-a)*(c+a-b))/4

        public void rules8(double a, double b, double c, ref double P)
        {
            P = -1;
            P = a + b + c;
            textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + "\r\n";
            textBox2.Text += "Áp dụng công thức : P = a + b + c.\r\n";
            textBox2.Text += "Ta có P = " + P + "\r\n";
        }
        public void rules9(double b, double c, double P, ref double a, int flag)
        {
            a = -1;
            a = P - b - c;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có b = " + b + ". c = " + c + ". P = " + P + "\r\n";
                        textBox2.Text += "Áp dụng công thức : P = a + b + c.\r\n";
                        textBox2.Text += "Ta có a = " + a + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có a = " + b + ". c = " + c + ". P = " + P + "\r\n";
                        textBox2.Text += "Áp dụng công thức : P = a + b + c.\r\n";
                        textBox2.Text += "Ta có b = " + a + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có a = " + b + ". b = " + c + ". P = " + P + "\r\n";
                        textBox2.Text += "Áp dụng công thức : P = a + b + c.\r\n";
                        textBox2.Text += "Ta có c = " + a + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }
        //R4 P = a+b+c

        //Tính a
        public void rules10(double b, double c, double A, ref double a, int flag)
        {
            a = -1;
            double temp = A;
            A = Math.PI * A / 180;
            a = Math.Sqrt(b * b + c * c - 2 * b * c * Math.Cos(A));
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có b = " + b + ". c = " + c + ". Góc A = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a*a = b*b + c*c - 2.b.c.cosA.\r\n";
                        textBox2.Text += "Ta có a = " + a + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có a = " + c + ". c = " + b + ". Góc B = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b*b = a*a + c*c - 2.a.c.cosB.\r\n";
                        textBox2.Text += "Ta có b = " + a + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có a = " + b + ". b = " + c + ". Góc C = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : c*c = a*a + b*b - 2.a.b.cosC.\r\n";
                        textBox2.Text += "Ta có c = " + a + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }

        //Tính góc A
        public void rules11(double a, double b, double c, ref double A, int flag)
        {
            A = -1;
            A = (b * b + c * c - a * a) / (2 * b * c);
            A = Math.Acos(A);
            double temp;
            temp = A * 180 / Math.PI;
            A = temp;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a*a = b*b + c*c - 2.b.c.cosA.\r\n";
                        textBox2.Text += "Ta có Góc A = " + temp + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b*b = a*a + c*c - 2.a.c.cosB.\r\n";
                        textBox2.Text += "Ta có Góc B = " + temp + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : c*c = a*a + b*b - 2.a.b.cosC.\r\n";
                        textBox2.Text += "Ta có Góc C = " + temp + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }
        //R5 a2 = b2 + c2 - 2.b.c.cosA

        //Tính b
        public void rules12(double a, double A, double B, ref double b, int flag)
        {
            b = -1;
            double temp1, temp2;
            temp1 = A;
            temp2 = B;
            A = Math.PI * A / 180;
            B = Math.PI * B / 180;
            b = (a * Math.Sin(B)) / Math.Sin(A);
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có a = " + a + ". Góc A = " + temp1 + ". Góc B = " + temp2 + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = b / sinB .\r\n";
                        textBox2.Text += "Ta có b = " + b + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có c = " + a + ". Góc C = " + temp1 + ". Góc B = " + temp2 + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b / sinB = c / sinC .\r\n";
                        textBox2.Text += "Ta có b = " + b + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có a = " + a + ". Góc A = " + temp1 + ". Góc C = " + temp2 + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = c / sinC .\r\n";
                        textBox2.Text += "Ta có c = " + b + "\r\n";
                    }
                    break;
                case 4:
                    {
                        textBox2.Text += "Ta có b = " + a + ". Góc B = " + temp1 + ". Góc C = " + temp2 + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b / sinB = c / sinC .\r\n";
                        textBox2.Text += "Ta có c = " + b + "\r\n";
                    }
                    break;
                case 5:
                    {
                        textBox2.Text += "Ta có b = " + a + ". Góc A = " + temp2 + ". Góc B = " + temp1 + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = b / sinB .\r\n";
                        textBox2.Text += "Ta có a = " + b + "\r\n";
                    }
                    break;
                case 6:
                    {
                        textBox2.Text += "Ta có c = " + a + ". Góc A = " + temp2 + ". Góc C = " + temp1 + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = c / sinC .\r\n";
                        textBox2.Text += "Ta có a = " + b + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }

        //Tính B
        public void rules13(double a, double A, double b, ref double B, int flag)
        {
            B = -1;
            double temp = A;
            A = Math.PI * A / 180;
            B = Math.Asin((b * Math.Sin(A)) / a);
            double temp2;
            temp2 = B * 180 / Math.PI;
            B = temp2;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có a = " + a + ". b = " + b + ". Góc A = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = b / sinB .\r\n";
                        textBox2.Text += "Ta có Góc B = " + temp2 + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có a = " + b + ". b = " + a + ". Góc B = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = b / sinB .\r\n";
                        textBox2.Text += "Ta có Góc A = " + temp2 + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có b = " + a + ". c = " + b + ". Góc B = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b / sinB = c / sinC .\r\n";
                        textBox2.Text += "Ta có Góc C = " + temp2 + "\r\n";
                    }
                    break;
                case 4:
                    {
                        textBox2.Text += "Ta có c = " + a + ". b = " + b + ". Góc C = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b / sinB = c / sinC .\r\n";
                        textBox2.Text += "Ta có Góc B = " + temp2 + "\r\n";
                    }
                    break;
                case 5:
                    {
                        textBox2.Text += "Ta có a = " + a + ". c = " + b + ". Góc A = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = c / sinC .\r\n";
                        textBox2.Text += "Ta có Góc C = " + temp2 + "\r\n";
                    }
                    break;
                case 6:
                    {
                        textBox2.Text += "Ta có c = " + b + ". a = " + a + ". Góc C = " + temp + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a / sinA = c / sinC .\r\n";
                        textBox2.Text += "Ta có Góc A = " + temp2 + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }
        //R6 a/sinA=b/sinB=c/sinC=2R

        //Rules 14 S=pr
        public void rules14(double p, double r, ref double S)
        {
            S = -1;
            S = p * r;
            textBox2.Text += "Ta có p = " + p + ". r = " + r + "\r\n";
            textBox2.Text += "Áp dụng công thức : S = p*r \r\n";
            textBox2.Text += "Ta có S = " + S + "\r\n";
        }
        //Rules 15 p=S/r; r=S/p;
        public void rules15(double S, double r, ref double p, int flag)
        {
            p = -1;
            p = S / r;
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có S = " + S + ". r = " + r + "\r\n";
                        textBox2.Text += "Áp dụng công thức : p = S / r \r\n";
                        textBox2.Text += "Ta có p = " + p + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có S = " + S + ". p = " + r + "\r\n";
                        textBox2.Text += "Áp dụng công thức : r = S / p \r\n";
                        textBox2.Text += "Ta có r = " + p + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }

        //Rules 16 tinh ma,mb,mc theo a,b,c.
        public void rules16(double b, double c, double a, ref double ma, int flag)
        {
            ma = -1;
            ma = Math.Sqrt((2 * (b * b + c * c) - a * a) / 4);
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : ma = (2 * (b * b + c * c) - a * a) / 4 .\r\n";
                        textBox2.Text += "Ta có ma = " + ma + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có a = " + b + ". b = " + a + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : mb = (2 * (a * a + c * c) - b * b) / 4 .\r\n";
                        textBox2.Text += "Ta có mb = " + ma + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có a = " + b + ". b = " + c + ". c = " + a + "\r\n";
                        textBox2.Text += "Áp dụng công thức : mc = (2 * (a * a + b * b) - c * c) / 4 .\r\n";
                        textBox2.Text += "Ta có mc = " + ma + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }

        // Rules 17 tinh a,b,c theo cong thuc trung tuyen
        public void rules17(double b, double c, double ma, ref double a, int flag)
        {
            a = -1;
            a = Math.Sqrt(2 * (b * b + c * c) - 4 * ma * ma);
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có b = " + b + ". c = " + c + ". ma = " + ma + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a = Math.Sqrt(2 * (b * b + c * c) - 4 * ma * ma) .\r\n";
                        textBox2.Text += "Ta có a = " + a + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có a = " + b + ". c = " + c + ". mb = " + ma + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b = Math.Sqrt(2 * (a * a + c * c) - 4 * mb * mb) .\r\n";
                        textBox2.Text += "Ta có b = " + a + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có a = " + b + ". b = " + c + ". mc = " + ma + "\r\n";
                        textBox2.Text += "Áp dụng công thức : c = Math.Sqrt(2 * (a * a + b * b) - 4 * mc * mc) .\r\n";
                        textBox2.Text += "Ta có c = " + a + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }
        // Rules 18 tinh a,b,c theo ma,mb,mc
        public void rules18(double ma, double a, double c, ref double b, int flag)
        {
            b = -1;
            b = Math.Sqrt((4 * ma * ma + a * a) / 2 - c * c);
            switch (flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có ma = " + ma + ". a = " + a + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b = Math.Sqrt((4 * ma * ma + a * a) / 2 - c * c) .\r\n";
                        textBox2.Text += "Ta có b = " + b + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có ma = " + ma + ". a = " + a + ". b = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : c = Math.Sqrt((4 * ma * ma + a * a) / 2 - b * b) .\r\n";
                        textBox2.Text += "Ta có c = " + b + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có mb = " + ma + ". b = " + a + ". c = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a = Math.Sqrt((4 * mb * mb + b * b) / 2 - c * c) .\r\n";
                        textBox2.Text += "Ta có a = " + b + "\r\n";
                    }
                    break;
                case 4:
                    {
                        textBox2.Text += "Ta có mb = " + ma + ". b = " + a + ". a = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : c = Math.Sqrt((4 * mb * mb + b * b) / 2 - a * a) .\r\n";
                        textBox2.Text += "Ta có c = " + b + "\r\n";
                    }
                    break;
                case 5:
                    {
                        textBox2.Text += "Ta có mc = " + ma + ". c = " + a + ". b = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : a = Math.Sqrt((4 * mc * mc + c * c) / 2 - b * b) .\r\n";
                        textBox2.Text += "Ta có a = " + b + "\r\n";
                    }
                    break;
                case 6:
                    {
                        textBox2.Text += "Ta có mc = " + ma + ". c = " + a + ". a = " + c + "\r\n";
                        textBox2.Text += "Áp dụng công thức : b = Math.Sqrt((4 * mc * mc + c * c) / 2 - a * a) .\r\n";
                        textBox2.Text += "Ta có b = " + b + "\r\n";
                    }
                    break;
                default:
                    break;
            }
        }
        //Ting R theo a,b,c ,S
        public void rules19(double a, double b, double c, double S, ref double R)
        {
            R = -1;
            R = (a * b * c) / (4 * S);
            textBox2.Text += "Ta có a = " + a + ". b = " + b + ". c = " + c + ". S = " + S + "\r\n";
            textBox2.Text += "Áp dụng công thức : R = R = (a * b * c) / (4 * S) .\r\n";
            textBox2.Text += "Ta có R = " + R + "\r\n";
        }

        public void rules20(double A, double B, ref double C, int flag)
        {
            C = -1;
            C = 180 - A - B;
            switch(flag)
            {
                case 1:
                    {
                        textBox2.Text += "Ta có góc A = " + A + ". Góc B = " + B + "\r\n";
                        textBox2.Text += "Áp dụng công thức : A + B + C = 180. \r\n";
                        textBox2.Text += "Ta có góc C = " + C + "\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox2.Text += "Ta có góc A = " + A + ". Góc C = " + B + "\r\n";
                        textBox2.Text += "Áp dụng công thức : A + B + C = 180. \r\n";
                        textBox2.Text += "Ta có góc B = " + C + "\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox2.Text += "Ta có góc B = " + A + ". Góc C = " + B + "\r\n";
                        textBox2.Text += "Áp dụng công thức : A + B + C = 180. \r\n";
                        textBox2.Text += "Ta có góc A = " + C + "\r\n";
                    }
                    break;
                default :
                    break;
            }
        }
        String A = ".";
        public bool checked_VT(string r, string fact)
        {
            int flag;
            int j, i = 0;
            int n = fact.Length;
            while (r[i] != A[0])
            {
                flag = 0;
                for (j = 0; j < n; j++)
                    if (r[i] == fact[j])
                    {
                        flag = 1;
                        break;
                    }
                if (flag == 0) return false;
                i++;
            }
            return true;
        }
        public string AddBD_VP(string r, ref string BD)
        {
            int j, flag, i = 0, n = r.Length, m = BD.Length;
            while (r[i] != A[0]) i++;
            i++;
            while (i < n)
            {
                flag = 0;
                for (j = 0; j < m; j++)
                    if (r[i] == BD[j])
                    {
                        flag = 1;
                        break;
                    }
                if (flag == 0) BD += r[i];
                i++;
            }
            return BD;
        }
        public bool thuoc_checked(String a, String b)
        {
            int n = a.Length;
            int m = b.Length;
            int i = 0, j;
            while (i < n)
            {
                j = 0;
                int flag = 0;
                while (j < m)
                {
                    if (a[i] == b[j])
                    {
                        i++;
                        flag = 1;
                        break;
                    }
                    j++;
                }
                if (flag == 0) return false;
            }
            return true;
        }
        public bool checked_r_daxet(int temp, List<int> a)
        {
            int i = 0, n = a.Count;
            while (i < n)
            {
                if (temp == a[i]) return true;
                i++;
            }
            return false;
        }
        public void suydienTien(String hypos, String Goal, List<String> R, ref List<int> usedRules)
        {
            String fact;
            int n, i, flag = 0;
            fact = hypos;
            n = R.Count;
            while (true)
            {
                for (i = 0; i < n; i++)
                {
                    if (thuoc_checked(Goal, fact))
                    {
                        flag = 1;
                        break;
                    }
                    if (!usedRules.Contains(i))
                        if (checked_VT(R[i], fact))
                        {
                            AddBD_VP(R[i], ref fact);
                            usedRules.Add(i);
                            i = 0;
                        }
                }
                if (flag == 1) break;
                if (i == n)
                {
                    MessageBox.Show("Giả thuyết chưa đủ để giải bài toán.\n Yêu cầu thêm giả thuyết", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            if (flag == 1)
            {
                textBox2.Text += "Hướng dẫn giải bài toán:" + "\r\n\r\n";
            }
        }
        
        
        public bool SuyDienLui(String gt, String kl, List<string> Rules, List<int> used, ref List<int> DA)
        {
            //nếu giả thuyết thuộc giả thuyết trả về true
            if (thuoc_checked(kl, gt)) return true;
            int i, j;
            // duyệt tập luật
            for (i = 0; i < used.Count; i++)
            {
                int bientam = i;
                i = used[bientam];
                int temp = Rules[i].Length;
                string temp1 = "";
                temp1 += Rules[i][temp - 1];
                //textBox2.Text += kl + "\r\n";
                // nếu tìm thấy luật i chứa kl trong vế phải
                if (kl == temp1)
                {
                    bool flag = true;
                    //duyệt vế trái của luật này
                    for (j = 0; j < (temp - 2); j++)
                    {
                        string temp2 = "";
                        temp2 += Rules[i][j];
                        // suy diễn lui cho tất cả phần tử vể trái
                        // nếu có một thằng nào đó không suy lui được thì break
                        if (!SuyDienLui(gt, temp2, Rules, used, ref DA))
                        {
                            flag = false;
                            break;
                        }//endif
                    }//endfor j
                    // nếu tất cả trong vế trái luật i đều suy lui được thì return true và in luật đã dùng ra
                    if (flag)
                    {
                        //nếu luật này chưa dùng lần nào
                        if (!checked_r_daxet(i, DA))
                        {
                            DA.Add(i); // thêm nó vào đáp án
                        }
                        return true;
                    }
                }//endif
                i = bientam;
            }//endfor i
            // xét hết luật mà không được
            return false;
        }


        double a, b, c, ha, hb, hc, A0, B0, C0, S, p, R, r, ma, mb, mc;
        String hypos, goal;

        //Tính S
        public void InputListRules(ref List<string> R1)
        {
            R1 = new List<string>()
            { 
                "AD.S",
                "BE.S",
                "CF.S",
                "AS.D",
                "BS.E",
                "CS.F",
                "DS.A",
                "ES.B",
                "FS.C",
                "BI.D",
                "CH.D",
                "CG.E",
                "AI.E",
                "AH.F",
                "BG.F",
                "DI.B",
                "DG.C",
                "EG.C",
                "EI.A",
                "FH.A",
                "FG.B",
                "BD.I",
                "CD.H",
                "CE.G",
                "AE.I",
                "AF.H",
                "BF.G",
                "ABC.S",
                "ABC.P",
                "PBC.A",
                "PAC.B",
                "PAB.C",
                "BCG.A",
                "CAH.B",
                "ABI.C",
                "ABC.G",
                "ABC.H",
                "ABC.I",
                "AGH.B",
                "CIH.B",
                "AGI.C",
                "BHI.C",
                "BHG.A",
                "CIG.A",
                "AGB.H",
                "BHA.G",
                "BHC.I",
                "CIB.H",
                "AGC.I",
                "CIA.G",
                "PM.S",
                "SM.P",
                "SP.M",
                "ABC.N",
                "ABC.O",
                "ABC.L",
                "BCN.A",
                "ACO.B",
                "ABL.C",
                "NAC.B",
                "NAB.C",
                "OBC.A",
                "OBA.C",
                "LCB.A",
                "LCA.B",
                "ABCS.R",
                "GH.I",
                "GI.H",
                "HI.G",
            };
        }
        public int CheckedIn()
        {
            int flag = 0;
            if (aa.Text != "") { hypos += "A"; a = double.Parse(aa.Text); flag = 1; }
            if (bb.Text != "") { hypos += "B"; b = double.Parse(bb.Text); flag = 1; }
            if (maa.Text != "") { hypos += "N"; ma = double.Parse(maa.Text); flag = 1; }
            if (cc.Text != "") { hypos += "C"; c = double.Parse(cc.Text); flag = 1; }
            if (AAA.Text != "") { hypos += "G"; A0 = double.Parse(AAA.Text); flag = 1; }
            if (BBB.Text != "") { hypos += "H"; B0 = double.Parse(BBB.Text); flag = 1; }
            if (CCC.Text != "") { hypos += "I"; C0 = double.Parse(CCC.Text); flag = 1; }
            if (mccc.Text != "") { hypos += "L"; mc = double.Parse(mccc.Text); flag = 1; }
            if (mbb.Text != "") { hypos += "O"; mb = double.Parse(mbb.Text); flag = 1; }
            if (haa.Text != "") { hypos += "D"; ha = double.Parse(haa.Text); flag = 1; }
            if (hbb.Text != "") { hypos += "E"; hb = double.Parse(hbb.Text); flag = 1; }
            if (hcc.Text != "") { hypos += "F"; hc = double.Parse(hcc.Text); flag = 1; }
            if (SS.Text != "") { hypos += "S"; S = double.Parse(SS.Text); flag = 1; }
            if (pp.Text != "") { hypos += "P"; p = double.Parse(pp.Text); flag = 1; }
            if (rr.Text != "") { hypos += "M"; r = double.Parse(rr.Text); flag = 1; }
            if (RRR.Text != "") { hypos += "R"; R = double.Parse(RRR.Text); flag = 1; }
            return flag;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int flagcheck = 0;
            flagcheck=CheckedIn();
            if (flagcheck == 0)
            {
                MessageBox.Show("Giả thuyết chưa đủ để giải bài toán.\n Yêu cầu thêm giả thuyết", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox2.Clear();
            textBox2.Text += "-- BÀI LÀM --\r\n";
            //textBox2.Text += hypos + "\r\n";
            List<string> Rules = new List<string>();
            //textBox2.Text += goal + "\r\n";
            InputListRules(ref Rules);
            List<int> temp = new List<int>();
            List<int> used=new List<int>();
            suydienTien(hypos, goal, Rules, ref used);
            if (!SuyDienLui(hypos, goal, Rules, used, ref temp))
            { 
                MessageBox.Show("Giả thuyết chưa đủ để giải bài toán.\n Yêu cầu thêm giả thuyết", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information); return; 
            }
            else if (temp.Count == 0) MessageBox.Show("Yếu tố cần tìm đã có trong giả thuyết ! Hãy chọn yếu tố khác !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                for (int t = 0; t < temp.Count; t++)
                {
                    textBox2.Text += "Bước thứ " + (t + 1) + " : \r\n";
                    switch (temp[t])
                    {
                        case 0:
                            rules1(a, ha, ref S, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 1:
                            rules1(b, hb, ref S, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 2:
                            rules1(c, hc, ref S, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 3:
                            rules2(a, S, ref ha, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 4:
                            rules2(b, S, ref hb, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 5:
                            rules2(c, S, ref hc, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 6:
                            rules3(ha, S, ref a, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 7:
                            rules3(ha, S, ref b, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 8:
                            rules3(hc, S, ref c, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 9:
                            rules4(b, C0, ref ha, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 10:
                            rules4(c, B0, ref ha, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 11:
                            rules4(c, A0, ref hb, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 12:
                            rules4(a, C0, ref hb, 4);
                            textBox2.Text += "\r\n";
                            break;
                        case 13:
                            rules4(a, B0, ref hc, 5);
                            textBox2.Text += "\r\n";
                            break;
                        case 14:
                            rules4(b, A0, ref hc, 6);
                            textBox2.Text += "\r\n";
                            break;
                        case 15:
                            rules5(ha, C0, ref b, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 16:
                            rules5(ha, B0, ref c, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 17:
                            rules5(hb, A0, ref c, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 18:
                            rules5(hb, C0, ref a, 4);
                            textBox2.Text += "\r\n";
                            break;
                        case 19:
                            rules5(hc, B0, ref a, 5);
                            textBox2.Text += "\r\n";
                            break;
                        case 20:
                            rules5(hc, A0, ref b, 6);
                            textBox2.Text += "\r\n";
                            break;
                        case 21:
                            rules6(b, ha, ref C0, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 22:
                            rules6(c, ha, ref B0, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 23:
                            rules6(c, hb, ref A0, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 24:
                            rules6(a, hb, ref C0, 4);
                            textBox2.Text += "\r\n";
                            break;
                        case 25:
                            rules6(a, hc, ref B0, 5);
                            textBox2.Text += "\r\n";
                            break;
                        case 26:
                            rules6(b, hc, ref A0, 6);
                            textBox2.Text += "\r\n";
                            break;
                        case 27:
                            rules7(a, b, c, ref S);
                            textBox2.Text += "\r\n";
                            break;
                        case 28:    
                            rules8(a, b, c, ref p);
                            textBox2.Text += "\r\n";
                            break;
                        case 29:
                            rules9(b, c, p, ref a, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 30:
                            rules9(a, c, p, ref b, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 31:
                            rules9(a, b, p, ref c, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 32:
                            rules10(b, c, A0, ref a, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 33:
                            rules10(c, a, B0, ref b, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 34:
                            rules10(a, b, C0, ref c, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 35:
                            rules11(a, b, c, ref A0, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 36:
                            rules11(a, b, c, ref B0, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 37:
                            rules11(a, b, c, ref C0, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 38:
                            rules12(a, A0, B0, ref b, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 39:
                            rules12(c, C0, B0, ref b, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 40:
                            rules12(a, A0, C0, ref c, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 41:
                            rules12(b, B0, C0, ref c, 4);
                            textBox2.Text += "\r\n";
                            break;
                        case 42:
                            rules12(b, B0, A0, ref a, 5);
                            textBox2.Text += "\r\n";
                            break;
                        case 43:
                            rules12(c, C0, A0, ref a, 6);
                            textBox2.Text += "\r\n";
                            break;
                        case 44:
                            rules13(a, A0, b, ref B0, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 45:
                            rules13(b, B0, a, ref A0, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 46:
                            rules13(b, B0, c, ref C0, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 47:
                            rules13(c, C0, b, ref B0, 4);
                            textBox2.Text += "\r\n";
                            break;
                        case 48:
                            rules13(a, A0, c, ref C0, 5);
                            textBox2.Text += "\r\n";
                            break;
                        case 49:
                            rules13(c, C0, a, ref A0, 6);
                            textBox2.Text += "\r\n";
                            break;
                        case 50:
                            rules14(p, r, ref S);
                            textBox2.Text += "\r\n";
                            break;  
                        case 51:
                            rules15(S, r, ref p, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 52:
                            rules15(S, p, ref r, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 53:
                            rules16(b, c, a, ref ma, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 54:
                            rules16(a, c, b, ref mb, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 55:
                            rules16(a, b, c, ref mc, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 56:
                            rules17(b, c, ma, ref a, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 57:
                            rules17(a, c, mb, ref b, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 58:
                            rules17(a, b, mc, ref c, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 59:
                            rules18(ma, a, c, ref b, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 60:
                            rules18(ma, a, b, ref c, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 61:
                            rules18(mb, b, c, ref a, 3);
                            textBox2.Text += "\r\n";
                            break;
                        case 62:
                            rules18(mb, b, a, ref c, 4);
                            textBox2.Text += "\r\n";
                            break;
                        case 63:
                            rules18(mc, c, b, ref a, 5);
                            textBox2.Text += "\r\n";
                            break;
                        case 64:
                            rules18(mc, c, a, ref b, 6);
                            textBox2.Text += "\r\n";
                            break;
                        case 65:
                            rules19(a, b, c, S, ref R);
                            textBox2.Text += "\r\n";
                            break;
                        case 66:
                            rules20(A0, B0, ref C0, 1);
                            textBox2.Text += "\r\n";
                            break;
                        case 67:
                            rules20(A0, C0, ref B0, 2);
                            textBox2.Text += "\r\n";
                            break;
                        case 68:
                            rules20(B0, C0, ref A0, 3);
                            textBox2.Text += "\r\n";
                            break;
                        default:
                            break;
                    }
                }
            }
            hypos = "";
            goal = "";
            temp.Clear();
            used.Clear();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            i = comboBox1.SelectedIndex;
            switch (i)
            {
                case 0:
                    textBox2.Text +=" Ta tìm a" + "\r\n";
                    goal += "A";
                    break;
                case 1:
                    textBox2.Text += " Ta tìm b" + "\r\n";
                    goal += "B";
                    break;
                case 2:
                    textBox2.Text += " Ta tìm c" + "\r\n";
                    goal += "C";
                    break;
                case 3:
                    textBox2.Text += " Ta tìm góc A" + "\r\n";
                    goal += "G";
                    break;
                case 4:
                    textBox2.Text += " Ta tìm góc B" + "\r\n";
                    goal += "H";
                    break;
                case 5:
                    textBox2.Text += " Ta tìm góc c" + "\r\n";
                    goal += "I";
                    break;
                case 6:
                    textBox2.Text += " Ta tìm đường trung tuyến ma" + "\r\n";
                    goal += "N";
                    break;
                case 7:
                    textBox2.Text += " Ta tìm đường trung tuyến mb" + "\r\n";
                    goal += "O";
                    break;
                case 8:
                    textBox2.Text += " Ta tìm đường trung tuyến mc" + "\r\n";
                    goal += "L";
                    break;
                case 9:
                    textBox2.Text += " Ta tìm đường cao ha" + "\r\n";
                    goal += "D";
                    break;
                case 10:
                    textBox2.Text += " Ta tìm đường cao hb" + "\r\n";
                    goal += "E";
                    break;
                case 11:
                    textBox2.Text += " Ta tìm đường cao hc" + "\r\n";
                    goal += "F";
                    break;
                case 12:
                    textBox2.Text += " Ta tìm Diện tích S" + "\r\n";
                    goal += "S";
                    break;
                case 13:
                    textBox2.Text += " Ta tìm Chu vi" + "\r\n";
                    goal += "P";
                    break;
                case 14:
                    textBox2.Text += " Ta tìm bán kính đường tròn nội tiếp r" + "\r\n";
                    goal += "M";
                    break;
                case 15:
                    textBox2.Text += " Ta tìm bán kính đường tròn ngoại tiếp R" + "\r\n";
                    goal += "R";
                    break;
                default:
                    goal += "";
                    break;
            }
        }

    }
}
