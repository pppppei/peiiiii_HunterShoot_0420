using UnityEngine;

/// <summary>
/// �ǲ��R�AAPI
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        //�R�A�ݩ� static properties
        //1. ���o get
        //���o�R�A�ݩʻy�k: ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("�ù��e��:" + Screen.width);
        print("��P�v:" + Mathf.PI);

        //2. �]�wset (Read Only  ����]�w)
        //�]�w�R�A�ݩʻy�k: ���O�W��.�R�A�ݩʦW�� ���w ��;
        Screen.brightness = 0.5f;
        Cursor.visible = false;
    }
}
