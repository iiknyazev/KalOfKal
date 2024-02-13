using System.Collections.Generic;

public class Player
{
    public readonly string Name;
    public readonly ICharacter Character;
    public List<ICard> Deck;
    public IArtifact Artefact;
}