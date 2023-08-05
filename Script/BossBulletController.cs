using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    public float x, y;

    //캐릭터에 닿으면 사라짐
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //hp 깎음
            if (PlayerController.shield <= 0)
            {
                //BossStageDirector에 충돌 알림
                GameObject director = GameObject.Find("BossStageDirector");
                director.GetComponent<BossStageDirector>().DecreasePlayerHp();
                //hp 깎기
                PlayerController.hp -= BossController.power;
            }
            else
            {
                PlayerController.shield--;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //총알 이동
        transform.Translate(x, y, 0);

        //화면 밖으로 나가면 총알 없앰
        if (transform.position.x < -9.0f || transform.position.x > 9.0f
            || transform.position.y < -5.5f || transform.position.y > 5.5f)
            Destroy(gameObject);
    }
}
