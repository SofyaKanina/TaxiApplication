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

namespace WindowsFormsApp1
{
    public partial class MainScreen : Form
    {
        public struct Location
        {
            public double X;
            public double Y;
        };
        public class Driver
        {
            public string FirstName;
            public string SecondName;
            public string nationality;
            string number;
            public double rating;
            public bool available;

            public Driver(string S)
            {
                string[] data = S.Split(',');
                FirstName = data[0];
                SecondName = data[1];
                nationality = data[2];
                number = data[3];
                rating = Convert.ToDouble(data[4]);
                available = Convert.ToBoolean(data[5]);
            }
        }
        public class Taxi
        {
            public int driver_id;
            public string number; //smth like s128le
            Location location;
            public string Class; //econom, comfort, buisness
            public List<string> companies = new List<string>(); //taxi can work for several companies

            public Taxi(string S)
            {
                string[] data = S.Split(',');
                driver_id = Convert.ToInt32(data[0]);
                number = data[1];
                location = new Location{X = Convert.ToDouble(data[2]), Y = Convert.ToDouble(data[3])};
                Class = data[4];
                int i = 5;
                while (i != data.Length)
                    companies.Add(data[i++]);
            }
        }
        public class Company
        {
            public string name;
            public List<Taxi> taxis = new List<Taxi>();
            public double rating;
            public double short_dist_prise;//price for kilometer of a road to 1km
            public double avg_dist_prise;//price for kilometer of a road to 3km
            public double long_dist_prise;//price for kilometer of a road over 3km
            public double avg_mn;//multiply price for using average class
            public double buiness_mn;//multiply price for using buisness class

            public Company(string S)
            {
                string[] data = S.Split(',');
                name = data[0];
                rating = Convert.ToDouble(data[1]);
                short_dist_prise = Convert.ToDouble(data[2]);
                avg_dist_prise = Convert.ToDouble(data[3]);
                long_dist_prise = Convert.ToDouble(data[4]);
                avg_mn = Convert.ToDouble(data[5]);
                buiness_mn = Convert.ToDouble(data[6]);
            }
        }

        bool exeption = false;

        public List<Driver> Drivers = new List<Driver>();
        public List<Taxi> Taxis = new List<Taxi>();
        public List<Company> Companies = new List<Company>();
        string Message = "Приветствуем вас в Taxi Choice!\r\n" +
                "Чтобы начать работу, нажмите кнопку \"Выбрать такси\"";
        Location UserLocation = new Location{X = 0, Y = 0};
        Location DestLocation = new Location { X = 0, Y = 0 };
        public Dictionary<string, Location> Places = new Dictionary<string, Location>();

        public MainScreen()
        {
            InitializeComponent();
        }

