namespace Calculator
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Click = textBox1.Text;
        
   
            label1.Text = Click;
          if(Click != null)
            {
               
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

       
    }
}