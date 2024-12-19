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
    public UnityEvent OnPuzzleCompleted => onPuzzleCompleted;
    public SoundJordi SoundGenerator;
    public Haptic vibracion;

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
        if(isOpen){
            openDrawers +=1;
            SoundGenerator.PlaySound1();
            vibracion.HapticImpulse(Haptic.Contol.left, 0.5f, 0.1f);
            vibracion.HapticImpulse(Haptic.Contol.right, 0.5f, 0.1f);
        }
        else{
            openDrawers -=1;
            SoundGenerator.PlaySound2();
        }
       // openDrawers += isOpen ? 1 : -1;  // Incresmenta o decrementa el contador
        CheckPuzzleState();
    }

    public void UpdateChickenState(bool isCorrect)
    {
        chickenCorrect = isCorrect;
        CheckPuzzleState();
    }

    private void CheckPuzzleState()
    {
        // Verifica si los 4 cajones est�n abiertos y el pollo est� en la rotaci�n correcta
        puzzleComplete = (openDrawers == 4 && chickenCorrect);
        if (puzzleComplete)
        {
            Debug.Log("�El puzzle est� completo!");
            onPuzzleCompleted.Invoke();
        }
    }
}
