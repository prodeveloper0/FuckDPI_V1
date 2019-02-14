using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

public class NicHelper
{
    private List<NetworkInterface> NICs = new List<NetworkInterface>();

    public NetworkInterface this[string name]
    {
        get
        {
            return NICs.FirstOrDefault(x => x.Name.Equals(name));
        }
    }

    public NetworkInterface this[int index]
    {
        get
        {
            return NICs[index];
        }
    }

    public int Count
    {
        get
        {
            return NICs.Count();
        }
    }

    public NetworkInterface[] ToArray()
    {
        return NICs.ToArray();
    }

    public string[] ToNameArray()
    {
        return Array.ConvertAll(NICs.ToArray(), item => item.Name);
    }

    public NicHelper()
    {
        Refresh();
    }

    public void Refresh()
    {
        var nics = NetworkInterface.GetAllNetworkInterfaces();
        NICs.Clear();
        NICs.AddRange(nics);
    }
}
