using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] LayerMask layerMask;

    [SerializeField] Texture2D texture2D;

    void Start()
    {
        Cursor.SetCursor(texture2D,new Vector2(0,0),CursorMode.Auto);
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity,layerMask))
            {
                if(raycastHit.collider.gameObject.GetComponent<IInteractable>() != null)
                {
                    raycastHit.collider.gameObject.GetComponent<IInteractable>().Interact();
                }
            }
        }
    }
    void OnDrawGizmos()
    {
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 0.5f);
    }
}
