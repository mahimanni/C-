using System.Data.SqlClient;
namespace DatabaseConn3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str, sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        Random r= new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");
            long d = r.NextInt64(1,6);//no of images.... 5 images so from 1 to 6 as random from start to end-1
            int d1= Convert.ToInt32(d);
            MessageBox.Show(d1.ToString());
            
            //sql = "select imgpath from imgtab";
            sql= "select id, imgpath from imgtab where id="+d1+"";
            cmd= new SqlCommand(sql, conn);
            conn.Open();
            dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                string x = dr[1].ToString();
                pictureBox1.Image = Image.FromFile(x);
            }
            dr.Close();
            conn.Close();
            cmd.Dispose();
        }
    }
}
