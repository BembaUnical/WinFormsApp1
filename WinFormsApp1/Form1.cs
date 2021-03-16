using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization arrays
            int[] nums1 = new int[4];
            int[] nums2 = new int[4];
            int[] nums3 = new int[4];

            // Fill arrays
            Random rnd = new Random();

            for(int i = 0; i < 4; i++)
            {
                nums1[i] = rnd.Next(1, 10);
            }

            for (int i = 0; i < 4; i++)
            {
                nums2[i] = rnd.Next(1, 10);
            }

            for (int i = 0; i < 4; i++)
            {
                nums3[i] = rnd.Next(1, 10);
            }

            // Arrays output
            textBox1.Text = String.Join(" ", nums1);
            textBox2.Text = String.Join(" ", nums2);
            textBox3.Text = String.Join(" ", nums3);

            // Initialization LinkedList
            LinkedList<int> nums4 = new LinkedList<int>();

            // Fill LinkedList
            for (int i = 0; i < 4; i++)
            {
                nums4.AddLast(nums1[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                nums4.AddLast(nums2[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                nums4.AddLast(nums3[i]);
            }

            // LinkedList output
            textBox4.Text = String.Join(" ", nums4);

            // Get max values in arrat A&B using LinkedList and output 
            int iMax = nums4.First();

            for(int i = 0; i < 4; i++)
            {
                int iValue = nums4.ElementAt(i);

                if (iValue > iMax) iMax = iValue;
            }

            textBox5.Text += iMax;

            iMax = nums4.ElementAt(5);

            for (int i = 4; i < 8; i++)
            {
                int iValue = nums4.ElementAt(i);

                if (iValue > iMax) iMax = iValue;
            }

            textBox6.Text += iMax;

            // Get sum arrays A&B using LinkedList and Output
            int iSumArray = 0;

            for (int i = 0; i < 8; i++)
            {
                iSumArray += nums4.ElementAt(i);
            }

            textBox7.Text += iSumArray;

            // Initialization & Generate new LinkedList from B&C arrays using LinkedList
            LinkedList<int> nums5 = new LinkedList<int>();

            for (int i = 4; i < 12; i++)
            {
                nums5.AddLast(nums4.ElementAt(i));
            }

            textBox8.Text = String.Join(" ", nums5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
