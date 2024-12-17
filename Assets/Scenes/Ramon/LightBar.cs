using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class LightBar : MonoBehaviour
{
    public GameObject bar;
    public int time;
    private int tweenId;

    void Start()
    {
    
    }

    void Update()
    {
        
    }

    public void AnimatedBar()
    {
        tweenId = LeanTween.scaleX(bar, 1, time).id;
    }

    public void PauseAnimation()
    {
        LeanTween.pause(tweenId);
    }

    public void ResumeAnimation()
    {
        LeanTween.resume(tweenId);
    }
}
