using System;
using System.Collections.Generic;

public class Player
{
    private static int movePhases = 3, artifactsInShop = 3;
    private int movePhase;
    public readonly string Name;
    public readonly ICharacter Character;
    public int Stars { get; private set; }
    public Arm Arm { get; private set; }
    public ActiveArtifact ActiveArtifact { get; private set; }
    public List<IArtifact> ShopFront { get; private set; }

    public EventHandler MoveWasCompleted;

    public Player(string name, ICharacter character)
    {
        Stars = 0;
        Name = name;
        Character = character;
        movePhase = movePhases;
        Arm = new Arm();
        ActiveArtifact = new ActiveArtifact();
    }

    public void DrawMovePhase(IMove move)
    {
        if (movePhase != 0)
        {
            movePhase--;
            GameManager.Instance.GameField.Move(move);
        }
        else
        {
            movePhase = movePhases;
            // Передача хода
            MoveWasCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

    public List<IArtifact> SetShopFront() 
        => Shop.Instance.GenerateArtifacts(artifactsInShop);

    public IArtifact BuyArtifact(int index)
    {
        if (index < 0 || index > ShopFront.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ShopFront[index].StarsPrice <= Stars)
        {
            Stars -= ShopFront[index].StarsPrice;
            return ShopFront[index];
        }

        return null;
    }
}