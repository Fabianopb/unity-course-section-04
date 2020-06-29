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
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        stringGuess.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

}
