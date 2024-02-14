using System;

public class RandomPermutation : IArtifact
{
    public string Name => throw new System.NotImplementedException();

    public string Description => throw new System.NotImplementedException();

    public EventHandler PossibilityOfDrawHasBeenActivated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ArtifactRate Rate => ArtifactRate.Ordinary;
    public int StarsPrice => 9;
    public void Draw()
    {
        throw new NotImplementedException();
    }
}
