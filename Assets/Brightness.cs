using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightness : MonoBehaviour
{
    public float light;
    public Rect SliderLocation;

    void Update()
    {
        RenderSettings.ambientLight = new Color(light, light, light, 1.0f);
    }

    void OnGUI()
    {

        light = GUI.HorizontalSlider(SliderLocation, light, 0, 1.0f);

    }
}
