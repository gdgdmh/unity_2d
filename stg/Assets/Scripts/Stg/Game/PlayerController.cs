using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed_ = 5.0f;

    // PlayerBulletプレハブ
    //public GameObject bullet;

    StgSpaceship spaceship;

    // Use this for initialization
    //void Start () {	
    //}

    IEnumerator Start()
    {
        // Spaceshipコンポーネントを取得
        spaceship = GetComponent<StgSpaceship>();

        while (true)
        {

            // 弾をプレイヤーと同じ位置/角度で作成
            spaceship.Shot(transform);

            // shotDelay秒待つ
            yield return new WaitForSeconds(spaceship.shot_delay_);
        }
        /*
        while (true)
        {
            // 弾をプレイヤーと同じ位置/角度で作成
            Instantiate(bullet, transform.position, transform.rotation);
            // 0.05秒待つ
            yield return new WaitForSeconds(0.05f);
        }
        */
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

    /*
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

  // Spaceshipコンポーネント
  Spaceship spaceship;

  IEnumerator Start ()
  {
    // Spaceshipコンポーネントを取得
    spaceship = GetComponent<Spaceship> ();

    while (true) {

      // 弾をプレイヤーと同じ位置/角度で作成
      spaceship.Shot (transform);

      // shotDelay秒待つ
      yield return new WaitForSeconds (spaceship.shotDelay);
    }
  }

  void Update ()
  {
    // 右・左
    float x = Input.GetAxisRaw ("Horizontal");

    // 上・下
    float y = Input.GetAxisRaw ("Vertical");

    // 移動する向きを求める
    Vector2 direction = new Vector2 (x, y).normalized;

    // 移動
    spaceship.Move (direction);
  }
}
    */
}
