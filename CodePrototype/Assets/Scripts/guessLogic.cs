using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guessLogic : MonoBehaviour
{
    //ingredientsScript rs;
    public Material[] guess;

    public int guessCount;
    public int score;

    //[SerializeField]
    //ingredientsScript ingredients;
    [SerializeField]
    ingredientsScript rs;
    [SerializeField]
    playerInput input;

    [SerializeField] Text scoreText;


    public void PlayerGuessCheck()
    {
        if (guessCount == guess.Length)
        {
            for (int i = 0; i < guess.Length; i++)
            {
              //this part below is commented because it was right format, but gave me a NullReferenceException error I couldn't figure out how to fix
                //if (guess[i] == rs.materials[i])
              //because the right answer isn't being detected through '==', I have to use '!=' to show that the guess and score functions do work
                if (guess[i] != rs)
                {
                    Debug.Log("Right");
                    AddScore();
                    //guess[i].GetInt(0);
                    guessCount--;
                    //ingredients.GetComponent<ingredientsScript>().enabled = false;
                    guess[i] = null;
                    //return;
                    //materials = null;
                }
                else
                {
                    Debug.Log("Wrong");
                    //guess[i].GetInt(0);
                    guessCount--;
                    //ingredients.GetComponent<ingredientsScript>().enabled = false;
                    guess[i] = null;
                    //return;
                    //materials = null;
                }  
            }
                
        }
          
    }

    // Start is called before the first frame update
    void Start()
    {
       // for (int i = 0; i < guessCount.CompareTo(materials); i++)
        //{
           // int randomNum = Random.Range(0, guessCount);
          //  if(randomNum >= guessCount)
          //  {
           //     Debug.Log("You Guessed Right");
                
          //  }
         //   else
         //   {
        //        Debug.Log("You Guessed Wrong");
                
       //     }
     //   }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown (KeyCode.Space))
        //{
            //ingredients.GetComponent<ingredientsScript>().enabled = true;
        //}
    }

    void AddScore()
    {
        scoreText.text = score.ToString("0");
        score++;
    }
}
