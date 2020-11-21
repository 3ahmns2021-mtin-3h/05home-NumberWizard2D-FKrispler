using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    public TextMeshProUGUI guessText;
    public GameObject buttonEqual;
    public GameObject buttonHigher;
    public GameObject buttonLower;
    public GameObject buttonNewgame;

    int min = 1;
    int max = 200;
    int guess;

    

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }


    private void NextGuess()
    {
        guess = (min + max) / 2;
        // Debug.Log("Guess" + guess);
        guessText.text = guess.ToString();

    }

    public void Lower()
    {
        max = guess - 1;
        NextGuess();
    }

    public void Higher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void Equal()
    {
        buttonEqual.SetActive(false);
        buttonHigher.SetActive(false);
        buttonLower.SetActive(false);
        buttonNewgame.SetActive(true);
    }

    public void Restart()
    {
        min = 1;
        max = 200;
        NextGuess();
        buttonEqual.SetActive(true);
        buttonHigher.SetActive(true);
        buttonLower.SetActive(true);
        buttonNewgame.SetActive(false);
    }
}
