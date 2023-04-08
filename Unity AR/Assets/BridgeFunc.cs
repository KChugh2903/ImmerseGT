using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeFunc : MonoBehaviour
{
    public Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        GameObject taggedPointLight = GameObject.FindWithTag("PointLight3");
        // Debug.Log("Hello" + tagged);

        if (taggedPointLight != null){
            pointLight = taggedPointLight.GetComponent<Light>();
        } else{
            Debug.LogError("Could not find game object with tag 'PointLight3'");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Turn on the point light
        pointLight.enabled = true;
        
        // Wait for 3 seconds before turning off the point light
        // StartCoroutine(TurnOffLight(0.5f));
    }
}
