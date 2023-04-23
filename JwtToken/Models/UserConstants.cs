namespace JwtToken.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="erencem",Password="admin1",Role="Admin"}
            };
    }
}
