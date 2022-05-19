using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasherGun : MonoBehaviour
{
    [Space]
    [Header("Elements")]
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform BulletContener;
    [SerializeField] GameObject ImageGun;
    

    private bool ReadyFire = true;


    public IEnumerator RechargeGun() 
    {
        yield return new WaitForSeconds(WorldManager.instate.SettingGame.RechargeTime);

        ReadyFire = true;
        ImageGun.SetActive(true);
    }

    public void Shot() 
    {
        if (ReadyFire) 
        {          
            GameObject ActivBullet = Instantiate(Bullet, this.transform.position, this.transform.rotation, BulletContener);
            ActivBullet.gameObject.GetComponent<Bullet>().Initialization(SetAndUpdateTarget());
            ReadyFire = false;
            ImageGun.SetActive(false);
            StartCoroutine(RechargeGun());
        }       
    }

    public int SetAndUpdateTarget() 
    {
        if (WorldManager.instate.CorrectTarget == WorldManager.instate.ContenerZombi.childCount-1)
        {
            WorldManager.instate.CorrectTarget = 0;
            return 0; 
        }
        else
        {
            WorldManager.instate.CorrectTarget++;
            return WorldManager.instate.CorrectTarget;
        }
       
    }
}
