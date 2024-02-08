using HotelManagementSystem.BL;
using System.Collections.Generic;
using System.IO;

namespace HotelManagementSystem.DL
{
    class CredentialsDL
    {
        public static List<Credentials> credentials = new List<Credentials>();

        public static void AddToList(Credentials c)
        {
            credentials.Add(c);
        }


        public static void CredentialsFile()
        {
            string path = "credentials.txt";

            StreamWriter myFile = new StreamWriter(path, true);

            Credentials info;
            info = credentials[credentials.Count - 1];
            myFile.WriteLine(info.GetUserName() + "," + info.GetPassword() + "," + info.GetRole());

            myFile.Flush();
            myFile.Close();
        }

        public static void CredentialsFileRead()
        {
            string path = "credentials.txt";

            if (File.Exists(path))
            {
                string record;
                StreamReader myFile = new StreamReader(path);
                while (!myFile.EndOfStream)
                {
                    record = myFile.ReadLine();
                    string[] seperatedData = record.Split(',');
                    string userName = seperatedData[0];
                    string password = seperatedData[1];
                    string role = seperatedData[2];
                    Credentials c = new Credentials(userName, password, role);
                    AddToList(c);
                }
                myFile.Close();
            }
        }
    }
}
