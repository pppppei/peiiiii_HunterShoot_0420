using UnityEngine;

//�T���Ź�>����
//�����W����>Add Component

//���y�k: �׹��� ������� ���ۭq�W�� ���w �� �����Ÿ�

//��j�׹���: public�Bprivate(�w�]�ȡA�i�ٲ�)
//�O�_���\�~���s��&��ܩ��ݩʭ��O

/*����ݩʻy�k:[�ݩʦW��(��)]
1.���� Tooltip
2.���D Header
3.�d�� Range (�ȭ�int/float) */

public class Car : MonoBehaviour
{
    //���q�B���סB�~�P�B���L�ѵ�
    [Header("�T�����q"),Tooltip("���:��"),Range(1,10)]
    public int weight = 3;
    [Header("�T������"),Tooltip("���:����"),Range(1,3)]
    public float height = 2.1f;
    [Header("�T���~�P�W��")]
    public string brand = "Tesla";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWindow = true;
}
