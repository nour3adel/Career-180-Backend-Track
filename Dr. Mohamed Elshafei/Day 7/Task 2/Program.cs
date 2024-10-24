namespace FTPclient
{
    public class Program
    {
        static void Main(string[] args)
        {

            NIC nic1 = NIC.GetInstance("HP", "10:0b:2E:cd:Kf:43", NicType.Ethernet);

            Console.WriteLine(nic1);

            NIC nic2 = NIC.GetInstance("Lenovo", "00:2F:5a:12:68:16", NicType.TokenRing);

            Console.WriteLine(nic2);
        }
    }
}
