using System;
using System.Net.NetworkInformation;
namespace TMS_Gate.Models
{
    public class Networking
    {
        public static bool IsInternetConnected()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 3000); // Google's public DNS
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking internet connectivity: {ex.Message}");
                return false;
            }
        }

    }
}
