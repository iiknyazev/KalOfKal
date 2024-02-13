using System;
using System.Collections.Generic;

public class GameManager
{
    public readonly int FieldSize;
    public IFieldItem[,] Field;
    public List<IDrawingCard> DrawingCardsDeck;
    public List<IArtifact> ArtifactsDeck;
    
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
        FieldSize = 7;
        IInitAlgorithm initAlgorithm = null;

        Field = InitField(initAlgorithm);
        DrawingCardsDeck = GetNewDrawingCardDeck();
        ArtifactsDeck = GetNewArtefactDeck();
    }

    public void Move(ICharacter character) => Field = character.Move();

    public IFieldItem[,] InitField(IInitAlgorithm initAlgorithm) 
        => initAlgorithm.InitField();

    public List<IDrawingCard> GetNewDrawingCardDeck()
    {
        throw new NotImplementedException();
    }
    
    public List<IArtifact> GetNewArtefactDeck()
    {
        throw new NotImplementedException();
    }
}