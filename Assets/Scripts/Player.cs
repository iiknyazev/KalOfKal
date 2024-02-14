using System.Collections.Generic;

public class Player
{
    public readonly string Name;
    public readonly ICharacter Character;
    // Arm
    // ActiveArtifact

    public Player(string name, ICharacter character)
    {
        Name = name;
        Character = character;
    }
}