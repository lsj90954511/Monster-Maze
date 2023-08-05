using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletGenerator : MonoBehaviour
{
    public GameObject BossBulletPrefab;
    float span = 5.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;

            for (int i = 0; i < 8; i++)
            {
                //총알 생성
                if (i == 0)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = 0.1f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = 0.0f;
                }
                else if (i == 1)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = -0.1f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = 0.0f;
                }
                else if (i == 2)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = 0.0f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = 0.1f;
                }
                else if (i == 3)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = 0.0f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = -0.1f;
                }
                else if (i == 4)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = 0.1f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = 0.1f;
                }
                else if (i == 5)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = 0.1f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = -0.1f;
                }
                else if (i == 6)
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = -0.1f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = 0.1f;
                }
                else
                {
                    BossBulletPrefab.GetComponent<BossBulletController>().x = -0.1f;
                    BossBulletPrefab.GetComponent<BossBulletController>().y = -0.1f;
                }

                GameObject clone = Instantiate(BossBulletPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
    }
}
