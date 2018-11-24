using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    StgSpaceship spaceship;
	// Use this for initialization

    IEnumerator Start()
    {
        spaceship = GetComponent<StgSpaceship>();
        // 移動
        spaceship.Move(transform.up * -1);

        if (spaceship.can_shot_ == false)
        {
            // 弾を撃たない場合ここで終了
            yield break;
        }
        while (true)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                Transform shotPosition = transform.GetChild(i);

                // shotPositionの位置と角度で弾を撃つ
                spaceship.Shot(shotPosition);
            }
            // 少し待つ
            yield return new WaitForSeconds(spaceship.shot_delay_);
        }

    }
    /*
	void Start () {
        spaceship = GetComponent<StgSpaceship>();
        spaceship.Move(transform.up * -1);
		
	}
    */

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string layerName = LayerMask.LayerToName(collision.gameObject.layer);
        //Debug.Log(layerName);
        // プレイヤーの弾以外は何もしない
        if (layerName != "Bullet(Player)")
        {
            return;
        }
        // 弾の削除
        Destroy(collision.gameObject);
        // 爆発
        spaceship.Explosion();
        // Enemyの削除
        Destroy(gameObject);
    }
}
