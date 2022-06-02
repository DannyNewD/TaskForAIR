using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIBankTest : MonoBehaviour
{
    [SerializeField] Test[] r;
    [SerializeField] Text CoinInfo;
    [SerializeField] Bank bank;

    [SerializeField] Button button;
    [SerializeField] int testSett;

    private void Awake()
    {
        button.onClick.AddListener(() =>
        {
            bank.bankCoin = testSett;
        });
        bank.BanEvent += Bank_BanEvent;
    }

    private void Bank_BanEvent(int arg1, string arg2)
    {
        CoinInfo.text = Convert.ToString(arg1);
        Debug.Log(arg2);
    }

    [Serializable]
    enum Test 
    {
        trt,
        ertert,
        ertertwer
    }
}
