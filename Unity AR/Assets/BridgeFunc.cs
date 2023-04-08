using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeFunc : MonoBehaviour
{
    public Light pointLight1;
    public Light pointLight2;
    public Light pointLight3;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = new GameObject();
        GameObject taggedPointLight1 = GameObject.FindWithTag("PointLight1");
        GameObject taggedPointLight2 = GameObject.FindWithTag("PointLight2");
        GameObject taggedPointLight3 = GameObject.FindWithTag("PointLight3");


        // Debug.Log("Hello" + tagged);
        pointLight1 = taggedPointLight1.GetComponent<Light>();
        pointLight2 = taggedPointLight2.GetComponent<Light>();
        pointLight3 = taggedPointLight3.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "Bridge1") {
            pointLight1.enabled = true;
            pointLight2.enabled = false;
            pointLight3.enabled = false;
        }
        else if (gameObject.name == "Bridge2") {
            pointLight1.enabled = false;
            pointLight2.enabled = true;
            pointLight3.enabled = false;
        }
        else if (gameObject.name == "Bridge3") {
            pointLight1.enabled = false;
            pointLight2.enabled = false;
            pointLight3.enabled = true;
        }
    }
}
