using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structures
{
    // just some work with child classes
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Changes animals = new Changes();
                Cat cat = new Cat();
                animals.ShowNS(textBox1, textBox2, label4);
                animals.ShowPoroda(textBox3);
                label5.Text = "Cat's mass = " + Convert.ToString(animals.mass());
                label6.Text = "Mass in grams:  " + Convert.ToString(animals.massInGramms());




            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        class Animal
        {
            public string name;
            public int height;


            public void ShowNS(TextBox t1, TextBox t2, Label l1)
            {
                name = Convert.ToString(t1.Text);
                height = Convert.ToInt16(t2.Text);
                l1.Text = "Name and height:  " + name + "  ,  " + height;
            }



        }
        class Cat : Animal
        {
            string breed;
            int k = 10;

            public void ShowPoroda(TextBox t1  )
            {
                breed = Convert.ToString(t1.Text);

            }
            public string Breed
            {
                get { return breed; }
            }
            public double mass()
            {
                return height * k;
            }
           
        }
        class Changes : Cat
        {
            public double massInGramms()
            {
                return mass() * 1000;
            }
        }
    }
}
