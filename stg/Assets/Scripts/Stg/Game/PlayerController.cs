using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed_ = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 左右
        //float x = Input.GetAxisRaw("Horizontal");
        float x = Input.GetAxis("Horizontal");
        // 上下
        //float y = Input.GetAxisRaw("Vertical");
        float y = Input.GetAxis("Vertical");

        // 移動する向きを求める(正規化)
        Vector2 direction = new Vector2(x, y).normalized;

        // 移動するベクトル(向きと速さを)を適用
        GetComponent<Rigidbody2D>().velocity = direction * speed_;
	}
}
