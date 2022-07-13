using UnityEditor.Timeline.Actions;
using UnityEngine;

/// <summary>
/// 學習非靜態API
/// API文件上沒有static
/// </summary>
public class LearnAPINonStatic : MonoBehaviour
{
    public Transform traA;
    public Light lightA;
    public Transform traB;

    private void Start()
    {
        /* 非靜態屬性 properties
         * 1. 取得 get
         * 條件:
         * -該類別類型欄位
         * -實體物件
         * -欄位存放該實體物件 */
        print("A物件的座標:" + traA.position);

        //2.設定 set
        //欄位名稱.非靜態屬性名稱 指定 值;
        traA.position = new Vector3(-1.65f, 0.5f,-10);
        lightA.color = new Color(1, 1, 5);

    }

    private void Update()
    {
        //非靜態方法 methods
        //3.使用
        //欄位名稱.非靜態方法名稱(對應引數)
        traB.Rotate(0, 1, 0);

    }
}
