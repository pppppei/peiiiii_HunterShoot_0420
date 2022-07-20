using UnityEngine;
using System.Collections;

/// <summary>
/// 學習迴圈、協同程序Coroutine:等待
/// while、for教學
/// while do、foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    void Start()
    {
        //迴圈: 重複執行

        //while 迴圈語法:
        //if (布林值) {程式} 執行一次
        //while (布林值) {程式} 重複執行直到布林值為false

        int count = 0;

        while (count < 5)
        {
            print("while迴圈!" + count);
            count++;
        }

        //for (初始值; 條件; 迴圈執行後的處理) {程式}
        for (int i = 0; i < 5; i++)
        {
            print("for迴圈!" + i);
        }

        /*協同程序
         * 1. 引用命名空間System.Collections
         * 2. 定義傳回類行為IEnumerator的方法
         * 3. yield return 等待
         * 4. Start Coroutine 啟動
         */
        StartCoroutine(Test());
        StartCoroutine(Loop());
    }

    private IEnumerator Test()
    {
        print("<color=red>第一行</color>");
        yield return new WaitForSeconds(1);
        print("<color=blue>第二行</color>");
    }

    private IEnumerator Loop()
    {
        for (int i = 0; i < 5; i++)
        {
            print("<color=#7fffd4>for迴圈" + i + "</color>");
            yield return new WaitForSeconds(0.5f);
        }
    }
}
