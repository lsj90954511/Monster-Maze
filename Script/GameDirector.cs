using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject stageBtn;
    GameObject stageBtn2;
    GameObject stageBtn3;
    GameObject stageBtnBoss;
    GameObject starNum;
    GameObject storeSet;

    // Start is called before the first frame update
    void Start()
    {
        this.stageBtn = GameObject.Find("StageBtn");
        this.stageBtn2 = GameObject.Find("StageBtn2");
        this.stageBtn3 = GameObject.Find("StageBtn3");
        this.stageBtnBoss = GameObject.Find("StageBtnBoss");
        this.starNum = GameObject.Find("Stars");
        this.storeSet = GameObject.Find("StoreSet");

        //����� â ��Ȱ��ȭ
        storeSet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //���� �� �� ǥ��
        this.starNum.GetComponent<Text>().text = PlayerController.stars.ToString();

        if (PlayerController.clearStage == 0)
        {

        }
        //�������� Ŭ�����ϸ� ��ư ��Ȱ��ȭ, ���� �ܰ� ��ư Ȱ��ȭ
        if (PlayerController.clearStage == 0)
        {
            this.stageBtn.GetComponent<Button>().interactable = true;
        }
        else if (PlayerController.clearStage == 1)
        {
            this.stageBtn2.GetComponent<Button>().interactable = true;

        }
        else if (PlayerController.clearStage == 2)
        {
            //this.stageBtn2.GetComponent<Button>().interactable = false;
            this.stageBtn3.GetComponent<Button>().interactable = true;
        }
        else if (PlayerController.clearStage == 3)
        {
            //this.stageBtn3.GetComponent<Button>().interactable = false;
            //���� �������� Ȱ��ȭ
            this.stageBtnBoss.GetComponent<Button>().interactable = true;
        }
    }
}
