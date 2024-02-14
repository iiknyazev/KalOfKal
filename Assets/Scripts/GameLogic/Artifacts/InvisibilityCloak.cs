using System;

public class InvisibilityCloak : IArtifact
{
    public string Name => throw new System.NotImplementedException();

    public string Description => throw new System.NotImplementedException();

    public EventHandler PossibilityOfDrawHasBeenActivated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ArtifactRate Rate => ArtifactRate.Ordinary;
    public int StarsPrice => 6;
    public void Draw()
    {
        throw new NotImplementedException();
    }
}