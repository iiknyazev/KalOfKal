using System;
using System.Collections.Generic;
using System.IO;

public class GameManager
{
    public enum GamePhase
    {
        CharacterSelection,
        CardDistribution,
        MainGame,
        Shop,
        End
    }

    public GamePhase Phase { get; private set; }

    public GameField Field { get; private set; }
    public Deck Deck { get; private set; }

    public Player PlayerA { get; private set; }
    public Player PlayerB { get; private set; }

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
        Deck = new Deck();
    }

    public void InitGameField(string filePath) 
        => Field = new GameField(LoadGameFieldFromFile(filePath));

    public void InitPlayers(string[] names, ICharacter[] characters)
    {
        PlayerA = new Player(names[0], characters[0]);
        PlayerB = new Player(names[1], characters[1]);
    }

    private IFieldItem[,] LoadGameFieldFromFile(string filePath)
        => new LoadLevel().Deserialization(filePath, new IFieldItem[0, 0], new FieldItemConverter());
}