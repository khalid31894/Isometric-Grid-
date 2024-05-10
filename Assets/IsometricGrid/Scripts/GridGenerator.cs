using Newtonsoft.Json;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class GridGenerator : MonoBehaviour
    {

        [SerializeField] private GameObject[] tile;
        [SerializeField] private TilesList _TilesList_SO;


        [Button]
        void GenerateGrid()
        {


        TerrainLoader loader = new TerrainLoader();
        Terrain grid_2D = loader.LoadTerrain();

            for (int i = 0; i < grid_2D.TerrainGrid.Count; i++)
            {
                for (int j = 0; j < grid_2D.TerrainGrid[i].Count; j++)
                {
                    GameObject newtile = Instantiate(tile[grid_2D.TerrainGrid[i][j].TileType], transform);

                    newtile.transform.position = new Vector2(i, j);
                    newtile.name = i + "," + j;
                     _TilesList_SO.tiles.Add(newtile.GetComponent<Tile>());
                }
            }
        }




    }
    





