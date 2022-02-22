using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{
    public void ResizeCube(float sizeMultiplier)
    {
        transform.localScale = sizeMultiplier * Vector3.one;
    }

    private void Start()
    {
        /*
        slider.value = 0f;
        sliderScript.minalue = 0f;
        slider.interectable = false;
        */
    }
}