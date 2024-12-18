using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenRotate : MonoBehaviour
{
    private float totalRotation = 0f;  // Variable para guardar el total de grados girados.
    private bool CorrectRotation = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Rotate()
    {
        // Gira 90 grados hacia la derecha.
        transform.Rotate(0, 90, 0);  // Rotación en el eje Y (hacia la derecha).

        // Aumenta el total de grados girados.
        totalRotation += 90;

        // Si ha girado 360 grados, reinicia la rotación.
        if (totalRotation >= 360)
        {
            totalRotation = 0;  // Restablece el contador de rotación.
        }
        if (totalRotation == 270)
        {
            CorrectRotation = true;
            PuzzleMan.Instance.UpdateChickenState(true);
        }
        else
        {
            CorrectRotation = false;
            PuzzleMan.Instance.UpdateChickenState(false);
        }
    }
}
