using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_sales2
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();
            Cars = new List<Car>();

            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });

            int i = Cars.Select(x => x.Color).Distinct().Count();
            var CarColors = Cars.Select(x => x.Color).Distinct();
            foreach (var item in CarColors)
            {
                listBox3.Items.Add(item);
            }

            List();




        }

        class Car
        {
            public int Id;
            public string Make;
            public string Model;
            public string Color;
            public int Km;
            public int Price;
            public int Year;

            public override string ToString()
            {
                return $"{Make} {Model}";
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ListBox myListofCars = sender as ListBox;

            Car mySelectedCar = myListofCars.SelectedItem as Car;

            listBox2.Items.Add($"Id: {mySelectedCar.Id}");
            listBox2.Items.Add($"Model: {mySelectedCar.Make} {mySelectedCar.Model}");
            listBox2.Items.Add($"Driving distance: {mySelectedCar.Km} Km");
            listBox2.Items.Add($"Color: {mySelectedCar.Color}");
            listBox2.Items.Add($"Price: {mySelectedCar.Price} SEK");
            listBox2.Items.Add($"Year: {mySelectedCar.Year}");


        }

            
    private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox4.Items.Clear();
            string ChoiceColor = (sender as ListBox).SelectedItem as string;

            var i = Cars.FindAll(x => x.Color == ChoiceColor);
            foreach (var item in i)
            {
                listBox4.Items.Add($"{item}");
            }
        }


        public void List()
        {
            foreach (Car cars in Cars.OrderBy(x => x.Make))
            {
                listBox1.Items.Add(cars);
            };
        }
        
         public int Index()
        {
            var index = Cars.Select(x => x.Id).Max();
            int index1 = index + 1;
            return index1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SelectedID = int.Parse(textBox1.Text);
            var SelectedCar = Cars.Find(x => x.Id == SelectedID);
            textBox2.Text = SelectedCar.Price.ToString();
            textBox3.Text = SelectedCar.Km.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars.Find(x => x.Id == int.Parse(textBox1.Text)).Price = int.Parse(textBox2.Text);
            Cars.Find(x => x.Id == int.Parse(textBox1.Text)).Km = int.Parse(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SelectedID = Cars.FindIndex(x => x.Id == int.Parse(textBox1.Text));
            Cars.RemoveAt(SelectedID);
            listBox1.Items.Clear();
            List();


        }



        private void button4_Click(object sender, EventArgs e)
        {

            Cars.Add(new Car() { Id = Index(),Make = textBox4.Text, Model = textBox5.Text, Color = textBox6.Text, Km = int.Parse(textBox7.Text),
                Price = int.Parse(textBox8.Text), Year = int.Parse(textBox9.Text)});
            listBox1.Items.Clear();
            List();

        }
    }



}
