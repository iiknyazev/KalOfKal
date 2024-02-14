using System;
using System.Collections.Generic;
using System.Linq;

public class Shop
{
    public readonly HashSet<IArtifact> Pull;

    private static Shop instance;
    public static Shop Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Shop();
            }
            return instance;
        }
    }

    private Shop()
    {
        Pull = new HashSet<IArtifact>()
        {
            new DeathbedTeleport(),
            new InvisibilityCloak(),
            new MovingTeleportGate(),
            new RandomPermutation()
        };
    }

    public List<IArtifact> GenerateArtifacts(int count)
    {
        if (count < 0 || count > Pull.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        var cardsCount = Pull
            .Aggregate(0, (cardsCount, card) => cardsCount += (int)card.Rate);

        var artefacts = Pull
            .SelectMany(card => Enumerable
                .Repeat(card, (int)card.Rate))
            .ToList();

        var random = new Random();
        var shop = new List<IArtifact>();
        var indexes = new HashSet<int>();

        while (shop.Count < count)
        {
            var index = random.Next(cardsCount);
            if (!indexes.Contains(index))
            {
                shop.Add(artefacts[index]);
                indexes.Add(index);
            }
        }

        return artefacts;
    }
}