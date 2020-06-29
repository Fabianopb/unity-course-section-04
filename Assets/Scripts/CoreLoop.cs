using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoreLoop : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] public TextMeshProUGUI stringGuess;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        stringGuess.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

}
