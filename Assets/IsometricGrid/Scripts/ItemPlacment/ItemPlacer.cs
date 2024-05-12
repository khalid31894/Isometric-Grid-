using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    public  Camera mainCamera;

    
    //private MouseInput mouseInput;
    //private void Awake()
    //{
    //    mouseInput = new MouseInput();
    //}

    //private void OnEnable()
    //{
    //    mouseInput.Enable();
    //}
    //private void OnDisable()
    //{
    //    mouseInput.Disable();   
    //}

    //private void Start()
    //{
    //    mouseInput.Mouse.MouseClick.performed += ctx => MouseClick(ctx.ReadValue<Vector2>());
    //}

    //private void MouseClick(Vector2 pos)
    //{  
    //    Debug.Log(pos);
    //}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("buttonPressed");
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, Mathf.Infinity, LayerMask.GetMask("Grid"));
            if (hit.collider != null)
            {
                //Debug.Log("Object selected: " + hit.collider.gameObject.name);

                ItemPlacementManager.PlaceItem_Action?.Invoke(hit.collider.gameObject.GetComponent<Tile>());
            }
        }
    }


}


