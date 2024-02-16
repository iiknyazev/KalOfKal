using SFB;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLevel : MonoBehaviour
{
    public void Save()
    {
        (int rows, int cols) = (GridManager.Grid.GetLength(0), GridManager.Grid.GetLength(1));
        IFieldItem[,] gameField = new IFieldItem[rows,cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                var currentColor = GridManager.Grid[i, j].GetComponent<SpriteRenderer>().color;
                try
                {
                    gameField[i, j] = CellColorManager.ColorToCell[currentColor];
                }
                catch (KeyNotFoundException)
                {
                    Debug.LogError($"���� '{currentColor}' �� ������ � �������.");
                }
            }
        }

        SaveToFile(gameField);
    }

    private void SaveToFile(IFieldItem[,] gameField)
    {
        var path = Application.dataPath + "/Levels";
        // ��������� ���������� ���� ���������� �����
        string filePath = StandaloneFileBrowser.SaveFilePanel("Save File", path, "level", "json");

        // ���������, ��� �� ������ ����
        if (!string.IsNullOrEmpty(filePath))
        {
            // ������� ������ ����
            using (FileStream fileStream = File.Create(filePath)) { }

            // ����������� ������ � ����
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                var json = JsonConvert.SerializeObject(gameField);
                streamWriter.Write(json);
            }
            
            Debug.Log("���� ������� �������� �� ����: " + filePath);
        }
        else
        {
            Debug.Log("�������� �������������.");
        }
    }
}