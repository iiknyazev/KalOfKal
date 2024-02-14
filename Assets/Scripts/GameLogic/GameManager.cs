using System;
using System.Collections.Generic;

public class GameManager
{
    public GameField GameField { get; private set; }
    public Deck Deck { get; private set; }

    public readonly Player PlayerA, PlayerB;

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    private GameManager()
    {
        GameField = new GameField(7, GameField.InitFieldAlgorithm);
        Deck = new Deck();
        PlayerA = new Player("Vasya", new Orc());
        PlayerB = new Player("Petya", new Goblin());
    }
}