using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Test_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home_Page());

        }
        public static string converter(string number)
        {
            string decinum = "";
            int cuttingnumber = 0;
            int remainlength = 1;
            string Finalname = "";
            string fullno = number;
            int lengthfull = fullno.Length;
            string cutfullno = fullno;

            int cutter = lengthfull;
            string remaining = "";
            string cutremain = "";
            while (cuttingnumber < 6 && remainlength > 0)
            {
                if (cuttingnumber == 0)
                {
                    for (int ctr = 1; ctr <= lengthfull; ctr++)
                    {
                        if (cutfullno.StartsWith(".") == true)
                        {
                            decinum = cutfullno;
                            remainlength = decinum.Length;
                            remainlength = lengthfull - remainlength;
                            if (decinum.Length < 2)
                            {
                                decinum = ".00";
                            }
                            if (decinum.Length == 2)
                            {
                                decinum = decinum + "0";
                            }
                            decinum = decinum.Substring(1, 2);
                            remaining = fullno.Substring(0, remainlength);
                        }
                        else
                        {
                            cutter--;
                            cutfullno = cutfullno.Substring(1, cutter);
                        }
                    }
                    if (decinum == "")
                    {
                        decinum = "00";
                        remaining = fullno;
                        remainlength = lengthfull;
                    }
                }

                if (cuttingnumber == 1)
                {
                    int check = 0;
                    if (remainlength > 1 && check == 0)
                    {
                        remainlength = remainlength - 2;
                        cutremain = remaining.Substring(remainlength, 2);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                    if (remainlength == 1 && check == 0)
                    {
                        remainlength = remainlength - 1;
                        cutremain = remaining.Substring(remainlength, 1);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                }
                if (cuttingnumber == 2)
                {
                    remainlength = remainlength - 1;
                    cutremain = remaining.Substring(remainlength, 1);
                    remaining = remaining.Substring(0, remainlength);
                }
                if (cuttingnumber == 3)
                {
                    int check = 0;
                    if (remainlength > 1 && check == 0)
                    {
                        remainlength = remainlength - 2;
                        cutremain = remaining.Substring(remainlength, 2);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                    if (remainlength == 1 && check == 0)
                    {
                        remainlength = remainlength - 1;
                        cutremain = remaining.Substring(remainlength, 1);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                }
                if (cuttingnumber == 4)
                {
                    int check = 0;
                    if (remainlength > 1 && check == 0)
                    {
                        remainlength = remainlength - 2;
                        cutremain = remaining.Substring(remainlength, 2);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                    if (remainlength == 1 && check == 0)
                    {
                        remainlength = remainlength - 1;
                        cutremain = remaining.Substring(remainlength, 1);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                }
                if (cuttingnumber == 5)
                {
                    int check = 0;
                    if (remainlength > 1 && check == 0)
                    {
                        remainlength = remainlength - 2;
                        cutremain = remaining.Substring(remainlength, 2);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                    if (remainlength == 1 && check == 0)
                    {
                        remainlength = remainlength - 1;
                        cutremain = remaining.Substring(remainlength, 1);
                        remaining = remaining.Substring(0, remainlength);
                        check = 1;
                    }
                }

                int cutno = 0;
                
                if (Convert.ToInt32(decinum) > 0 && cuttingnumber == 0)
                {
                    cutno = Convert.ToInt32(decinum);
                    decinum = "0";
                }
                if (cuttingnumber > 0)
                {
                    cutno = Convert.ToInt32(cutremain);
                }
                string inWords = "";
                switch (cutno)
                {
                    case 0:
                        inWords = "";
                        break;
                    case 1:
                        inWords = "One";
                        break;
                    case 2:
                        inWords = "Two";
                        break;
                    case 3:
                        inWords = "Three";
                        break;
                    case 4:
                        inWords = "Four";
                        break;
                    case 5:
                        inWords = "Five";
                        break;
                    case 6:
                        inWords = "Six";
                        break;
                    case 7:
                        inWords = "Seven";
                        break;
                    case 8:
                        inWords = "Eight";
                        break;
                    case 9:
                        inWords = "Nine";
                        break;
                    case 10:
                        inWords = "Ten";
                        break;
                    case 11:
                        inWords = "Eleven";
                        break;
                    case 12:
                        inWords = "Twelve";
                        break;
                    case 13:
                        inWords = "Thirteen";
                        break;
                    case 14:
                        inWords = "Forteen";
                        break;
                    case 15:
                        inWords = "Fifteen";
                        break;
                    case 16:
                        inWords = "Sixteen";
                        break;
                    case 17:
                        inWords = "Seventeen";
                        break;
                    case 18:
                        inWords = "Eighteen";
                        break;
                    case 19:
                        inWords = "Ninteen";
                        break;
                    case 20:
                        inWords = "Twenty";
                        break;
                    case 21:
                        inWords = "Twentyone";
                        break;
                    case 22:
                        inWords = "Twentytwo";
                        break;
                    case 23:
                        inWords = "Twentythree";
                        break;
                    case 24:
                        inWords = "Twentyfour";
                        break;
                    case 25:
                        inWords = "Twentyfive";
                        break;
                    case 26:
                        inWords = "Twentysix";
                        break;
                    case 27:
                        inWords = "Twentyseven";
                        break;
                    case 28:
                        inWords = "Twentyeight";
                        break;
                    case 29:
                        inWords = "Twentynine";
                        break;
                    case 30:
                        inWords = "Thirty";
                        break;
                    case 31:
                        inWords = "Thirtyone";
                        break;
                    case 32:
                        inWords = "Thirtytwo";
                        break;
                    case 33:
                        inWords = "Thirtythree";
                        break;
                    case 34:
                        inWords = "Thirtyfour";
                        break;
                    case 35:
                        inWords = "Thirtyfive";
                        break;
                    case 36:
                        inWords = "Thirtysix";
                        break;
                    case 37:
                        inWords = "Thirtyseven";
                        break;
                    case 38:
                        inWords = "Thirtyeight";
                        break;
                    case 39:
                        inWords = "Thirtynine";
                        break;
                    case 40:
                        inWords = "Forty";
                        break;
                    case 41:
                        inWords = "Fortyone";
                        break;
                    case 42:
                        inWords = "Fortytwo";
                        break;
                    case 43:
                        inWords = "Fortythree";
                        break;
                    case 44:
                        inWords = "Fortyfour";
                        break;
                    case 45:
                        inWords = "Fortyfive";
                        break;
                    case 46:
                        inWords = "Fortysix";
                        break;
                    case 47:
                        inWords = "Fortyseven";
                        break;
                    case 48:
                        inWords = "Fortyeight";
                        break;
                    case 49:
                        inWords = "Fortynine";
                        break;
                    case 50:
                        inWords = "Fifty";
                        break;
                    case 51:
                        inWords = "Fiftyone";
                        break;
                    case 52:
                        inWords = "Fiftytwo";
                        break;
                    case 53:
                        inWords = "Fiftythree";
                        break;
                    case 54:
                        inWords = "Fiftyfour";
                        break;
                    case 55:
                        inWords = "Fiftyfive";
                        break;
                    case 56:
                        inWords = "Fiftysix";
                        break;
                    case 57:
                        inWords = "Fiftyseven";
                        break;
                    case 58:
                        inWords = "Fiftyeight";
                        break;
                    case 59:
                        inWords = "Fiftynine";
                        break;
                    case 60:
                        inWords = "Sixty";
                        break;
                    case 61:
                        inWords = "Sixtyone";
                        break;
                    case 62:
                        inWords = "Sixtytwo";
                        break;
                    case 63:
                        inWords = "Sixtythree";
                        break;
                    case 64:
                        inWords = "Sixtyfour";
                        break;
                    case 65:
                        inWords = "Sixtyfive";
                        break;
                    case 66:
                        inWords = "Sixtysix";
                        break;
                    case 67:
                        inWords = "Sixtyseven";
                        break;
                    case 68:
                        inWords = "Sixtyeight";
                        break;
                    case 69:
                        inWords = "Sixtynine";
                        break;
                    case 70:
                        inWords = "Seventy";
                        break;
                    case 71:
                        inWords = "Seventyone";
                        break;
                    case 72:
                        inWords = "Seventytwo";
                        break;
                    case 73:
                        inWords = "Seventythree";
                        break;
                    case 74:
                        inWords = "Seventyfour";
                        break;
                    case 75:
                        inWords = "Seventyfive";
                        break;
                    case 76:
                        inWords = "Seventysix";
                        break;
                    case 77:
                        inWords = "Seventyseven";
                        break;
                    case 78:
                        inWords = "Seventyeight";
                        break;
                    case 79:
                        inWords = "Seventynine";
                        break;
                    case 80:
                        inWords = "Eighty";
                        break;
                    case 81:
                        inWords = "Eightyone";
                        break;
                    case 82:
                        inWords = "Eightytwo";
                        break;
                    case 83:
                        inWords = "Eightythree";
                        break;
                    case 84:
                        inWords = "Eightyfour";
                        break;
                    case 85:
                        inWords = "Eightyfive";
                        break;
                    case 86:
                        inWords = "Eightysix";
                        break;
                    case 87:
                        inWords = "Eightyseven";
                        break;
                    case 88:
                        inWords = "Eightyeight";
                        break;
                    case 89:
                        inWords = "Eightynine";
                        break;
                    case 90:
                        inWords = "Ninety";
                        break;
                    case 91:
                        inWords = "Ninetyone";
                        break;
                    case 92:
                        inWords = "Ninetytwo";
                        break;
                    case 93:
                        inWords = "Ninetythree";
                        break;
                    case 94:
                        inWords = "Ninetyfour";
                        break;
                    case 95:
                        inWords = "Ninetyfive";
                        break;
                    case 96:
                        inWords = "Ninetysix";
                        break;
                    case 97:
                        inWords = "Ninetyseven";
                        break;
                    case 98:
                        inWords = "Ninetyeight";
                        break;
                    case 99:
                        inWords = "Ninetynine";
                        break;
                }

                if (cuttingnumber == 0)
                {
                    Finalname = " Only";
                    if (inWords != "")
                    {
                        Finalname = " Paise" + Finalname;
                        Finalname = inWords + Finalname;
                    }
                }
                if (cuttingnumber == 1)
                {
                    if (inWords != "")
                    {
                        Finalname = " Rupees " + Finalname;
                        Finalname = inWords + Finalname;
                    }
                }
                if (cuttingnumber == 2)
                {
                    if (inWords != "")
                    {
                        Finalname = " Hundered " + Finalname;
                        Finalname = inWords + Finalname;
                    }
                }
                if (cuttingnumber == 3)
                {
                    if (inWords != "")
                    {
                        Finalname = " Thousand " + Finalname;
                        Finalname = inWords + Finalname;
                    }
                }
                if (cuttingnumber == 4)
                {
                    if (inWords != "")
                    {
                        Finalname = " Lacs " + Finalname;
                        Finalname = inWords + Finalname;
                    }
                }
                if (cuttingnumber == 5)
                {
                    if (inWords != "")
                    {
                        Finalname = " Crore " + Finalname;
                        Finalname = inWords + Finalname;
                    }
                }
                cuttingnumber++;
            }
            return Finalname;

        }
    }
}




