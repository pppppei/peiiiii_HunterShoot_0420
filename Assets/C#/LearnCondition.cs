using UnityEngine;

/// <summary>
/// ���� (�P�_��)
/// 1. if
/// 2. switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int combo;

    private void Start()
    {
        #region if �P�_��
        //if �y�k: if(���L��){���L�ȵ��� true �|����}
        if (true)
        {
            print("�ڧP�_��if��");
        }
        #endregion
    }

    private void Update()
    {
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }

        //�s���� < 100 �����O + 0%
        //�s���� >= 100 �����O + 10% 
        //�s���� >= 200 �����O + 20 %
        if (combo < 100)
        {
            print("�����O+0%");
        }
        else if (combo >= 100) 
        {
            print("�����O+10%");
        }
        else if (combo >= 200) 
        {
            print("�����O+20%");
        }

    }
}
