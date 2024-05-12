using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private MyEnums.TileType tileType;
    public bool isOccupied = false;
    public void SetOccupied(bool occupied)
    {
        isOccupied = occupied;
    }

    public bool IsOccupied()
    {
        return isOccupied;
    }
    
}
