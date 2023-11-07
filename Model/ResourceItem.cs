using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Starter.Model;

[Serializable()]

internal class ResourceItem 
{
    private string url;
    private string displayName;

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public string DisplayName
    {
        get { return displayName; }
        set { displayName = value; }
    }
}
