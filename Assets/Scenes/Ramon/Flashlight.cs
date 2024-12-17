using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public new Light light; // Referencia a la luz
    public bool isOn = false; // Estado de la linterna

    public Canvas bara; // Canvas que contiene la barra
    public LightBar lightBarScript; // Referencia al script LightBar para controlar la animación

    void Update()
    {
        // Habilitar o deshabilitar la luz
        GetComponent<Light>().enabled = isOn;

        // Mostrar u ocultar el canvas según el estado de la linterna
        bara.gameObject.SetActive(isOn);

        if (isOn)
        {
            // Si la linterna está encendida, asegurarnos de que la animación está activa
            if (!LeanTween.isTweening(lightBarScript.bar))
            {
                lightBarScript.AnimatedBar();
            }
        }
        else
        {
            // Si la linterna está apagada, detener la animación
            LeanTween.pauseAll(); // Alternativamente puedes pausar solo el tween específico
        }
    }

    public void ToggleLight()
    {
        // Cambiar el estado de la linterna
        isOn = !isOn;
    }
}
