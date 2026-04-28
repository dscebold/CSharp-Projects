namespace BeginnerLearning;

public abstract class Pet(string firstName)
{
    public string firstName { get; } = firstName;

    public abstract string makeNoise(); 
    
    public override string ToString() => $"{firstName} and I am a {GetType().Name} and I {makeNoise()}";

}