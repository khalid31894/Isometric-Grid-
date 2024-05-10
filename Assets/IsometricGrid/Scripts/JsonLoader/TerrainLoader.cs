using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainLoader 
{
    public string jsonFlePath = "data";
    public Terrain LoadTerrain()
    {
        TextAsset jsonTextAsset = Resources.Load<TextAsset>(jsonFlePath);
        if (jsonTextAsset == null)
        {
            Debug.LogError("Loading Failed ");
            return null;
        }

        string jsonContent = jsonTextAsset.text;
        if (string.IsNullOrEmpty(jsonContent))
        {
            Debug.LogError("File is IsNullOrEmpty");
            return null;
        }

        Terrain _terrain = JsonConvert.DeserializeObject<Terrain>(jsonContent);


        Debug.Log("LoadJSON: " + _terrain);

        return _terrain;
    }
}