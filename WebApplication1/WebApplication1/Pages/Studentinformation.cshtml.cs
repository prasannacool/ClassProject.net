using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class StudentinformationModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string connctionString;
            sqlConnction cnn;
            connctionString = @"Data Source=DESKTOP-FC57E3V;Initial Catalog=school;Integrated Security=True"
            cnn = new sqlConnction(connctionString);
            cnn.Open()
                Response.WriteAsJsonAsync("Connction Succeede");

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * from school";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>";
            }

            cnnn.Close();
        }
    }
}
