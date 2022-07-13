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

        //�R�A��k static methods
        //3. �ϥ�
        //���O�W��.�R�A��k�W��(�������޼�);
        float r = Random.Range(1.5f, 49.9f);
        print("�H��1.5~49.9�ƭ�:" + r);

    }

    private void Update()
    {
        bool downSpace = Input.GetKeyDown("space");
        print("�O�_���U�ť���:" + downSpace);
    }
}
