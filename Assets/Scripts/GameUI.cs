using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] TMP_Text scoreLabel;
    [SerializeField] TMP_Text comboLabel;
    [SerializeField] TMP_Text errorsLabel;

    public void UpdateScore()
    {
        int score = GameManager.Instance.GetScore();
        scoreLabel.text = "Score: " + score.ToString();
    }
    
    public void UpdateCombo()
    {
        int combo = GameManager.Instance.GetCombo();
        comboLabel.text = "Combo: " + combo.ToString();
    }

    public void UpdateErrors()
    {
        int errors = GameManager.Instance.GetErrors();
        errorsLabel.text = "Errors: " + errors.ToString();
    }
}
