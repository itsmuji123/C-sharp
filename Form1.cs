namespace C__Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checked_List.Items.Add("ISLAMYAT");
            checked_List.Items.Add("PAK-STUDY");
            checked_List.Items.Add("MATH");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pre = checkBox1.CheckState.ToString();
            string firstName = textBox1.Text;
            string lname = textBox2.Text;
            string r = "";
            List<string> selectedSubjects = checked_List.CheckedItems.Cast<string>().ToList();



            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter a non-empty fitst name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(lname))
            {
                MessageBox.Show("Please enter a non-empty last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedSubjects.Count < 2)
            {
                MessageBox.Show("Select at least 2 subjects.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                r = string.Join(", ", selectedSubjects);
            }



            label4.Text = $"First Name : {firstName}\nLast Name : {lname}\n" +
                          $"Subjects : {r} \nPrerequisite : {pre}";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}