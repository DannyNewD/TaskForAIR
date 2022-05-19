using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ZombiLogics : MonoBehaviour
{
    [SerializeField] float MinSleep;
    [SerializeField] float MaxSleep;
    [SerializeField] public AnimationCurve[] MoveZombiCurve;
    void Start()
    {
        StartCoroutine(Move(Random.Range(0, 2)));
    }

    IEnumerator Move(float timeSleep)
    {
        yield return new WaitForSeconds(timeSleep);

         Vector3 EndPos = WorldManager.instate.GetEnvironmentPosition();

        this.gameObject.transform.DOLocalMove(
            new Vector3(EndPos.x, 0, EndPos.z + 0.7f),
            WorldManager.instate.SettingGame.SpeedMoveZombi)
            .SetEase(MoveZombiCurve[Random.Range(0, MoveZombiCurve.Length - 1)]).OnComplete(() => 
            { 
                StartCoroutine(Move(Random.Range(MinSleep, MaxSleep)));
            });
  
    }

}
