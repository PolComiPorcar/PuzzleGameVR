using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleMan : MonoBehaviour
{
    public static PuzzleMan Instance; // Singleton para facilitar el acceso

    private int openDrawers = 0;  // Contador de cajones abiertos
    private bool chickenCorrect = false;  // Estado del pollo
    private bool puzzleComplete = false;  // Estado general del puzzle
    [SerializeField] private UnityEvent onPuzzleCompleted;

    private void Awake()
    {
        // Implementa Singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateDrawerState(bool isOpen)
    {
        openDrawers += isOpen ? 1 : -1;  // Incrementa o decrementa el contador
        CheckPuzzleState();
    }

    public void UpdateChickenState(bool isCorrect)
    {
        chickenCorrect = isCorrect;
        CheckPuzzleState();
    }

    private void CheckPuzzleState()
    {
        // Verifica si los 4 cajones están abiertos y el pollo está en la rotación correcta
        puzzleComplete = (openDrawers == 4 && chickenCorrect);
        if (puzzleComplete)
        {
            Debug.Log("¡El puzzle está completo!");
            onPuzzleCompleted.Invoke();
        }
    }
}
