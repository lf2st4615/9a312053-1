﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invader : MonoBehaviour {
    public GameObject explo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, -0.01f, 0);
    }
    void OnTriggerEnter2D(Collider2D col) //名為col的觸發事件
    {
        if (col.tag == "Ship" || col.tag == "Bullet") //如果碰撞的標籤是Ship或Bullet
        {
            Destroy(col.gameObject); //消滅碰撞的物件
            Destroy(gameObject); //消滅物件本身
            if (col.tag == "Ship") //如果碰撞的標籤是Ship
            {
                Instantiate(explo, col.gameObject.transform.position, col.gameObject.transform.rotation);
                gamefuction.Instance.GameOver();
                //在碰撞物件的位置產生爆炸，也就是在太空船的位置產生爆炸
            }
            
            gamefuction.Instance.AddScore();
        }
    }
}
