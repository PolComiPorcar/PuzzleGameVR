using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class LightBar : MonoBehaviour
{
    public GameObject bar;
    public int time;
    void Start()
    {
        AnimatedBar();
    }
    void Update()
    {
        
    }
    public void AnimatedBar()
    {
        LeanTween.scaleX(bar, 1, time);
    }
}
