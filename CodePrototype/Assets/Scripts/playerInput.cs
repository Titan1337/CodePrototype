using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    [SerializeField]
    guessLogic logic;
    [SerializeField]
    guessLogic guessCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        logic.guess[logic.guessCount] = GetComponent<Renderer>().material;
        logic.guessCount++;

        logic.PlayerGuessCheck();

    }
}
