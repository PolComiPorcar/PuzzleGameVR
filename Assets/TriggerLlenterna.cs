using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class TriggerLlenterna : MonoBehaviour
{
    public GameObject bar;
    public SoundJordi SoundGenerator;
    public int time;
    public Haptic vibracion;
    private int tweenId;
    private bool first = true;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.name.StartsWith("AA_Battery"))
        {
            vibracion.HapticImpulse(Haptic.Contol.left, 0.3f, 0.1f);
            vibracion.HapticImpulse(Haptic.Contol.right, 0.3f, 0.1f);
            SoundGenerator.PlaySound1();
            RestoreBar();
            Destroy(other.gameObject);
        }
    }
    public void AnimatedBar()
    {
        tweenId = LeanTween.scaleX(bar.transform.GetChild(0).gameObject, 1, time).id;
    }
    private void RestoreBar()
    {
        if (LeanTween.isTweening(tweenId))
        {
            LeanTween.cancel(tweenId);
        }
        bar.transform.GetChild(0).localScale = new Vector3(0, bar.transform.GetChild(0).localScale.y, bar.transform.GetChild(0).localScale.z);
        AnimatedBar();
    }
}
