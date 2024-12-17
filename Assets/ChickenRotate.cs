using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenRotate : MonoBehaviour
{
    private float totalRotation = 0f;  // Variable para guardar el total de grados girados.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Aquí puedes agregar alguna lógica para llamar la función Rotate cuando sea necesario.
        // Por ejemplo, si se presiona una tecla:
        if (Input.GetKeyDown(KeyCode.R)) // Por ejemplo, cuando se presiona la tecla "R"
        {
            Rotate();
        }
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
    }
}
