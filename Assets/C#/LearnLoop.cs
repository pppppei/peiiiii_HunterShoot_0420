using UnityEngine;
using System.Collections;

/// <summary>
/// �ǲ߰j��B��P�{��Coroutine:����
/// while�Bfor�о�
/// while do�Bforeach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    void Start()
    {
        //�j��: ���ư���

        //while �j��y�k:
        //if (���L��) {�{��} ����@��
        //while (���L��) {�{��} ���ư��檽�쥬�L�Ȭ�false

        int count = 0;

        while (count < 5)
        {
            print("while�j��!" + count);
            count++;
        }

        //for (��l��; ����; �j�����᪺�B�z) {�{��}
        for (int i = 0; i < 5; i++)
        {
            print("for�j��!" + i);
        }

        /*��P�{��
         * 1. �ޥΩR�W�Ŷ�System.Collections
         * 2. �w�q�Ǧ^���欰IEnumerator����k
         * 3. yield return ����
         * 4. Start Coroutine �Ұ�
         */
        StartCoroutine(Test());
        StartCoroutine(Loop());
    }

    private IEnumerator Test()
    {
        print("<color=red>�Ĥ@��</color>");
        yield return new WaitForSeconds(1);
        print("<color=blue>�ĤG��</color>");
    }

    private IEnumerator Loop()
    {
        for (int i = 0; i < 5; i++)
        {
            print("<color=#7fffd4>for�j��" + i + "</color>");
            yield return new WaitForSeconds(0.5f);
        }
    }
}
