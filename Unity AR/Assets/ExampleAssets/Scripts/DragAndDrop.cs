using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePos;
    public Camera camera;
    // Start is called before the first frame update

    void Start(){
        GetMousePos();
    }

    void Update(){
        Debug.Log("mousePos is: " + mousePos);
    }

    private Vector3 GetMousePos()
    {
        return camera.WorldToScreenPoint(transform.position);
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        mousePos = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = camera.ScreenToWorldPoint(Input.mousePosition - mousePos);
    }

}