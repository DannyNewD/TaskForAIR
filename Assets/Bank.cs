using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bank : MonoBehaviour
{
    private int _bankCoin;



    public int bankCoin { 
        get {
            return _bankCoin;
        } 
        set 
        { 
            _bankCoin = coin(value);
        } 
    }

    public event Action<int, string> BanEvent;

    private int coin(int coin) 
    {
        BanEvent?.Invoke(coin, "Теперь бабок столько: "+ coin);
        return _bankCoin;
    }
}