        void AdaptiveDesign()
        {
            int Width = 8;
            int Height = 8;
            StartButton.Width = this.Width / 5;
            StartButton.Height = this.Height / 10;
            StartButton.Location = new Point(this.Width / 2 - StartButton.Width / 2, this.Height / 2 - StartButton.Height / 2);
            label7.Height = this.Height / 23;
            label7.Width = this.Width / 4;
            label7.Location = new Point(Width, Height);
            Height += label7.Height;
            ServiseChooser.Width = label7.Width;
            ServiseChooser.Height = this.Height / 6;
            ServiseChooser.Location = new Point(Width, Height);
            Height += ServiseChooser.Height;
            HighestratingButton.Width = ServiseChooser.Width;
            HighestratingButton.Height = this.Height / 20;
            HighestratingButton.Location = new Point(Width, Height);
            Height += HighestratingButton.Height;
            AllServisesButton.Width = HighestratingButton.Width;
            AllServisesButton.Height = HighestratingButton.Height;
            AllServisesButton.Location = new Point(Width, Height);
            Height += (AllServisesButton.Height + this.Height / 10);
            label6.Size = label7.Size;
            label6.Location = new Point(Width, Height);
            Height += label6.Height;
            ClassChooser.Size = ServiseChooser.Size;
            ClassChooser.Location = new Point(Width, Height);
            Height += ClassChooser.Height;
            AllClassesButton.Size = AllServisesButton.Size;
            AllClassesButton.Location = new Point(Width, Height);
            HelpButton.Width = this.Width / 23;
            HelpButton.Height = this.Height / 20;
            HelpButton.Location = new Point(this.Width - HelpButton.Width * 2, this.Height - HelpButton.Height * 3);
            label1.Size = label6.Size;
            Width = this.Width - label1.Width * 13 / 11;
            Height = 8;
            label1.Location = new Point(this.Width - label1.Width * 13/11, Height);
            Height += label1.Height + 8;
            DataLabel.Size = label1.Size;
            DataLabel.Location = new Point(Width, Height);
            Height += DataLabel.Height;
            TimeLabel.Size = label1.Size;
            TimeLabel.Location = new Point(Width, Height);
            Height += TimeLabel.Height;
            label2.Size = label6.Size;
            Height = 8;
            Width = this.Width / 2 - label2.Width * 3/4;
            label2.Location = new Point(Width, Height);
            Height += label2.Height;
            label3.Width = label2.Width / 2;
            label3.Height = label2.Height;
            label3.Location = new Point(Width, Height);
            Coord1Box.Size = label3.Size;
            Coord1Box.Location = new Point(Width + label3.Width, Height);
            Height += label3.Height;
            label4.Size = label3.Size;
            label4.Location = new Point(Width, Height);
            Coord2Box.Size = label4.Size;
            Coord2Box.Location = new Point(Width + label4.Width, Height);
            Height += label4.Height;
            linkLabel1.Size = label2.Size;
            linkLabel1.Location = new Point(Width, Height);
            Height += linkLabel1.Height;
            PlacesToGo2.Location = new Point(Width, Height);
            Height += (PlacesToGo2.Height + this.Height / 10);
            label5.Height = label2.Height;
            label5.Width = this.Width / 26 * 10;
            PlacesToGo2.Size = label5.Size;
            label5.Location = new Point(Width, Height);
            Height += label5.Height;
            label8.Size = label3.Size;
            label8.Location = new Point(Width, Height);
            Dest1Box.Size = label8.Size;
            Dest1Box.Location = new Point(Width + label8.Width, Height);
            Height += label8.Height;
            label9.Size = label8.Size;
            label9.Location = new Point(Width, Height);
            Dest2Box.Size = label9.Size;
            Dest2Box.Location = new Point(Width + label9.Width, Height);
            Height += label9.Height;
            PlacesToGo.Size = PlacesToGo2.Size;
            PlacesToGo.Location = new Point(Width, Height);
            Height += (PlacesToGo.Height + this.Height / 18);
            FinalButton.Width = PlacesToGo.Width;
            FinalButton.Height = this.Height / 8;
            FinalButton.Location = new Point(Width, Height);
            Width += FinalButton.Width + 8;
            ServiseLabel.Width = FinalButton.Width / 2;
            ServiseLabel.Height = FinalButton.Height / 2 - 4;
            ServiseLabel.Location = new Point(Width, Height);
            Height += (ServiseLabel.Height + 8);
            PriceLabel.Size = ServiseLabel.Size;
            PriceLabel.Location = new Point(Width, Height);
        }//just sets Height, Width and Location of the objects

        public void SetTime()
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            string time = "";
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string data = "";
            {
                if (h < 10)
                {
                    time += "0" + h;
                }
                else
                {
                    time += h;
                }

                time += ":";

                if (m < 10)
                {
                    time += "0" + m;
                }
                else
                {
                    time += m;
                }

                time += ":";

                if (s < 10)
                {
                    time += "0" + s;
                }
                else
                {
                    time += s;
                }


                if (day < 10)
                {
                    data += "0" + day;
                }
                else
                {
                    data += day;
                }
                data += ".";
                if (month < 10)
                {
                    data += "0" + month;
                }
                else
                {
                    data += month;
                }
                data += ".";
                data += year;
            }//if to show "08" instead of "8"
            TimeLabel.Text = time;
            DataLabel.Text = data;
        }

        public void RedrawClasses()
        {
            List<string> tmp = new List<string>();
            foreach (object Item in ClassChooser.CheckedItems)
                tmp.Add(Item.ToString());
            ClassChooser.Items.Clear();
            foreach (object Item in ServiseChooser.CheckedItems)
            {
                string ToCompare = Item.ToString();
                int i = 0;
                while (ToCompare != Companies[i].name + " / " + Math.Round(Companies[i].rating, 1).ToString())
                    i++;
                int j = 0;
                foreach (Taxi Tax in Companies[i].taxis)
                {
                    if (!ClassChooser.Items.Contains(Tax.Class))
                    {
                        ClassChooser.Items.Add(Tax.Class);
                        j++;
                    }
                }
                for (i = 0; i < j; ++i)
                    if (tmp.Contains(ClassChooser.Items[i].ToString()))
                        ClassChooser.SetItemChecked(i, true);
            }
        }

