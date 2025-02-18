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

            /*
            //rep("CheatDetect Neuter", "e8 ?? ?? ?? ?? 33 ff 48 39 3d ?? ?? ?? ?? 75 42", "90 90 90 90 90 33 ff 48 39 3d ?? ?? ?? ?? 75 42");
            //rep("Logos begone", "00 e8 ?? ?? ?? ?? 80 bf b8 00 00 00 00 74 53 48", "00 e8 ?? ?? ?? ?? 80 bf b8 00 00 00 00 90 90 48");
            */


            rep("EXE Integrity checks(1)", "8b 14 8b 3b c2", "8b 14 8b 39 c0");
            rep("EXE Integrity checks(2)", "f7 d9 03 0c 82", "b9 00 00 00 00");

            rep("NOP[11]", "66 66 66 0f 1f 84 00 00 00 00 00", "90 90 90 90 90 90 90 90 90 90 90");
            rep("NOP[10]", "66 66 0f 1f 84 00 00 00 00 00", "90 90 90 90 90 90 90 90 90 90");
            rep("NOP[9]", "66 0f 1f 84 00 00 00 00 00", "90 90 90 90 90 90 90 90 90");
            rep("NOP[8]", "0f 1f 84 00 00 00 00 00", "90 90 90 90 90 90 90 90");
            rep("NOP[7]", "0f 1f 80 00 00 00 00", "90 90 90 90 90 90 90");
            rep("NOP[6]", "66 0f 1f 44 00 00", "90 90 90 90 90 90");
            rep("NOP[5]", "0f 1f 44 00 00", "90 90 90 90 90");
            rep("NOP[4]", "0f 1f 40 00", "90 90 90 90");

            rep("Ret", "48 8d 64 24 08 ff 64 24 f8", "c3 90 90 90 90 90 90 90 90");
            rep("Stack Waste(1)", "48 8d 64 24 f8 48 8d 64 24 08", "90 90 90 90 90 90 90 90 90 90");
            rep("Stack Waste(2)", "48 8d 64 24 08 48 8d 64 24 f8", "90 90 90 90 90 90 90 90 90 90");
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



            //rep("Add rsp 0x8", "48 8d 64 24 08", "48 83 c4 08 90");   //UNTESTED
            //rep("Sub Rsp, 0x8", "48 8d 64 24 f8", "48 83 ec 08 90");  //BAD, DON'T USE


            //ugly DSR crap
            //rep("game_runtime_hash_checks_4", 
            //"48 8b ?? 24 10 48 ?? ?? ?? ?? ?? ?? ?? ?? ?? 48 0f 46 ?? 48 89 ?? 24 10 48 ?? ?? 24", 
            //"48 8b ?? 24 10 48 ?? ?? ?? ?? ?? ?? ?? ?? ?? 90 90 90 90 48 89 ?? 24 10 48 ?? ?? 24");
            //48 8B 54 24 10 48 BB E4 10 17 42 01 00 00 00 48 0F 46 D3 48 89 54 24 10 48 8B 1C 24 48 8D 64 24 08 48 8B 14 24 48 8D 64 24 08 48 8D 64 24 08 FF 64 24 F8 E9 79 51 35 00 48 8B 05 42 B4
            //             48 8b ?? 24 10 48 b? ?? ?? ?? ?? ?? ?? ?? ?? *90 90 90 90* 48 89 ?c 24 10 48 8? ?4 24
            //142038b11    48 8b 4c 24 10 48 ba ?? ?? ?? ?? ?? ?? ?? ?? *48 0f 46 ca* 48 89 4c 24 10 48 8b 14 24
            //14261cc2b    48 8b 5c 24 10 48 b8 ?? ?? ?? ?? ?? ?? ?? ?? *48 0f 46 d8* 48 89 5c 24 10 48 8d 64 24
            //142e3ef86    48 8b 4c 24 10 48 ba ?? ?? ?? ?? ?? ?? ?? ?? *48 0f 46 ca* 48 89 4c 24 10 48 8b 14 24




            //rep("game_runtime_hash_checks_6", "8b 05 ?? ?? ?? ?? 8b 15 ?? ?? ?? ?? 3b c2 0f 86 ?? ?? ?? ?? e9", "8b 05 ?? ?? ?? ?? 8b 15 ?? ?? ?? ?? 3b c2 90 90 90 90 90 90 e9");

            //142208c29    8b 05 ?? ?? ?? ?? 8b 15 ?? ?? ?? ?? 3b c2 *0f 86 ?? ?? ?? ?? e9
            //0f 86 6e 27 5f 00 /e9
            //3b c2/ 0f 86 2b 94 dc fe /e9
            //3b c2/ 0f 86 2a a1 41 00 /e9
            //3b c2/ 0f 86 a5 3f f3 00 /e9
            rep("game_hash_compare_checks", "8b 14 8b 3b c2", "8b 14 8b 39 c0");
            rep("game_hash_compare_checks_alt", "f7 d9 03 0c 82", "b9 00 00 00 00");


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
