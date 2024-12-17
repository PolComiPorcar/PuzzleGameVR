using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI textoVictoria;

    void Start()
    {
        textoVictoria.enabled = false;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que entra tiene la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Has ganado!");

            if (textoVictoria != null)
            {
                textoVictoria.enabled = true;
            }
        }
    }
}
