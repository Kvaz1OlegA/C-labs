using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        //------------------------------------------------------------------------------Часть кода отвечающая за генерацию простых чисел-------------------------------------------------
        private bool Check(int a)//Функция проверки числа на простотоу
        {
            for(int i=2; i<a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        private static int LenghtOfBin(BigInteger a)//Функция определяющая кол-во бит в числе
        {
            int lenght = 0;
            while (a != 0)
            {
                a = BigInteger.Divide(a, 2);
                lenght++;
            }
            return lenght;
        }

        private void generatePrimes(List<int> primes, out BigInteger firstPrime, out BigInteger secondPrime)//Функция генерирующая 2 простых числа
        {
            firstPrime = 0;
            secondPrime = 0;

            List<BigInteger> mod3_1 = new List<BigInteger>();

            List<BigInteger> l = new List<BigInteger>();

            BigInteger three = new BigInteger(3), two = new BigInteger(2);

            for (int k = 0; k < primes.Count() - 1; k++)
            {

                BigInteger seed = new BigInteger(primes[k]);

                BigInteger s2 = BigInteger.Multiply(seed, 2);

                BigInteger r0;
                BigInteger.DivRem(seed, three, out r0);
                // Проверка на остаток = 1
                if (r0 == BigInteger.One) mod3_1.Add(seed);

                for (int i = k + 1; i < primes.Count(); i++)
                {
                    BigInteger p = new BigInteger(primes[i]); 
                    BigInteger r;
                    BigInteger.DivRem(p, three, out r);

                    if (r == r0) continue;
                    else addIfPrime(p, seed, s2, two, l);
                }
            }

            List<BigInteger> ps = l;

            do
            {
                l = new List<BigInteger>();
                int size = ps.Count();
                for (int k = 0; k < size; k++)
                {
                    BigInteger seed = ps[k];
                    BigInteger s2 = BigInteger.Multiply(seed, 2);

                    for (int i = 0; i < mod3_1.Count(); i++)
                        addIfPrime(mod3_1[i], seed, s2, two, l);
                    
                    int n = 100000; 
                    if (l.Count() > 0)
                        if (LenghtOfBin(l[0]) < 700) n = 10;
                        else if (LenghtOfBin(l[0]) < 800) n = 20;
                        else if (LenghtOfBin(l[0]) < 900) n = 40;
                    if (l.Count() > n) break; 
                }

                ps = l;

                Random rnd = new Random();
                if (rnd.Next(1, 12) == 1)
                {
                    while (true)
                    {
                        firstPrime = l[rnd.Next(0, l.Count() - 1)];
                        secondPrime = l[rnd.Next(0, l.Count() - 1)];
                        if (firstPrime.ToString().Length == secondPrime.ToString().Length)
                        {
                            if(firstPrime!=secondPrime)
                                return;
                        }
                        else
                            continue;
                    }
                }
            }
            while (l.Count() > 0);
        }
        
        private static void addIfPrime(BigInteger a, BigInteger b, BigInteger b2, BigInteger two, List<BigInteger> l)
        {

            BigInteger a2 = BigInteger.Multiply(a, 2), fp = BigInteger.Multiply(b, a2), n = BigInteger.Add(fp, 1);
            BigInteger r = new BigInteger();
            if (BigInteger.Compare(a2, b) < 0)
                r = BigInteger.ModPow(two, a2, n);
            else if (BigInteger.Compare(a, b2) < 0)
                r = BigInteger.ModPow(two, a, n);

            if (r != null && BigInteger.Compare(r, 1) == 0) return;
            
            r = new BigInteger();
            
            if (BigInteger.Compare(b2, a) < 0)
                r = BigInteger.ModPow(two, b2, n);
            else if (BigInteger.Compare(b, a2) < 0)
                r = BigInteger.ModPow(two, b, n);
            
            if (r != null && BigInteger.Compare(r, 1) == 0) return;
            
            r = BigInteger.ModPow(two, fp / 2, n);
            
            if (BigInteger.Compare(r, 1) != 0) return;
            l.Add(n);
        }
        //------------------------------------------------------------------------------Конец генерции чисел----------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------Шифрование и дешифрование----------------------------------------------------------------------------------------
        private List<string> RSA_Endoce(string s, BigInteger e, BigInteger n)//Функция выполняющая шифрование
        {
            List<string> result = new List<string>();

            BigInteger bi;
            int size = s.Length;
            for(int i=0; i<size; i++)
            {
                bi = s[i];                
                result.Add(BigInteger.ModPow(bi, e, n).ToString());
            }

            return result;
        }

        private string RSA_Dedoce(string[] input, BigInteger d, BigInteger n)//Функция выполняющая дешифрование
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = BigInteger.Parse(item);

                bi = BigInteger.ModPow(bi, d, n);
                try
                { 
                    result += (char)bi; 
                }
                catch(Exception)
                {
                    MessageBox.Show("Problem of decryption. Check your keys");
                    break;
                }
            }

            return result;
        }
        //------------------------------------------------------------------------------Конец шифрования и дешифрования----------------------------------------------------------------------------------------

        private BigInteger EuclidAlgorithm(BigInteger a, BigInteger b)//Алгоритм Евклида для нахождения НОД 
        {
            BigInteger reminder;
            BigInteger.DivRem(a, b, out reminder);
            while(reminder!=BigInteger.Zero)
            {
                a = b;
                b = reminder;
                BigInteger.DivRem(a, b, out reminder);
            }
            return b;
        }

        //------------------------------------------------------------------------------Высчитывание публичного и приватного ключей-----------------------------------------------------------------------
        private BigInteger Calculate_e(BigInteger m)//Вычисление открытого ключа
        {
            Random rnd = new Random();
            while(true)
            {
                BigInteger d1 = rnd.Next(1000000000);
                BigInteger d2 = rnd.Next(1000000000);

                BigInteger d =BigInteger.Multiply(d1, d2);
                if (d > m)
                    continue;
                else
                {
                    if (EuclidAlgorithm(m, d) == 1)
                        return d;
                }
            }
        }

        private BigInteger Calculate_d(BigInteger a, BigInteger b)//вычисление закрытого ключа
        {
            BigInteger tempA = a, tempB = b;
            BigInteger u1 = BigInteger.One, u2 = BigInteger.Zero, v1 = BigInteger.Zero, v2 = BigInteger.One;
            BigInteger temp = new BigInteger(), remainder = new BigInteger(), tempU = new BigInteger(), tempV = new BigInteger();
            while(b!=1)
            {
                BigInteger.DivRem(a, b, out remainder);
                temp = BigInteger.Divide(a, b);
                tempU = BigInteger.Subtract(u1, BigInteger.Multiply(u2, temp));
                tempV = BigInteger.Subtract(v1, BigInteger.Multiply(v2, temp));
                u1 = u2; u2 = tempU;
                v1 = v2; v2 = tempV;
                a = b;
                b = remainder;
            }
            if (v2 < 0)
                v2 = BigInteger.Add(v2, tempA);
            return v2;
        }
        //------------------------------------------------------------------------------Конец высчитывания публичного и приватного ключей-----------------------------------------------------------------------
        private void EncryptionButton_Click(object sender, EventArgs e)//Кнопка шифрования
        {
            textBox_encrypted.Clear();
            if ((textBox_n_interlocutor.Text.Length > 0) && (textBox_e_interlocutor.Text.Length > 0))
            {
                if (textBox_original.Text.Length > 0)
                {
                    string s = textBox_original.Text;

                    BigInteger n = BigInteger.Parse(textBox_n_interlocutor.Text);
                    BigInteger e_ = BigInteger.Parse(textBox_e_interlocutor.Text);

                    List<string> result = RSA_Endoce(s, e_, n);

                    foreach (var text in result)
                    {
                        textBox_encrypted.AppendText(text + "\n");
                    }
                }
                else
                    MessageBox.Show("The text field is empty");
            }
            else
                MessageBox.Show("The public key is missing!"); 
        }

        private void DecryptionButton_Click(object sender, EventArgs e)//Кнопка дешифрования
        {
            textBox_original.Clear();
            if ((textBox_d.Text.Length > 0) && (textBox_n.Text.Length > 0))
            {
                if (textBox_encrypted.Text.Length > 0)
                {
                    BigInteger d = BigInteger.Parse(textBox_d.Text);
                    BigInteger n = BigInteger.Parse(textBox_n.Text);

                    string[] input = textBox_encrypted.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    string result = RSA_Dedoce(input, d, n);

                    textBox_original.AppendText(result);
                }
                else
                    MessageBox.Show("The text field is empty");
            }
            else
                MessageBox.Show("The private key is missing!");
        }

        private void PrimesGen_Click(object sender, EventArgs e)//Кнопка генирации простых чисел
        {
            BigInteger p = new BigInteger();
            BigInteger q = new BigInteger();
            List<int> temp = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                if (Check(i))
                    temp.Add(i);
            }
            generatePrimes(temp, out p, out q);
            textBox_p.Text = p.ToString();
            textBox_q.Text = q.ToString();
        }

        private void KeysGen_Click(object sender, EventArgs e)//Кнопка вычисления ключей
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                BigInteger p = BigInteger.Parse(textBox_p.Text);
                BigInteger q = BigInteger.Parse(textBox_q.Text);

                BigInteger n = BigInteger.Multiply(p, q);
                BigInteger m = BigInteger.Multiply((p - 1), (q - 1));
                BigInteger e_ = Calculate_e(m);
                BigInteger d = Calculate_d(m, e_);

                textBox_d.Text = d.ToString();
                textBox_n.Text = n.ToString();
                textBox_e.Text = e_.ToString();
            }
            else 
                MessageBox.Show("Generate Prime numbers!");
        }
        //Кнопки очистки полей
        private void clear_original_textbox_Click(object sender, EventArgs e)
        {
            textBox_original.Clear();
        }

        private void clear_encrypted_textbox_Click(object sender, EventArgs e)
        {
            textBox_encrypted.Clear();
        }

        private void clear_primes_Click(object sender, EventArgs e)
        {
            textBox_p.Clear();
            textBox_q.Clear();
        }

        private void clear_keys_Click(object sender, EventArgs e)
        {
            textBox_n.Clear();
            textBox_e.Clear();
            textBox_d.Clear();
        }

        private void digital_signature_button_Click(object sender, EventArgs e)
        {
            textBox_signature_encrypted.Clear();
            if ((textBox_n.Text.Length > 0) && (textBox_d.Text.Length > 0))
            {
                if (textBox_signature_origin.Text.Length > 0)
                {
                    string s = textBox_signature_origin.Text;

                    BigInteger n = BigInteger.Parse(textBox_n.Text);
                    BigInteger d = BigInteger.Parse(textBox_d.Text);

                    List<string> result = RSA_Endoce(s, d, n);

                    foreach (var text in result)
                    {
                        textBox_signature_encrypted.AppendText(text + "\n");
                    }
                }
                else
                    MessageBox.Show("The text field is empty");
            }
            else
                MessageBox.Show("The private key is missing!");
        }

        private void confirming_signature_button_Click(object sender, EventArgs e)
        {
            if ((textBox_e_interlocutor.Text.Length > 0) && (textBox_n_interlocutor.Text.Length > 0))
            {
                if (textBox_signature_origin.Text.Length > 0 && textBox_signature_encrypted.Text.Length > 0)
                {
                    BigInteger e_ = BigInteger.Parse(textBox_e_interlocutor.Text);
                    BigInteger n = BigInteger.Parse(textBox_n_interlocutor.Text);

                    string[] input = textBox_signature_encrypted.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    string result = RSA_Dedoce(input, e_, n);

                    if(result == textBox_signature_origin.Text)
                        MessageBox.Show("The signature is verified");
                    else
                        MessageBox.Show("The signature is not verified");
                }
                else
                    MessageBox.Show("The text field is empty");
            }
            else
                MessageBox.Show("The public key is missing!");
        }
    }
}
