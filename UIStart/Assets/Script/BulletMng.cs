using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMng : MonoBehaviour
{
    public Player player;
    public GameObject[] TurretsOri;
    public Bullet bulletOri;

    public float BulletFireTime;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time > BulletFireTime)
        {
            time = 0;
            CreateBullet();
        }

    }
    void CreateBullet()
    {
        for(int i = 0; i <= TurretsOri.Length;i++)
        {
            Bullet bullet;
            bullet = bulletOri;
            bullet.transform.position = TurretsOri[i].transform.position;
            bullet.transform.rotation = TurretsOri[i].transform.rotation;

        }
    }
}
