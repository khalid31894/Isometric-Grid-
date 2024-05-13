using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    public int area=0;
    public MyEnums.TileType placableOnTile;
    private void OnEnable()
    {
        MangeItemLayering();
    }

    private void MangeItemLayering()
    {
        spriteRenderer.sortingOrder = Mathf.RoundToInt(-transform.position.y * 100);

    }
}
