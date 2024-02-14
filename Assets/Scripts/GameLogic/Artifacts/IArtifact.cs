using System;

public enum ArtifactRate
{
    Ordinary = 4,
    Rare = 3,
    Epic = 2,
    Legendary = 1
}

public interface IArtifact : ICard
{
    public EventHandler PossibilityOfDrawHasBeenActivated { get; set; }

    public int StarsPrice { get; }

    public ArtifactRate Rate { get; }

    void Draw();
}