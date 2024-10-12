using Quiz.Entities.Entities;
using System.Data.SqlClient;




var connStr = "Server=.\\HERMANLOCAL;Database=QuizDb5;Integrated Security=True;TrustServerCertificate=True;";
var connection = new SqlConnection(connStr);
connection.Open();
var query = "SELECT * FROM Questions";
var cmd = new SqlCommand(query, connection);
var reader = cmd.ExecuteReader();
while (reader.Read())
{
	var q = new Question();
	q.QuestionId = reader.GetInt32(0);
	q.QuestionCategory = reader.GetInt32(1);
	q.QuestionContent = reader.GetString(2);
}

connection.Close();












Console.WriteLine("Hello, World!");
