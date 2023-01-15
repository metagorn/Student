namespace LAB3
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        List<double> doubles = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i = 0;
            //Create Student object
            //Student student0 = new Student("Zack", "653450100-9", "CIS", 2003, 189, 4);
            //Student student1 = new Student("Zuck", "6534502347", "CIS", 2002, 185, 3);

            //add value to oblect attribute
            //student0._name = "Zack";
            //student0._brith = 2003;
            //student1._name = "Zuck";
            //student1._brith = 2002; "วิทยาการคอมพิมเตอร์และสารสนเทศ"

            //get value from object attribute
            //textBoxName.Text = student0._name;
            //textBoxID.Text = student0._id;
            //textBoxBranch.Text = student0._branch;
            //textBoxBrithyear.Text = student0._brith.ToString();
            //textBoxHight.Text = student0._hight.ToString();
            //textBoxGrade.Text = student0._grade.ToString();


            //Calculate obj age
            //textBoxAge.Text = student0.myAge().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String id = this.textBoxID.Text;
            String brith = this.textBoxBrithyear.Text;
            String age = this.textBoxAge.Text;
            String hight = this.textBoxHight.Text;
            String grade = this.textBoxGrade.Text;
            String branch = this.textBoxBranch.Text;

            //create obj from Student
            Student std = new Student(name, id, int.Parse(brith), int.Parse(age), int.Parse(hight), int.Parse(grade), branch) { };
            dataGridView1.Rows.Add(
                std._name,
                std._id,
                std._brith,
                std._age,
                std._hight,
                std._grade,
                std._branch
                );
            list.Add(std._name);
            doubles.Add(std._grade);
            doubles.Sort();

            Top.Text = "คะแนนมากสุด " + doubles.Last().ToString();
            Last.Text = "คะแนนน้อยสุด " + doubles.First().ToString();

            Count.Text = "นักเรียนทั้งหมด " + list.Count.ToString() + " คน";
            //clear texebox
            this.textBoxName.Text = "";
            this.textBoxID.Text = "";
            this.textBoxBrithyear.Text = "";
            this.textBoxAge.Text = "";
            this.textBoxHight.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxBranch.Text = "";


        }
    }
}