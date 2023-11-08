// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using dotnetapp.Models;
// using System.Data;
// using System.Data.SqlClient;
// using System.Configuration;


// namespace dotnetapp.Managers
// {
//     public class PlayerManager
//     {
//         // Write your fuctions here...
//         // DisplayAllPlayers
//         // AddPlayer
//         // EditPlayer
//         // DeletePlayer
//         // ListPlayers
//         // FindPlayer
//         // DisplayAllPlayers
//         public void DisplayAllPlayers(){

//         }
//         public void AddPlayer(){

//         }
//         public void EditPlayer(){

//         }
//         public void DeletePlayer(){

//         }
//         public void ListPlayers(){

//         }
//         public void FindPlayer(){

//         }

//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
 
 
namespace dotnetapp.Managers
{
    public class PlayerManager
    {
       
        public void DisplayAllPlayers()
        {
            string constr="User ID =sa;password=examlyMssql@123;server=localhost;Database=DbName;trusted_connection=false;Persist Security Info=False;Encrypt=False";
            SqlConnection con=new SqlConnection(constr);
            SqlCommand cmd=new SqlCommand("select * from Player",con);
            con.Open();
            SqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Age"]} {reader["Category"]} {reader["BiddingAmount"]}");
            }
 
        }
        public void AddPlayer(Player p)
        {
            Team T=new Team();
            T.Players.Add(p);
 
        }
        public void DeletePlayer(int id)
        {
            Player p=new Player();
            var data=p.Find(id);
            p.Remove(data);
           
 
           
        }
        public void EditPlayer()
        {
           
        }
        public void ListPlayers()
        {
           
        }
        public void FindPlayer()
        {
           
        }
       
 
        public void AddPlayerToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Player VALUES (@Id, @Name, @Age, @Category,@BiddingAmount)";
 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Player.Id);
                    command.Parameters.AddWithValue("@Name", Player.Name);
                    command.Parameters.AddWithValue("@Age", Player.Age);
                    command.Parameters.AddWithValue("@Category", Player.Category);
                    command.Parameters.AddWithValue("@BiddingPrice", Player.BiddingAmount);
                   
                    return (int)command.ExecuteScalar();
                }
            }
        }
       
        // Write your fuctions here...
        // DisplayAllPlayers
        // AddPlayer
        // EditPlayer
        // DeletePlayer
        // ListPlayers
        // FindPlayer
        // DisplayAllPlayers
    }
}
