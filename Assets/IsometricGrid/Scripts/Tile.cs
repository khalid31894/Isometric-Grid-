using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private MyEnums.TileType tileType;
    [SerializeField] private SpriteRenderer tileSprite;
    [SerializeField] private bool isOccupied = false;
    public void SetOccupied(bool occupied)
    {
        isOccupied = occupied;
    }

    public bool IsOccupied()
    {
        return isOccupied;
    }

    public void HighlightTile()
    {
        
    }
}
