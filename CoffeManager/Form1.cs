namespace CoffeManager
{
    public partial class Form1 : Form
    {
        private Coffe[] coffeList = new Coffe[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("coffeTypes.txt");
            for (int i = 0; !file.EndOfStream; i++)
            {
                string line = file.ReadLine();
                string[] values = line.Split(",");
                coffeList[i] = new Coffe(values[0], int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]));

            }
            file.Close();
        }
        void SaveCoffeRecord(string coffeName)
        {
            DateTime dt = DateTime.Now;
            StreamWriter file = new("coffeRecords.txt", true);
            string line = $"{{ name: {coffeName}, date: {dt} }}";
            file.WriteLine(line);
            file.Close();
        }
        void MakeCoffe(Coffe coffe, ProgressBar cafeVal, ProgressBar waterVal, ProgressBar milkVal)
        {
            if (cafeVal.Value - coffe.coffeReq < 0)
            {
                MessageBox.Show("Brakuje kawy!");
                return;
            }
            if (waterVal.Value - coffe.waterReq < 0)
            {
                MessageBox.Show("Brakuje wody!");
                return;
            }
            if (milkVal.Value - coffe.milkReq < 0)
            {
                MessageBox.Show("Brakuje mleka!");
                return;
            }
            cafeVal.Value -= coffe.coffeReq;
            waterVal.Value -= coffe.waterReq;
            milkVal.Value -= coffe.milkReq;

            SaveCoffeRecord(coffe.name);
            MessageBox.Show($"Zrobiono: {coffe.name}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) MessageBox.Show("Wybierz kawę melepeto jebany");
            else
            {
                foreach (var coffe in coffeList)
                {
                    if (coffe.name == comboBox1.Items[comboBox1.SelectedIndex].ToString())
                    {
                        MakeCoffe(coffe, CoffeBar, WaterBar, MilkBar);
                    }
                }
            }
        }

        private void addCoffe_Click(object sender, EventArgs e)
        {
            if (CoffeBar.Value == CoffeBar.Maximum) MessageBox.Show("Starczy kurwa");
            else CoffeBar.Value += 1;
        }

        private void addWater_Click(object sender, EventArgs e)
        {
            if (WaterBar.Value == WaterBar.Maximum) MessageBox.Show("Starczy kurwa");
            else WaterBar.Value += 1;
        }

        private void addMilk_Click(object sender, EventArgs e)
        {
            if (MilkBar.Value == MilkBar.Maximum) MessageBox.Show("Starczy kurwa");
            else MilkBar.Value += 1;
        }
    }
}
