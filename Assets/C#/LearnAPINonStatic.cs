using UnityEditor.Timeline.Actions;
using UnityEngine;

/// <summary>
/// �ǲ߫D�R�AAPI
/// API���W�S��static
/// </summary>
public class LearnAPINonStatic : MonoBehaviour
{
    public Transform traA;
    public Light lightA;
    public Transform traB;

    private void Start()
    {
        /* �D�R�A�ݩ� properties
         * 1. ���o get
         * ����:
         * -�����O�������
         * -���骫��
         * -���s��ӹ��骫�� */
        print("A���󪺮y��:" + traA.position);

        //2.�]�w set
        //���W��.�D�R�A�ݩʦW�� ���w ��;
        traA.position = new Vector3(-1.65f, 0.5f,-10);
        lightA.color = new Color(1, 1, 5);

    }

    private void Update()
    {
        //�D�R�A��k methods
        //3.�ϥ�
        //���W��.�D�R�A��k�W��(�����޼�)
        traB.Rotate(0, 1, 0);

    }
}
