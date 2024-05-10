using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{

    public string jsonFilePath;
    private TerrainData _terrainData;

    void Start()
    {
        LoadTerrainJSON();
    }

    public void LoadTerrainJSON()
    {
        // Load the JSON file as a TextAsset
        TextAsset jsonTextAsset = Resources.Load<TextAsset>(jsonFilePath);
        if (jsonTextAsset == null)
        {
            Debug.LogError("Failed to load JSON file at path: " + jsonFilePath);
            return;
        }

        // Deserialize JSON content using JsonUtility
        string jsonContent = jsonTextAsset.text;
        if (string.IsNullOrEmpty(jsonContent))
        {
            Debug.LogError("JSON file is empty or malformed");
            return;
        }

        _terrainData = JsonUtility.FromJson<TerrainData>(jsonContent);

        // Now you can use '_terrainData' as your loaded JSON object
        Debug.Log("Loaded JSON: " + _terrainData);
    }
}



