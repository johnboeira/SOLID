using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating.ConsoleApp;

public class FilePolicySource
{
    public string GetPolicyFromSource()
    {
        return File.ReadAllText("policy.json");
    }
}