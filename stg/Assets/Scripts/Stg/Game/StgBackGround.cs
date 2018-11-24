using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StgBackGround : MonoBehaviour {

    public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 時間によってYが0から1 1から0へ変化するのを繰り返す
        float y = Mathf.Repeat(Time.time * speed, 1);

        // yがずれていくオフセット
        Vector2 offset = new Vector2(0, y);

        // マテリアルにオフセットを設定
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
}
