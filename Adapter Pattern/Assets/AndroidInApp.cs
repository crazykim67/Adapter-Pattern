using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 안드로이드 결제 모듈
public class AndroidInApp : PurchaseAdapter
{
    public void Purchase()
    {
        this.InAppPurchase();
    }

    private void InAppPurchase()
    {
        Debug.Log("AOS 결제 완료");
    }
}
