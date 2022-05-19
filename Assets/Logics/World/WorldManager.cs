using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    [Space]
    [Header("Game Settings")]
    [SerializeField] public Config SettingGame; //Настройка игры

    [Space]
    [Header("Element")]
    [SerializeField] Transform ContenerEnvironment;
    [SerializeField] public Transform ContenerZombi;

    [SerializeField] public int CorrectTarget = 0;
   



    public static WorldManager instate;
    private void Awake()
    {
        instate = this;             
    }

    private void Start()
    {
        if (SettingGame == null)
        {
            SettingGame = Resources.Load<Config>("ConfigGame/ConfigGame_Simpel");
        }
    }

    public Vector3 GetEnvironmentPosition() 
    {
        return ContenerEnvironment.GetChild(Random.Range(0, ContenerEnvironment.childCount)).localPosition;
    }

    public Transform GetZombi(ref int id) 
    {
        if(id < ContenerZombi.childCount)
        {
            return ContenerZombi.GetChild(id);
        }
        return null;
    }
}
