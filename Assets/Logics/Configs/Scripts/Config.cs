using UnityEngine;

[CreateAssetMenu(fileName = "ConfigGame", menuName = "ScriptableObjects/ConfigGame")]
public class Config : ScriptableObject
{
    [Space]
    [Header("Data Washer")]
    [SerializeField, Range(0.1f, 10)] private float _RechargeTime;
    public float RechargeTime 
    { 
        get { return this._RechargeTime; }
    }

    [SerializeField, Range(1, 10)] private float _BulletSpeed;
    public float BulletSpeed 
    { 
        get { return 11 - this._BulletSpeed; } 
    }

    [SerializeField, Range(1,10)] private float _BulletRotationSpeed;
    public float BulletRotationSpeed
    {
        get { return this._BulletRotationSpeed*70; }
    }

    [Space]
    [Header("Data Zombi")]
    [SerializeField, Range(1,10)] private float _SpeedMoveZombi;
    public float SpeedMoveZombi
    {
        get { return 11 - this._SpeedMoveZombi; }
    }

}
