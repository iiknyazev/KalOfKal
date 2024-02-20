using Newtonsoft.Json;
using System.IO;
using System;
using UnityEngine;
using SFB;

public class LoadLevel : MonoBehaviour
{
    public string OpenFile()
    {
        var path = Application.dataPath + "/Levels";
        // Открываем диалоговое окно выбора файла
        string[] paths = StandaloneFileBrowser.OpenFilePanel("Open File", path, "", false);

        // Проверяем, был ли выбран файл
        if (paths != null && paths.Length > 0)
        {
            string filePath = paths[0];
            Debug.Log("Выбран файл: " + filePath);
            return filePath;
        }
        else
        {
            Debug.Log("Отменено пользователем.");
            return null;
        }
    }

    public void Load()
    {
        var path = OpenFile();
        if (path != null)
        {
            IFieldItem[,] gameField = Deserialization(path, new IFieldItem[0, 0], new FieldItemConverter());
            GridManager.LoadGridFromIFieldItem(gameField.GetLength(0), gameField);
        }
        else
        {
            throw new ArgumentNullException(nameof(path));
        }
    }

    public T Deserialization<T>(string path, T value, JsonConverter converter)
    {
        using (StreamReader streamReader = new StreamReader(path))
        {
            string jsonData = streamReader.ReadToEnd();
            if (jsonData == string.Empty)
            {
                throw new ArgumentException("Файл пуст!");
            }
            return JsonConvert.DeserializeObject<T>(jsonData, converter)
                ?? throw new ArgumentException("Данные файла повреждены повреждены.");
        }
    }
}