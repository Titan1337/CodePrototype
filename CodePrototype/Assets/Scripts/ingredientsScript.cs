using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredientsScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] ingredients;
    [SerializeField]
    Material[] materials;
    



    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < ingredients.Length; i++)
        { 
            int randomNum = Random.Range(0, materials.Length);
            ingredients[i].GetComponent<Renderer>().material = materials[randomNum];


            
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
