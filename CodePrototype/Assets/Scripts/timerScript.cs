using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    float time = 0f;
    float startTime = 120f;

    [SerializeField] Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        time = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        timerText.text = time.ToString("0");

        if (time <= 0)
        {
            time = 0;
        }
    }
}
