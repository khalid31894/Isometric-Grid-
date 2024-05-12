using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSelector : MonoBehaviour
{
   public ItemPlacementManager placementManager;

    public GameObject table;

    public void SelectTable()
    {
        placementManager.SelectedTable = table;
    }

}
