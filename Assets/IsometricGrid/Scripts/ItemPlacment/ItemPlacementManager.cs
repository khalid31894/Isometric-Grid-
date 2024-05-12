using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacementManager : MonoBehaviour
{
    [SerializeField] private List<Tile> tiles;
    [SerializeField] private GameObject table_0;
    [SerializeField] private GameObject table_1;

    public GameObject SelectedTable;
    public static Action <Tile> PlaceItem_Action;

    private void IsPlaceable(Tile tile)
    {
        if (!tile.isOccupied)
        {
            Instantiate(SelectedTable, tile.GetComponent<Transform>());
        }
     
        
    }

    private void OnEnable()
    {
        PlaceItem_Action += IsPlaceable;
    }
    private void OnDisable()
    {
        PlaceItem_Action -= IsPlaceable;

    }

}
