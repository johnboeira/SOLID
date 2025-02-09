using System;

namespace Rating.ConsoleApp.Raters;

public class RaterFactory
{
    public Rater Create(Policy policy, IRatingContext context)
    {
        try
        {
            return (Rater)Activator.CreateInstance(
                Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                    new object[] { context });
        }
        catch
        {
            return new UnknownPolicyRater(context);
        }
    }
}