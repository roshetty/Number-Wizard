using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    // Use this for initialization
    int max;
    int min ;
    int guess;
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        
        print("==============================================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head and don't tell me");

        print("The highest number u can pick is " + max);
        print("The lowest number u can pick is " + min);

        print("Is the number higher or lower than" + guess + "?");
        print("Up = higher , down = lower, return for equal");
        max++;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than" + guess);
        print("Up = higher , down = lower, return for equal");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess(); 
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I Won!");
        }

    }
}
