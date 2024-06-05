using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson6 : MonoBehaviour
{
    public Button btnGet;
    public Text textContent; //显示地址的文本框
    // Start is called before the first frame update
    void Start()
    {
        btnGet.onClick.AddListener(() =>
        {
            using (AndroidJavaClass ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    ajo.Call("getAddress");
                }
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetAddress(string str)
    {
        textContent.text = str;
    }
}
