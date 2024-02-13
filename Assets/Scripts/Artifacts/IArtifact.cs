using System;

public interface IArtifact : ICard
{
    public EventHandler PossibilityOfDrawHasBeenActivated { get; set; }

    void Draw();
}