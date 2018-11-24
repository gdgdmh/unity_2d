using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StgExplosion : MonoBehaviour {

    void OnEnable()
    {
        //Invoke the Die method
        //Invoke("Die", lifeTime);
    }

    void OnDisable()
    {
        //Cancel the invoke if something else removes the explosion
        CancelInvoke("Die");
    }

    void Die()
    {
        // エラーが出るのでコメントアウト
        //Re-add the explosion to the pool
        //ObjectPool.current.PoolObject (gameObject);
    }

    // アニメーションイベント
    void OnAnimationFinish()
    {
        // アニメーションが終わったら破棄する
        Destroy(gameObject);
    }
    /*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    */
}
