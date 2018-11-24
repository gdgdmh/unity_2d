using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    public int kSpeed = 10;
    public int lifeTime = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 上方向のベクトルを代入
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * kSpeed;
        // 出っぱなしだとまずいのでlifeTime秒後に消える
        Destroy(gameObject, lifeTime);
		
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
