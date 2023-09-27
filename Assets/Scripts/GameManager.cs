using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int currentScore;
    private int currentCombo;
    private int currentErrors;

    public UnityEvent OnScoreChanged;
    public UnityEvent OnComboChanged;
    public UnityEvent OnErrorsChanged;

    public int GetScore() {  return currentScore; }
    public int GetCombo() { return currentCombo; }
    public int GetErrors() { return currentErrors; }

    public void CorrectThrow()
    {
        currentScore = currentScore + 10;
        OnScoreChanged?.Invoke();

        currentCombo = currentCombo + 1;
        OnComboChanged?.Invoke();
    }
    
    public void WrongThrow()
    {
        currentCombo = 0;
        OnComboChanged?.Invoke();

        currentErrors = currentErrors + 1;
        OnErrorsChanged?.Invoke();
    }

    // Awake is called once when an object is created
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogWarning("There is more than one istance of GameManager!");
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        currentScore = 0;
        OnScoreChanged?.Invoke();

        currentCombo = 0;
        OnComboChanged?.Invoke();
        
        currentErrors = 0;
        OnErrorsChanged?.Invoke();
    }
}
