using System;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private float xShift, yShift, cellSize;
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private int size;

    public static GameObject[,] Grid { get; private set; }

    private void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        Grid = new GameObject[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Vector3 spawnPos = new Vector3(j * cellSize - xShift, i * cellSize - yShift, 0);
                GameObject cell = Instantiate(cellPrefab, spawnPos, Quaternion.identity);
                cell.transform.parent = transform;
                cell.AddComponent<CellClickHandler>();
                cell.AddComponent<BoxCollider2D>();
                Grid[i, j] = cell;
            }
        }
    }

    public static void LoadGridFromIFieldItem(int _size, IFieldItem[,] gameField)
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                foreach (var item in CellColorManager.ColorToCell)
                {
                    if (item.Value.GetType() == gameField[i, j].GetType())
                    {
                        Grid[i, j].GetComponent<SpriteRenderer>().color = item.Key;
                    }
                }
            }
        }
    }
}
