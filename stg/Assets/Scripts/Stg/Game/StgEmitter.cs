using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StgEmitter : MonoBehaviour {

    public GameObject[] waves;
    private int current_wave;

	// Use this for initialization
	//void Start () {
	//}
	
	// Update is called once per frame
	//void Update () {
	//}

    IEnumerator Start()
    {
        // Waveが存在しないなら終了
        if (waves.Length == 0)
        {
            yield break;
        }

        while (true)
        {
            // waveを作成
            GameObject wave = (GameObject)Instantiate(waves[current_wave], transform.position, Quaternion.identity);

            //waveをEmitterの子要素にする
            wave.transform.parent = transform;

            break;
            /*

            // waveの子要素のEnemyがすべて削除されるまで待機
            while (wave.transform.childCount != 0)
            {
                yield return new WaitForEndOfFrame();
            }

            // waveの削除
            Destroy(wave);

            // waveを実行したら0にする(ループする)
            if (waves.Length <= ++current_wave) {
                current_wave = 0;
            }
            */
        }
    }
    /*
  IEnumerator Start ()
  {

    // Waveが存在しなければコルーチンを終了する
    if (waves.Length == 0) {
      yield break;
    }

    while (true) {

      // Waveを作成する
      GameObject wave = (GameObject)Instantiate (waves [currentWave], transform.position, Quaternion.identity);

      // WaveをEmitterの子要素にする
      wave.transform.parent = transform;

      // Waveの子要素のEnemyが全て削除されるまで待機する
      while (wave.transform.childCount != 0) {
        yield return new WaitForEndOfFrame ();
      }

      // Waveの削除
      Destroy (wave);

      // 格納されているWaveを全て実行したらcurrentWaveを0にする（最初から -> ループ）
      if (waves.Length <= ++currentWave) {
        currentWave = 0;
      }

    }
  }
}
     */


    /*
public class Emitter : MonoBehaviour
{
  // Waveプレハブを格納する
  public GameObject[] waves;

  // 現在のWave
  private int currentWave;

  IEnumerator Start ()
  {

    // Waveが存在しなければコルーチンを終了する
    if (waves.Length == 0) {
      yield break;
    }

    while (true) {

      // Waveを作成する
      GameObject wave = (GameObject)Instantiate (waves [currentWave], transform.position, Quaternion.identity);

      // WaveをEmitterの子要素にする
      wave.transform.parent = transform;

      // Waveの子要素のEnemyが全て削除されるまで待機する
      while (wave.transform.childCount != 0) {
        yield return new WaitForEndOfFrame ();
      }

      // Waveの削除
      Destroy (wave);

      // 格納されているWaveを全て実行したらcurrentWaveを0にする（最初から -> ループ）
      if (waves.Length <= ++currentWave) {
        currentWave = 0;
      }

    }
  }
}
     */
}
