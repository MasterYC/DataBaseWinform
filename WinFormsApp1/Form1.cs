using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.VisualBasic;
namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    private MySqlConnection connection;
    public Form1()//初始化时连接MySQL
    {
      string str = "server=localhost;User Id=root;password=root;Database=yc";
      connection = new MySqlConnection(str);
      connection.Open();
      InitializeComponent();
    }
    private void Query()//查询语句函数
    {
      string sql = "select * from course";//定义查询语句
      //执行查询语句并将数据填入数据框
      var da = new MySqlDataAdapter(sql, connection);
      var dt = new DataTable();
      da.Fill(dt);
      dataGridView1.DataSource = dt;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Query();
    }

    private void button2_Click(object sender, EventArgs e)//删除指定列
    {
      try
      {
        var row = dataGridView1.CurrentRow.Index;//获取数据表当前的焦点的行
        if (row < 0) return;
        var result = MessageBox.Show("确定要删除吗？", "询问信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No) return;
        var sno = dataGridView1["Cno", row].Value.ToString();//获取该行的Cno
        //执行删除语句删除该列
        string sql = "delete from course where Cno=?";
        var cmd = new MySqlCommand(sql, connection);
        var param = new MySqlParameter();
        param.DbType = DbType.String;
        param.Value = sno;
        cmd.Parameters.Add(param);
        var count = cmd.ExecuteNonQuery();
        MessageBox.Show("删除成功");
        Query();
      }
      catch (Exception ex)
      {
        MessageBox.Show("删除失败");
      }
    }

    private void button4_Click(object sender, EventArgs e)//增加数据
    {
      //通过输入框获取四个属性要插入的值
      string Cno = Interaction.InputBox("Cno", "增加数据", "", -1);
      string Cname = Interaction.InputBox("Cname", "增加数据", "", -1);
      
      string Cpno = Interaction.InputBox("Cpno", "增加数据", "", -1);
      string Ccredit = Interaction.InputBox("Ccredit", "增加数据", "", -1);
      try
      {
        //执行插入语句
        string sql = "insert into course values(" + Cno + ",'"+Cname+"',"+Cpno+','+Ccredit+");";
        MySqlCommand myCmd = new MySqlCommand(sql, connection);
        int Cmd = myCmd.ExecuteNonQuery();

      }
      catch(Exception ex)
      {
        MessageBox.Show("添加失败");
        //MessageBox.Show(ex.Message);
        return;
      }

      MessageBox.Show("添加成功");
      Query();
    }

    private void button3_Click(object sender, EventArgs e)//修改
    {
      try
      {
        var cell = dataGridView1.CurrentCell;//获取焦点对应的单元格
        var row = dataGridView1.CurrentRow.Index;//获取焦点对应的行
        string Cno= dataGridView1["Cno", row].Value.ToString();//获取要修改数据地方的Cno
        string coluName = cell.OwningColumn.HeaderText;//获取要修改的属性
        //执行修改语句
        string value= Interaction.InputBox(coluName, "修改数据", "", -1);
        string sql = "update course set " + coluName + "='" + value + "' where Cno=" + Cno;
        MySqlCommand myCmd = new MySqlCommand(sql, connection);
        int Cmd = myCmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        MessageBox.Show("修改失败");
        return;
      }
      Query();
    }
  }
}