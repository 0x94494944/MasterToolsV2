using DiscordRPC;

namespace MasterTools
{
    public class DiscordRpc
    {
        public static void LoginDiscordRPC()
        {
            try
            {
                client = new DiscordRpcClient("");
                client.Initialize();
                client.SetPresence(new RichPresence
                {
                    Details = "In Master Tools V2",
                    Timestamps = Timestamps.Now,
                    State = "Logged in as " + User.Username,
                    Assets = new Assets
                    {
                        LargeImageKey = "main",
                        LargeImageText = "Master Multi Tool",
                        SmallImageKey = "logo"
                    }
                });
            }
            catch
            {
            }
        }
        public static void LoginWait()
        {
            try
            {
                client = new DiscordRpcClient("");
                client.Initialize();
                client.SetPresence(new RichPresence
                {
                    Details = "IP Multi Tool v2",
                    //Timestamps = Timestamps.Now,
                    State = "Login Page",
                    Assets = new Assets
                    {
                        LargeImageKey = "main",
                        LargeImageText = "Master Multi Tool",
                        SmallImageKey = "logo"
                    }
                });
            }
            catch
            {
            }
        }
        public static void StopDiscordRPC()
        {
            try
            {
                client.Dispose();
            }
            catch
            {
            }
        }
        public static DiscordRpcClient client;
    }
}