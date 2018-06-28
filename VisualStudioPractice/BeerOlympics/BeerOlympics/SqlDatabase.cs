using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BeerOlympics
{
    public class SqlDatabase : IDatabase
    {
        private readonly string connectionString;

        public SqlDatabase(string cons)
        {
            connectionString = cons;
        }

        public void Create(Contestant contestant)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO Contestants ([name], ind_score, team_name, team_score, fav_obstacle) VALUES (@Name, @IndScore, @TeamName, @TeamScore, @FavObstacle)";
                    com.Parameters.AddWithValue("@Name", contestant.Name);
                    com.Parameters.AddWithValue("@IndScore", contestant.IndScore);
                    com.Parameters.AddWithValue("@TeamName", contestant.TeamName);
                    com.Parameters.AddWithValue("@TeamScore", contestant.TeamScore);
                    com.Parameters.AddWithValue("@FavObstacle", contestant.FavObstacle);
                    com.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "DELETE FROM Contestants WHERE Id = @id";
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Contestant> GetAllContestants()
        {
            throw new NotImplementedException();
        }

        public Contestant Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contestant contestant)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "UPDATE Contestants SET [name] = @Name, ind_score = @IndScore, team_name = @TeamName, team_score = @TeamScore, fav_obstacle = @FavObstacle WHERE Id = @id";
                    com.Parameters.AddWithValue("@Id", contestant.Id);
                    com.Parameters.AddWithValue("@Name", contestant.Name);
                    com.Parameters.AddWithValue("@IndScore", contestant.IndScore);
                    com.Parameters.AddWithValue("@TeamName", contestant.TeamName);
                    com.Parameters.AddWithValue("@TeamScore", contestant.TeamScore);
                    com.Parameters.AddWithValue("@FavObstacle", contestant.FavObstacle);
                    com.ExecuteNonQuery();
                }
            }
        }
    }
}
