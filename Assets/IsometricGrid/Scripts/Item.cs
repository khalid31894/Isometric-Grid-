using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int area=0;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private MyEnums.TileType placableOnTile;
    private void OnEnable()
    {
        spriteRenderer.sortingOrder = Mathf.RoundToInt(-transform.position.y * 100);

    }
}
