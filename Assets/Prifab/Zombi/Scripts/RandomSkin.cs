using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSkin : MonoBehaviour
{
    [Space]
    [Header("Element")]
    [SerializeField] Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprites[Random.RandomRange(0, sprites.Length)];
    }
}
