using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private PurchaseAdapter purchaseAdapter;
     
    public void OnPurchased()
    {
        purchaseAdapter.Purchase();
        Debug.Log("결제완료");
    }

    public void OnChangedAOS()
    {
        purchaseAdapter = new AndroidInApp();
        Debug.Log("AOS 결제");
    }

    public void OnChangedIOS()
    {
        purchaseAdapter = new IOSPurchase();
        Debug.Log("IOS 결제");
    }
}
