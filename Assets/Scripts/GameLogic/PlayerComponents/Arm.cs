using System;
using System.Linq;
using System.Collections.Generic;

public class Arm
{
    public const int ArmSize = 3;
    public List<IDrawingCard> DrawingCards { get; private set; }
    public Arm()
    {
        DrawingCards = Enumerable
            .Repeat<IDrawingCard>(null, ArmSize)
            .ToList();
        FillArm();
    }

    public IDrawingCard GetDrawingCard() 
        => GameManager.Instance.Deck.GiveOneCard();

    public void FillArm()
    {
        for (int i = 0; i < ArmSize; i++)
        {
            if (DrawingCards[i] == null)
                DrawingCards[i] = GetDrawingCard();
        }
    }

    public IMove DrawCard(int index)
    {
        if (index < 0 || index >= ArmSize)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        var card = DrawingCards[index];
        DrawingCards[index] = null;

        return card.Draw();
    }
}