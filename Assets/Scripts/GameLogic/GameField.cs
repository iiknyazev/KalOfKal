﻿using System;

public class GameField
{
    public readonly int FieldSize;
    public IFieldItem[,] Field { get; private set; }

    public GameField(IFieldItem[,] field)
    {
        Field = field;
        FieldSize = Field.GetLength(0);
    }

    public GameField(int fieldSize, Func<int, IFieldItem[,]> initAlgorithm)
    {
        FieldSize = fieldSize;
        Field = initAlgorithm(FieldSize);
    }

    public static IFieldItem[,] InitEmptyField(int fieldSize)
    {
        var field = new IFieldItem[fieldSize, fieldSize];
        
        for (int i = 0; i < fieldSize; i++)
        {
            for (int j = 0; j < fieldSize; j++)
            {
                field[i, j] = new Empty();
            }
        }
        
        return field;
    }
    
    public void Move(IMove move) => Field = move.Move();
}
