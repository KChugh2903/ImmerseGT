using UnityEngine;
using UnityEngine.UI;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 mousePos;
    private Vector3 startMousePos;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lr.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 0f));
        }

        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lr.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0f));
        }
    }
}
