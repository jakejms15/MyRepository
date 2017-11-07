using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHolder : MonoBehaviour {

    // Use this for initialization

    public Text myText;
    public InputField myField;
    int num1 = 0;
    int num2 = 0;

    System.Random rand = new System.Random(); //The Random class found in the system library.
    Random unityRand = new Random(); //The Random class found in the UnityEngine Library.
  

    void Start () {
        StartGame();
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    public void GetAnswer()
    {
        int multiplicationAns = num1 * num2;

        int userAnswer = 0;
        userAnswer = System.Convert.ToInt32(myField.text); //Read(geT) - fetching the text 

        if (userAnswer == multiplicationAns)
        {
            print("Correct Answer");
            StartGame();
        }

        else
        {
            print("Incorrect Answer");
        }

    }
    void StartGame()
    {
        myField.text = "";
        num1 = rand.Next(1, 11);
        num2 = Random.Range(1, 11);

        myText.text = "What is " + num1 + "x" + num2 + "?"; //Write(set) - changing the text 
    }
}
