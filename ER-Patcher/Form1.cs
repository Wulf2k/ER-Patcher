using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ER_Patcher
{
    public partial class Form1 : Form
    {

        public byte[] ba;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ba = File.ReadAllBytes(txtPath.Text);
            File.WriteAllBytes(txtPath.Text + ".old", ba);

            rep("CheatDetect Neuter", "e8 ?? ?? ?? ?? 33 ff 48 39 3d ?? ?? ?? ?? 75 42", "90 90 90 90 90 33 ff 48 39 3d ?? ?? ?? ?? 75 42");
            rep("Logos begone", "00 e8 ?? ?? ?? ?? 80 bf b8 00 00 00 00 74 53 48", "00 e8 ?? ?? ?? ?? 80 bf b8 00 00 00 00 90 90 48");
            rep("Push rax(1)", "48 8d 64 24 f8 48 89 04 24", "50 90 90 90 90 90 90 90 90");
            rep("Push rax(2)", "48 89 44 24 f8 48 8d 64 24 f8", "50 90 90 90 90 90 90 90 90 90");
            rep("Push rbx(1)", "48 8d 64 24 f8 48 89 1c 24", "53 90 90 90 90 90 90 90 90");
            rep("Push rbx(2)", "48 89 5c 24 f8 48 8d 64 24 f8", "53 90 90 90 90 90 90 90 90 90");
            rep("Push rcx(1)", "48 8d 64 24 f8 48 89 0c 24", "51 90 90 90 90 90 90 90 90");
            rep("Push rcx(2)", "48 89 4c 24 f8 48 8d 64 24 f8", "51 90 90 90 90 90 90 90 90 90");
            rep("Push rdx(1)", "48 8d 64 24 f8 48 89 14 24", "52 90 90 90 90 90 90 90 90");
            rep("Push rdx(2)", "48 89 54 24 f8 48 8d 64 24 f8", "52 90 90 90 90 90 90 90 90 90");
            rep("Push rdi(1)", "48 8d 64 24 f8 48 89 3c 24", "57 90 90 90 90 90 90 90 90");
            rep("Push rdi(2)", "48 89 7c 24 f8 48 8d 64 24 f8", "57 90 90 90 90 90 90 90 90 90");
            rep("Push rsi(1)", "48 8d 64 24 f8 48 89 34 24", "56 90 90 90 90 90 90 90 90");
            rep("Push rsi(2)", "48 89 74 24 f8 48 8d 64 24 f8", "56 90 90 90 90 90 90 90 90 90");
            rep("Push rbp(1)", "48 8d 64 24 f8 48 89 2c 24", "55 90 90 90 90 90 90 90 90");
            rep("Push rbp(2)", "48 89 6c 24 f8 48 8d 64 24 f8", "55 90 90 90 90 90 90 90 90 90");
            rep("Push r8(1)", "48 8d 64 24 f8 4c 89 04 24", "41 50 90 90 90 90 90 90 90");
            rep("Push r8(2)", "4c 89 44 24 f8 48 8d 64 24 f8", "41 50 90 90 90 90 90 90 90 90");
            rep("Push r9(1)", "48 8d 64 24 f8 4c 89 0c 24", "41 51 90 90 90 90 90 90 90");
            rep("Push r9(2)", "4c 89 4c 24 f8 48 8d 64 24 f8", "41 51 90 90 90 90 90 90 90 90");
            rep("Push r10(1)", "48 8d 64 24 f8 4c 89 14 24", "41 52 90 90 90 90 90 90 90");
            rep("Push r10(2)", "4c 89 54 24 f8 48 8d 64 24 f8", "41 52 90 90 90 90 90 90 90 90 ");
            rep("Push r11(1)", "48 8d 64 24 f8 4c 89 1c 24", "41 53 90 90 90 90 90 90 90");
            rep("Push r11(2)", "4c 89 5c 24 f8 48 8d 64 24 f8", "41 53 90 90 90 90 90 90 90 90");
            rep("Push r12(1)", "48 8d 64 24 f8 4c 89 24 24", "41 54 90 90 90 90 90 90 90");
            rep("Push r12(2)", "4c 89 64 24 f8 48 8d 64 24 f8", "41 54 90 90 90 90 90 90 90 90");
            rep("Push r13(1)", "48 8d 64 24 f8 4c 89 2c 24", "41 55 90 90 90 90 90 90 90");
            rep("Push r13(2)", "4c 89 6c 24 f8 48 8d 64 24 f8", "41 55 90 90 90 90 90 90 90 90");
            rep("Push r14(1)", "48 8d 64 24 f8 4c 89 34 24", "41 56 90 90 90 90 90 90 90");
            rep("Push r14(2)", "4c 89 74 24 f8 48 8d 64 24 f8", "41 56 90 90 90 90 90 90 90 90");
            rep("Push r15(1)", "48 8d 64 24 f8 4c 89 3c 24", "41 57 90 90 90 90 90 90 90");
            rep("Push r15(2)", "4c 89 7c 24 f8 48 8d 64 24 f8", "41 57 90 90 90 90 90 90 90 90");
            rep("Pop rax(1)", "48 8d 64 24 08 48 8b 44 24 f8", "58 90 90 90 90 90 90 90 90 90");
            rep("Pop rax(2)", "48 8b 04 24 48 8d 64 24 08", "58 90 90 90 90 90 90 90 90");
            rep("Pop rbx(1)", "48 8d 64 24 08 48 8b 5c 24 f8", "5b 90 90 90 90 90 90 90 90 90");
            rep("Pop rbx(2)", "48 8b 1c 24 48 8d 64 24 08", "5b 90 90 90 90 90 90 90 90");
            rep("Pop rcx(1)", "48 8d 64 24 08 48 8b 4c 24 f8", "59 90 90 90 90 90 90 90 90 90 ");
            rep("Pop rcx(2)", "48 8b 0c 24 48 8d 64 24 08", "59 90 90 90 90 90 90 90 90");
            rep("Pop rdx(1)", "48 8d 64 24 08 48 8b 54 24 f8", "5a 90 90 90 90 90 90 90 90 90");
            rep("Pop rdx(2)", "48 8b 14 24 48 8d 64 24 08", "5a 90 90 90 90 90 90 90 90");
            rep("Pop rdi(1)", "48 8d 64 24 08 48 8b 7c 24 f8", "5f 90 90 90 90 90 90 90 90 90 ");
            rep("Pop rdi(2)", "48 8b 3c 24 48 8d 64 24 08", "5f 90 90 90 90 90 90 90 90");
            rep("Pop rsi(1)", "48 8d 64 24 08 48 8b 74 24 f8", "5e 90 90 90 90 90 90 90 90 90");
            rep("Pop rsi(2)", "48 8b 34 24 48 8d 64 24 08", "5e 90 90 90 90 90 90 90 90");
            rep("Pop rbp(1)", "48 8d 64 24 08 48 8b 6c 24 f8", "5d 90 90 90 90 90 90 90 90 90");
            rep("Pop rbp(2)", "48 8b 2c 24 48 8d 64 24 08", "5d 90 90 90 90 90 90 90 90");
            rep("Pop r8(1)", "48 8d 64 24 08 4c 8b 44 24 f8", "41 58 90 90 90 90 90 90 90 90");
            rep("Pop r8(2)", "4c 8b 04 24 48 8d 64 24 08", "41 58 90 90 90 90 90 90 90");
            rep("Pop r9(1)", "48 8d 64 24 08 4c 8b 4c 24 f8", "41 59 90 90 90 90 90 90 90 90");
            rep("Pop r9(2)", "4c 8b 0c 24 48 8d 64 24 08", "41 59 90 90 90 90 90 90 90");
            rep("Pop r10(1)", "48 8d 64 24 08 4c 8b 54 24 f8", "41 5a 90 90 90 90 90 90 90 90");
            rep("Pop r10(2)", "4c 8b 14 24 48 8d 64 24 08", "41 5a 90 90 90 90 90 90 90");
            rep("Pop r11(1)", "48 8d 64 24 08 4c 8b 5c 24 f8", "41 5b 90 90 90 90 90 90 90 90");
            rep("Pop r11(2)", "4c 8b 1c 24 48 8d 64 24 08", "41 5b 90 90 90 90 90 90 90");
            rep("Pop r12(1)", "48 8d 64 24 08 4c 8b 64 24 f8", "41 5c 90 90 90 90 90 90 90 90");
            rep("Pop r12(2)", "4c 8b 24 24 48 8d 64 24 08", "41 5c 90 90 90 90 90 90 90");
            rep("Pop r13(1)", "48 8d 64 24 08 4c 8b 6c 24 f8", "41 5d 90 90 90 90 90 90 90 90");
            rep("Pop r13(2)", "4c 8b 2c 24 48 8d 64 24 08", "41 5d 90 90 90 90 90 90 90");
            rep("Pop r14(1)", "48 8d 64 24 08 4c 8b 74 24 f8", "41 5e 90 90 90 90 90 90 90 90");
            rep("Pop r14(2)", "4c 8b 34 24 48 8d 64 24 08", "41 5e 90 90 90 90 90 90 90");
            rep("Pop r15(1)", "48 8d 64 24 08 4c 8b 7c 24 f8", "41 5f 90 90 90 90 90 90 90 90");
            rep("Pop r15(2)", "4c 8b 3c 24 48 8d 64 24 08", "41 5f 90 90 90 90 90 90 90");
            rep("Stack Waste(1)", "48 8d 64 24 f8 48 8d 64 24 08", "90 90 90 90 90 90 90 90 90 90");
            rep("Stack Waste(2)", "48 8d 64 24 08 48 8d 64 24 f8", "90 90 90 90 90 90 90 90 90 90");
            rep("Ret", "48 8d 64 24 08 ff 64 24 f8", "c3 90 90 90 90 90 90 90 90");




            File.WriteAllBytes(txtPath.Text, ba);
        }

        public void rep(string name, string fb, string rb)
        {
            txtOutput.Text += $@"{name}: {ReplaceBytes(fb, rb)}" + Environment.NewLine;
        }

        public byte[] hs2b(string hex)
        {
            hex = hex.Replace(" ", "");
            hex = hex.Replace("-", "");
            hex = hex.Replace(":", "");

            byte[] b = new byte[hex.Length >> 1];
            for (int i = 0; i <= b.Length - 1; ++i)
            {
                b[i] = (byte)((hex[i * 2] - (hex[i * 2] < 58 ? 48 : (hex[i * 2] < 97 ? 55 : 87))) * 16 + (hex[i * 2 + 1] - (hex[i * 2 + 1] < 58 ? 48 : (hex[i * 2 + 1] < 97 ? 55 : 87))));
            }
            return b;
        }

        public byte[] hs2w(string hex)
        {
            hex = hex.Replace(" ", "");
            hex = hex.Replace("-", "");
            hex = hex.Replace(":", "");

            byte[] wild = new byte[hex.Length >> 1];
            for (int i = 0; i <= wild.Length - 1; ++i)
            {
                if (hex[i * 2].Equals('?'))
                {
                    wild[i] = 1;
                }
            }
            return wild;
        }

        public int ReplaceBytes(string find, string rep)
        {
            int count = 0;
            byte[] rb = hs2b(rep);
            byte[] rwb = hs2w(rep);

            byte[] fb = hs2b(find);
            byte[] fwb = hs2w(find);

            int index = 0;
            while (index != -1)
            {
                index = FindBytes(fb, fwb, index);
                if (index != -1)
                {
                    for (int i = 0; i <= rb.Length - 1; i++)
                    {
                        if (rwb[i] != 1)
                        {
                            ba[index + i] = rb[i];
                        }
                    }
                    count++;
                    index++;
                }
                
            }
            return count;
        }

        public int FindBytes(byte[] find, byte[] wild, int index = 0)
        {
            if (ba == null || find == null || ba.Length == 0 || find.Length == 0 || find.Length > ba.Length) return -1;
            for (int i = index; i < ba.Length - find.Length + 1; i++)
            {
                if (ba[i] == find[0])
                {
                    for (int m = 1; m < find.Length; m++)
                    {
                        if ((ba[i + m] != find[m]) && (wild[m] != 1)) break;
                        if (m == find.Length - 1) return i;
                    }
                }
            }
            return -1;
        }
    }
}
