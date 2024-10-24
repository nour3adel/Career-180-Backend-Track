namespace FTPclient
{
    public enum NicType
    {
        Ethernet,
        TokenRing
    }
    public class NIC
    {
        private static NIC instance;
        public string Manufacture { get; private set; }
        public string MacAddress { get; private set; }
        public NicType Type { get; private set; }

        private NIC(string manufacture, string macAddress, NicType type)
        {
            Manufacture = manufacture;
            MacAddress = macAddress;
            Type = type;
        }

        public static NIC GetInstance(string manufacture, string macAddress, NicType type)
        {
            if (instance == null)
            {
                instance = new NIC(manufacture, macAddress, type);
            }
            else
            {
                Console.WriteLine("Error: An instance of NIC already exists. Cannot create another one.");
            }
            return instance;
        }

        public override string ToString()
        {
            return $"Manufacture: {Manufacture}, MAC Address: {MacAddress}, Type: {Type}";
        }

    }
}
