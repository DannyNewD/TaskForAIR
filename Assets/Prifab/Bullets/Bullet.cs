using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
    [SerializeField] public AnimationCurve[] MoveBulletCurve;
    public Sprite BUM;
    public void Initialization(int TargetId)
    {

        this.gameObject.transform.DOLocalJump(WorldManager.instate.ContenerZombi.GetChild(TargetId).localPosition, Random.Range(2,3), Random.Range(0, 3), WorldManager.instate.SettingGame.BulletSpeed).OnComplete(() =>
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BUM;
            Destroy(this.gameObject, 0.2f);
        }).SetEase(MoveBulletCurve[Random.Range(0, MoveBulletCurve.Length - 1)]);  
    }

    public void Update()
    {
        this.gameObject.transform.Rotate(0, 0, WorldManager.instate.SettingGame.BulletRotationSpeed * Time.deltaTime);
    }

}
