﻿namespace Rating.ConsoleApp;

public class FilePolicySource
{
    public string GetPolicyFromSource()
    {
        return File.ReadAllText("policy.json");
    }
}