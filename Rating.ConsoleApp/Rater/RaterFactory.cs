using System;

namespace Rating.ConsoleApp.Rater;

public class RaterFactory
{
    public Rater Create(Policy policy, RatingEngine engine)
    {
        try
        {
            string currentNamespace = typeof(RaterFactory).Namespace;

            return (Rater)Activator.CreateInstance(
                Type.GetType($"{currentNamespace}.{policy.Type}PolicyRater"),
                    new object[] { engine, engine.Logger });
        }
        catch
        {
            return new UnknownPolicyRater(engine, engine.Logger);
        }
    }
}