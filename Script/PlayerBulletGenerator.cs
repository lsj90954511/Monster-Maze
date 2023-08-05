using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletGenerator : MonoBehaviour
{
    public GameObject PlayerBulletPrefab;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� ��ġ ����
        Vector3 pos = this.player.transform.position;

        if (this.player.GetComponent<PlayerController>().getAttack())
        {
            //�Ѿ� ����
            GameObject clone = Instantiate(PlayerBulletPrefab, pos, Quaternion.identity);
        }
    }
}
