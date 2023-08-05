using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveStore : MonoBehaviour
{
    //GameObject storeSet;

    //���� â Ȱ��ȭ
    public void StoreActive()
    {
        GameObject.Find("Canvas").transform.Find("StoreSet").gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        //this.storeSet = GameObject.Find("StoreSet");
    }

    // Update is called once per frame
    void Update()
    {

    }
}