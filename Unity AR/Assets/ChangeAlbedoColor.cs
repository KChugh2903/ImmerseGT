using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlbedoColor : MonoBehaviour
{
    public Color lightColor;
    public Color darkColor;

    new private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        ApplyHalfHalfColor();
    }

    private void ApplyHalfHalfColor()
    {
        Material material = renderer.material;

        material.SetColor("_Color", lightColor);
        material.SetFloat("_Glossiness", 0.6f);

        material.SetColor("_Color2", darkColor);
        material.SetFloat("_Glossiness2", 0.6f);

        // Set the blend mode to mix the colors evenly
        material.SetFloat("_Blend", 0.5f);
    }


}
