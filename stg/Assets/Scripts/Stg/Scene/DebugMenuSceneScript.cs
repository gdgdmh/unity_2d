﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DebugMenuSceneScript : MonoBehaviour
{

    // 親となるオブジェクト(content)
    public RectTransform content;

    // 複製元のプレハブ(スクロールビューの中に表示するオブジェクト)
    public GameObject scroll_view_object;

    private const int kSceneNum = 10;
    private Button[] button_array = new Button[kSceneNum];

    // Use this for initialization
    void Start()
    {
        MhCommon.Print("DebugMenuSceneScript Start()");

        // シーンの名前表示テキスト
        string[] text_array = new string[kSceneNum]
        {
            "Game1",
            "Title",
            "MainMenu",
            "Scene03",
            "Scene04",
            "Scene05",
            "Scene06",
            "Scene07",
            "Scene08",
            "Scene09"
        };
        for (int i = 0; i < kSceneNum; ++i)
        {
            // テキストを編集
            GameObject obj = CreateScrollViewObject();
            Text txt = obj.GetComponentInChildren<Text>();
            txt.text = text_array[i];
            // ボタンを配列に保存しておく
            Button button = obj.GetComponentInChildren<Button>();
            button_array[i] = button;
            // ボタンの押下イベントを登録(リスナーを削除してから登録)
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => OnClick(button));
            // ボタンの中のテキストを編集
            Text button_text = button.GetComponentInChildren<Text>();
            button_text.text = "開始";
        }
        text_array = null;
    }

    void OnDestory()
    {
        MhCommon.Print("ScrollObjectCreater::OnDestroy");
        // 念のためにボタンを全て破棄
        for (int i = 0; i < button_array.Length; ++i)
        {
            button_array[i].onClick.RemoveAllListeners();
            button_array[i] = null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    /**
     * ボタン押下イベント(引数は押されたボタン)
     */
    public void OnClick(Button self)
    {
        // どのボタンが押されたかを探す
        MhCommon.Print("DebugMenuSceneScript::OnClick");
        for (int i = 0; i < button_array.Length; ++i)
        {
            if (self.Equals(button_array[i]))
            {
                MhCommon.Print("DebugMenuSceneScript::OnClick index=" + i);
                // どのボタンが押されたかによって違う処理をする(別のシーンへ移動)
                switch (i)
                {
                    case 0:
                        MhCommon.Print("DebugMenuSceneScript::OnClick GameMainScene");
                        UnityEngine.SceneManagement.SceneManager.LoadScene("GameMainScene");
                        break;
                    case 1:
                        break;
                    case 2:
                        //UnityEngine.SceneManagement.SceneManager.LoadScene("main_menu");
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private GameObject CreateScrollViewObject()
    {
        // スクロールビューの中身を生成(プレハブの複製)
        GameObject obj = Instantiate(scroll_view_object);
        Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        // contentに関連付け
        obj.transform.SetParent(content.transform, false);
        return obj;
    }
}
