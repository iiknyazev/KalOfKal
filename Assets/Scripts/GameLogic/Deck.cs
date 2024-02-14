using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    public readonly HashSet<IDrawingCard> Pull;
    public Stack<IDrawingCard> DrawingCards { get; private set; }

    public Deck()
    {
        Pull = new HashSet<IDrawingCard>()
        {
            new DestroyBox(),
            new PlusTwoStars(),
            new PullTheBox(),
            new PutTheBox(),
            new SetDynamite(),
            new SpawnMucus()
        };

        DrawingCards = GenerateDeck();
    }

    public Stack<IDrawingCard> GenerateDeck()
    {
        var cardsCount = Pull
            .Aggregate(0, (cardsCount, card) => cardsCount += (int)card.Rate);

        var deck = Enumerable
            .Repeat<IDrawingCard>(null, cardsCount)
            .ToList();

        Random random = new Random();

        foreach (var card in Pull)
        {
            for (int i = 0; i < (int)card.Rate; i++)
            {
                while (true)
                {
                    int index = random.Next(cardsCount);
                    if (deck[index] == null)
                    {
                        deck[index] = card;
                        break;
                    }
                }
            }
        }

        return new Stack<IDrawingCard>(deck);
    }

    public IDrawingCard GiveOneCard()
    {
        if (DrawingCards.Count == 0)
        {
            DrawingCards = GenerateDeck();
        }
        return DrawingCards.Pop();
    }
}