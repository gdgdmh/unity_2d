using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    public int kSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 上方向のベクトルを代入
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * kSpeed;
		
	}

    /*
public class Bullet : MonoBehaviour
{
  public int speed = 10;

  void Start ()
  {
    GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
  }
}
    */
}
