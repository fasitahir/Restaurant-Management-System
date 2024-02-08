using HotelManagementSystem.DL;

namespace HotelManagementSystem.BL
{
    class SignUp : Credentials
    {
        public bool LogUp(string userName, string password, string role)
        {
            Credentials c = base.IsExist(userName, password);
            if (c == null)
            {
                c = new Credentials();
                if (!c.SetUserName(userName) || !c.SetPassword(password) || !c.SetRole(role))
                {
                    return false;
                }
                else
                {

                    c.SetUserName(userName);
                    c.SetPassword(password);
                    c.SetRole(role);
                    CredentialsDL.AddToList(c);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
