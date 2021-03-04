namespace LoginRESTfulAPI.BLL
{
    public class LoginDao
    {
        public bool IsRegistered(string user, string password)
        {
            var connection = Program.Database.Connection;
            var query = connection.CreateCommand();
            query.CommandText = "SELECT * FROM `login` WHERE `user`=@user AND `password`=@password";
            query.Parameters.AddWithValue("@user", user);
            query.Parameters.AddWithValue("@password", password);

            using var reader = query.ExecuteReader();
            return reader.HasRows;
        }
    }
}
