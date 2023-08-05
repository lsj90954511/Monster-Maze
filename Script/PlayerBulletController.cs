using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    Vector3 dir;
    GameObject player;

    //보스에 닿으면 사라짐
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            //BossStageDirector에 충돌 알림
            GameObject director = GameObject.Find("BossStageDirector");
            director.GetComponent<BossStageDirector>().DecreaseBossHp();
            //총알 없앰
            Destroy(gameObject);
            //hp 줄어듦
            BossController.bossHp -= PlayerController.power;
            Debug.Log(BossController.bossHp);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        dir = this.player.GetComponent<PlayerController>().getVec();
    }

    // Update is called once per frame
    void Update()
    {
        //캐릭터가 보는 방향으로 총알 발사
        transform.Translate(dir * 0.1f);


        //화면 밖으로 나가면 총알 없앰
        if (transform.position.x < -9.0f || transform.position.x > 9.0f
            || transform.position.y < -5.5f || transform.position.y > 5.5f)
            Destroy(gameObject);
    }
}
