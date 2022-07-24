using System.Net.NetworkInformation;
using System.Diagnostics;

namespace MetricChanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface[] array = allNetworkInterfaces;
            foreach (NetworkInterface networkInterface in array)
            {
                count++;
                if (networkInterface.Description.Contains("CP-TAP-Windows Adapter V9"))
                    Process.Start("CMD.exe", "/c netsh.exe interface ipv4 set interface " + networkInterface.Name + " metric=" + count);
            }
        }
    }
}
