using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    [SerializeField] WasherGun CorrectGun;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CorrectGun.Shot();
        }
    }
}
