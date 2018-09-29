﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rigidbody2Dが必須
[RequireComponent(typeof(Rigidbody2D))]
public class StgSpaceship : MonoBehaviour {

    public float speed_; // 移動スピード
    public float shot_delay_; // 弾を撃つ間隔
    public GameObject bullet_; // 弾のPrefab

    public void Shot(Transform origin) {
        Instantiate(bullet_, origin.position, origin.rotation);
    }

    // 機体の移動
    public void Move(Vector2 direction) {
        GetComponent<Rigidbody2D>().velocity = direction * speed_;
    }

    // Use this for initialization
    //void Start () {
    //}

    // Update is called once per frame
    //void Update () {
    //}
}

/*
// Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour
{
    // 移動スピード
    public float speed;

    // 弾を撃つ間隔
    public float shotDelay;

    // 弾のPrefab
    public GameObject bullet;

    // 弾の作成
    public void Shot(Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
    }

    // 機体の移動
    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
*/
