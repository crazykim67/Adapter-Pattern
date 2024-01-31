using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IOS 결제 모듈
public class IOSPurchase : PurchaseAdapter
{
    public void Purchase()
    {
        this.BuyAppProduct();
    }

    private void BuyAppProduct()
    {
        Debug.Log("IOS 상품 결제 완료");
    }
}
