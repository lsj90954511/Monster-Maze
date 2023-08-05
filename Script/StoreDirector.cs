using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreDirector : MonoBehaviour
{
    GameObject powerUp;
    GameObject shield;
    GameObject close;
    GameObject storeSet;

    //���ݷ� ����, �� ����, ���ݷ� ǥ��
    public void playerPowerUp()
    {
        PlayerController.power += 3;
        PlayerController.stars -= 3;
    }
    //��� Ƚ�� 1 ����, �� ����, ��� Ƚ�� ǥ��
    public void shieldUp()
    {
        PlayerController.shield++;
        PlayerController.stars -= 2;
    }
    //����� â ��Ȱ��ȭ
    public void inactiveStore()
    {
        storeSet.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.powerUp = GameObject.Find("PowerUp");
        this.shield = GameObject.Find("Shield");
        this.close = GameObject.Find("Close");
        this.storeSet = GameObject.Find("StoreSet");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas").transform.Find("StoreSet").gameObject.activeSelf == true)
        {
            //���� ������ ���ݺ��� �������� ������ ��ư ��Ȱ��ȭ
            if (powerUp)
            {
                if (PlayerController.stars < 3 || PlayerController.stars < 2)
                {
                    this.powerUp.GetComponent<Button>().interactable = false;
                }
            }
            if (shield)
            {
                if (PlayerController.stars < 2)
                {
                    this.shield.GetComponent<Button>().interactable = false;
                }
            }
            
        }
        
    }
}
