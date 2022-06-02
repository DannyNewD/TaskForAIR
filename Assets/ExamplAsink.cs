using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class ExamplAsink : MonoBehaviour
{ 
    int seed = 1;
    private float[] noiseValues;
    void Start()
    {
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("Start");
            Random.seed = seed;
            noiseValues = new float[4];
            int i = 0;
            while (i < noiseValues.Length)
            {
                noiseValues[i] = Random.Range(1,7);
                print(noiseValues[i]);
                i++;
            }
            Debug.Log("Finish");
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            seed++;
            Debug.Log("Next to " + seed);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            seed--;
            Debug.Log("Next to " + seed);
        }
    }

}
