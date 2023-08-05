using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossStageDirector : MonoBehaviour
{
    GameObject bossHP;
    GameObject playerHP;
    GameObject player;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        this.camera = Camera.main;
        this.bossHP = GameObject.Find("bossHP");
        this.playerHP = GameObject.Find("playerHP");
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //hp�� ��ġ �÷��̾� ��ġ�� ���� �����̵��� ��
        this.playerHP.transform.position = camera.WorldToScreenPoint(player.transform.position + new Vector3(0, 1.0f, 0));
    }

    //���� hp�� ���̱�
    public void DecreaseBossHp()
    {
        this.bossHP.GetComponent<Image>().fillAmount -= PlayerController.power / 100.0f;
    }
    //�÷��̾� hp�� ���̱�
    public void DecreasePlayerHp()
    {
        this.playerHP.GetComponent<Image>().fillAmount -= 0.2f;
    }
}
