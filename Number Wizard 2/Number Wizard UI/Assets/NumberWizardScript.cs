using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    public Text compGuess;
    public Text numOfGuess;
    int min = 1;
    int max = 1000;
    int guess = 500;
    int numOfGuesses = 5;

    void StartGame()
    {
        min = 1;
        max = 1000;

        NextGuess();
    }

    // Use this for initialization
    void Start() {
        StartGame();
    }


    // Update is called once per frame
    void Update() {
        if (numOfGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }
        numOfGuess.text = numOfGuesses.ToString();
    }

    void NextGuess()
    {
        /*
         This method always generates a new guess and prints it in the console window
         * */

        //guess = (min + max) / 2;

        System.Random rand = new System.Random(); //Created the copy of the random class so that I can use its methods.
        guess = rand.Next(min, (max+1)); // Next is a method which generates a random value between the specified range.

        compGuess.text = guess + "?";
    }

    public void GuessHigher()
    {
        min = guess + 1;
        NextGuess();
        numOfGuesses = numOfGuesses - 1;
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
        numOfGuesses = numOfGuesses - 1;
    }
    
    

}
