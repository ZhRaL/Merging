using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{

    float XPosition;
    float YPosition;
    Vector3 OffSet;
    Camera camera;
    bool Dragging;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        if(Dragging)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
            transform.position = camera.ScreenToWorldPoint(position + new Vector3(OffSet.x, OffSet.y));
        }
        
    }

    private void OnMouseDown()
    {
        if(!Dragging)
        {
            BeginDrag();
        }
    }
    private void OnMouseUp()
    {
        EndDrag();
    }

   void  BeginDrag()
    {
        Dragging = true;
        OffSet = camera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }

    void EndDrag()
    {
        Dragging = false;
    }
}
