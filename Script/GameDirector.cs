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

        //스토어 창 비활성화
        storeSet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //모은 별 수 표시
        this.starNum.GetComponent<Text>().text = PlayerController.stars.ToString();

        if (PlayerController.clearStage == 0)
        {

        }
        //스테이지 클리어하면 버튼 비활성화, 다음 단계 버튼 활성화
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
            //보스 스테이지 활성화
            this.stageBtnBoss.GetComponent<Button>().interactable = true;
        }
    }
}
