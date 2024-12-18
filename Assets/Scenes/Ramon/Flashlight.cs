using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class Flashlight : MonoBehaviour
{
    //public new Light light;
    public bool isOn = false;

    public GameObject bar;
    public int time;
    private int tweenId;
    private bool first = true;

    private void Start()
    {
        AnimatedBar();
    }
    void Update()
    {
        // Habilitar o deshabilitar la luz
        transform.GetChild(1).gameObject.GetComponent<Light>().enabled = isOn;

        bar.gameObject.SetActive(isOn);

        if (first && isOn)
        {
            AnimatedBar();
            first = false;
        }
        else if (isOn)
        {
            ResumeAnimation();
        }
        else
        {
            PauseAnimation();
        }
    }

    public void ToggleLight()
    {
        isOn = !isOn;
    }
    public void AnimatedBar()
    {
        tweenId = LeanTween.scaleX(bar.transform.GetChild(0).gameObject, 1, time).id;
    }

    public void PauseAnimation()
    {
        LeanTween.pause(tweenId);
    }

    public void ResumeAnimation()
    {
        LeanTween.resume(tweenId);
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.name.StartsWith("AA_Battery"))
        {
            RestoreBar();
            Destroy(other.gameObject);
        }
    }
    private void RestoreBar()
    {
        if (LeanTween.isTweening(tweenId))
        {
            LeanTween.cancel(tweenId);
        }
        bar.transform.GetChild(1).localScale = new Vector3(1, bar.transform.GetChild(1).localScale.y, bar.transform.GetChild(1).localScale.z);
        AnimatedBar();
    }

}