        public int get_price(Location A, Location B, Company comp)
        {
            double price;
            double delta = Math.Acos(Math.Sin(A.X) * Math.Sin(B.X) + Math.Cos(A.X) * Math.Cos(B.X) * Math.Cos(B.Y - A.Y));
            double dist = delta * 111.1; //см.Ортодормия в Вики
            if (dist >= 1.0)
                price = dist * comp.short_dist_prise;
            else if(dist <= 3.0)
                price = dist * comp.avg_dist_prise;
            else
                price = dist * comp.long_dist_prise;
            double mn = -1.0;
            List<string> classes1 = new List<string>();
            bool eco = false;
            bool avg = false;
            bool buis = false;
            foreach(Taxi elt in comp.taxis)
            {
                if(ClassChooser.CheckedItems.Contains(elt.Class))
                {
                    switch(elt.Class)
                    {
                        case "Эконом": eco = true; break;
                        case "Комфорт": avg = true; break;
                        case "Бизнес": buis = true; break;
                    }
                }
            }
            if (eco) mn = 1.0;
            else if (avg) mn = comp.avg_mn;
            else if (buis) mn = comp.buiness_mn;
            return Convert.ToInt32(price * mn);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            this.Size = this.MinimumSize;
            timer1.Interval = 1000; //1 sec
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            SetTime();
            {
                StreamReader f = new StreamReader("Drivers.txt", Encoding.GetEncoding(1251));
                string S;
                S = f.ReadLine();
                while ((S = f.ReadLine()) != null)
                {
                    Driver tmp = new Driver(S);
                    Drivers.Add(tmp);
                }
                f.Close();
            }//init Drivers
            {
                StreamReader f = new StreamReader("Taxies.txt", Encoding.GetEncoding(1251));
                string S;
                S = f.ReadLine();
                while ((S = f.ReadLine()) != null)
                {
                    Taxi tmp = new Taxi(S);
                    Taxis.Add(tmp);
                }
                f.Close();
            }//init Taxis
            {
                StreamReader f = new StreamReader("Companies.txt", Encoding.GetEncoding(1251));
                string S;
                S = f.ReadLine();
                while ((S = f.ReadLine()) != null)
                {
                    Company tmp = new Company(S);
                    for(int i = 0; i < Taxis.Count(); ++i)
                    {
                       for(int j = 0; j < Taxis[i].companies.Count(); ++j)
                        {
                            if ((Taxis[i].companies[j] == tmp.name) && (Drivers[Taxis[i].driver_id].available))
                                tmp.taxis.Add(Taxis[i]);
                        }
                    }
                    if(tmp.taxis.Count != 0)
                        Companies.Add(tmp);
                }
                f.Close();
            }//init Companies
            {
                StreamReader f = new StreamReader("Places.txt", Encoding.GetEncoding(1251));
                string S;
                S = f.ReadLine();
                while ((S = f.ReadLine()) != null)
                {
                    string[] data = S.Split(',');
                    Location tmp = new Location();
                    tmp.X = Convert.ToDouble(data[1]);
                    tmp.Y = Convert.ToDouble(data[2]);
                    Places.Add(data[0], tmp);
                }
                f.Close();
                foreach (KeyValuePair<string, Location> elt in Places)
                {
                    PlacesToGo.Items.Add(elt.Key);
                    PlacesToGo2.Items.Add(elt.Key);
                }
            }//init Places
            AdaptiveDesign();
            for (int i = 0; i < Companies.Count(); ++i)
            {
                double tmp = System.Math.Round(Companies[i].rating, 1);
                ServiseChooser.Items.Add(Companies[i].name + " / " + tmp.ToString()); 
            }
            ClassChooser.Items.Add("Эконом");
            ClassChooser.Items.Add("Комфорт");
            ClassChooser.Items.Add("Бизнес");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            ServiseChooser.Visible = true;
            ClassChooser.Visible = true;
            HighestratingButton.Visible = true;
            linkLabel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            PlacesToGo.Visible = true;
            PlacesToGo2.Visible = true;
            Coord1Box.Visible = true;
            Coord2Box.Visible = true;
            Dest1Box.Visible = true;
            Dest2Box.Visible = true;
            FinalButton.Visible = true;
            AllClassesButton.Visible = true;
            AllServisesButton.Visible = true;
            Message = "В верхнем левом углу выберите предпочитаемые сервисы, либо нажмите кнопку \"Наивысший Рейтинг\", чтобы выбрать сервис с самыми хорошими отзывами. Чтобы выбрать все сервисы, нажмите соответствуютщую кнопку.\r\n" +
                "После этого выберите предпочитаемый класс такси. В специальном поле показаны все доступные классы такси для выбранных сервисов. Если не показано ни одного класса, то у данного сервиса сейчас нет свободных такси этого класса. Чтобы выбрать все классы, нажмите соответствующую кнопку.\r\n" +
                "Затем введите свои координаты, координаты пункта назначения и нажмите кнопку \"Определить сервис и цену\"\r\n" +
                "Приложение подберет наиболее выгодный для вас сервис и посчитает приблизительную цену поездки.";
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void MainScreen_SizeChanged(object sender, EventArgs e)
        {
            AdaptiveDesign();
        }

        private void HighestRatingButton_Click(object sender, EventArgs e)
        {
            double max = Companies[0].rating; int maxi = 0;
            double tmp;
            for(int i = 0; i < Companies.Count(); ++i)
            {
                tmp = Companies[i].rating;
                if(tmp > max)
                {
                    max = tmp;
                    maxi = i;
                }
            }
            string ToCompare = Companies[maxi].name + " / " + Math.Round(Companies[maxi].rating, 1).ToString();
            for(int i = 0; i < Companies.Count(); ++i)
            {
                if (ServiseChooser.Items[i].ToString() == ToCompare)
                    ServiseChooser.SetItemChecked(i, true);
                else
                    ServiseChooser.SetItemChecked(i, false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTime();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //getMylocation(double Width, double Height)  //idk how to do this
            UserLocation = new Location { X = 55.761387, Y = 37.632956 };//Main HSE building
            Coord1Box.Text = UserLocation.X.ToString();
            Coord2Box.Text = UserLocation.Y.ToString();
            MessageBox.Show("Определение координат будет доступно в следующих версиях программы. \r\n Выставлены координаты главного здания Высшей Школы Экономики.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ServiseChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawClasses();
        }

        private void PlacesToGo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DestLocation = new Location{X = Places[PlacesToGo.SelectedItem.ToString()].X, Y = Places[PlacesToGo.SelectedItem.ToString()].Y };
            Dest1Box.Text = Places[PlacesToGo.SelectedItem.ToString()].X.ToString();
            Dest2Box.Text = Places[PlacesToGo.SelectedItem.ToString()].Y.ToString();
        }

        private void PlacesToGo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coord1Box.Text = Places[PlacesToGo2.SelectedItem.ToString()].X.ToString();
            Coord2Box.Text = Places[PlacesToGo2.SelectedItem.ToString()].Y.ToString();
        }

        private void FinalButton_Click(object sender, EventArgs e)
        {
            exeption = false;
            List<int> choosen_comp = new List<int>();
            foreach(object item in ServiseChooser.CheckedItems)
            {
                string ToCompare = item.ToString();
                int i = 0;
                while (ToCompare != Companies[i].name + " / " + Math.Round(Companies[i].rating, 1).ToString())
                    i++;
                choosen_comp.Add(i);
            }
            if (choosen_comp.Count() == 0)
                MessageBox.Show("Не выбран сервис!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (UserLocation.X == 0)
                {
                    try
                    {UserLocation = new Location{ X = Convert.ToDouble(Coord1Box.Text), Y = Convert.ToDouble(Coord2Box.Text)};}    
                    catch (FormatException)
                    { MessageBox.Show("Не указаны ваши координаты!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); exeption = true; }
 
                }
                else if (!exeption)
                {
                    if (DestLocation.X == 0)
                    {
                        try
                        { DestLocation = new Location { X = Convert.ToDouble(Dest1Box.Text), Y = Convert.ToDouble(Dest2Box.Text) }; }
                        catch (FormatException)
                        { MessageBox.Show("Не указаны координаты пункта назначения!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); exeption = true; }
                    }
                    else if(!exeption)
                    {
                        int min_i = choosen_comp[0];
                        int min_order_price = get_price(UserLocation, DestLocation, Companies[min_i]);
                        foreach (int i in choosen_comp)
                        {
                            if (min_order_price < 0)
                            {
                                min_order_price = get_price(UserLocation, DestLocation, Companies[i]);
                                min_i = i;
                            }
                            else
                            {
                                int order_price = get_price(UserLocation, DestLocation, Companies[i]);
                                if (order_price > 0 && order_price < min_order_price)
                                {
                                    min_i = i;
                                    min_order_price = order_price;
                                }
                            }
                        }
                        if (min_order_price < 0)
                            MessageBox.Show("Не выбраны классы такси!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            PriceLabel.Text = min_order_price.ToString() + "RUB";
                            ServiseLabel.Text = Companies[min_i].name;
                            PriceLabel.Visible = true;
                            ServiseLabel.Visible = true;
                        }
                    }
                }
            }
        }

        private void AllServisesButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Companies.Count(); ++i)
                ServiseChooser.SetItemChecked(i, true);
            RedrawClasses();
        }

        private void AllClassesButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ClassChooser.Items.Count; ++i)
                ClassChooser.SetItemChecked(i, true);
        }
    }
}
