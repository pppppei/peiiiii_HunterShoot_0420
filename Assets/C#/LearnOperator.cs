using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1. �ƾǹB��l
/// 2. ����B��l
/// 3. �޿�B��l
/// </summary>
public class LearnOperator: MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private int c = 99;
    private int d = 1;

    private int diamond = 1;
    private int hp = 100;

    private void Start()
    {
        #region �ƾǹB��l
        // �[+ ��- ��* ��/ �l%
        print("�[�k:" + (a + b));
        print("��k:" + (a - b));
        print("���k:" + (a * b));
        print("���k:" + (a / b));
        print("�l�k:" + (a % b));
        #endregion

        #region ����B��l
        //�p��< �j��> �p�󵥩�<= �j�󵥩�>= ������!= ����==
        print("�p��:" + (c < d));      //f
        print("�j��:" + (c > d));      //t
        print("�p�󵥩�:" + (c <= d)); //f
        print("�j�󵥩�:" + (c >= d)); //t
        print("������:" + (c != d));   //t
        print("����:" + (c == d));     //f
        #endregion

        #region �޿�B��l
        //�޿�B��l�A�w�塞�L��
        //�åB &&: ��ӥ��L�Ȧ��@��false ���G�N�Ofalse
        print("true && true:" + (true && true));     //t
        print("true && false:" + (true && false));   //f
        print("false && true:" + (false && true));   //f
        print("false && false:" + (false && false)); //f

        //�Ϊ�||: ��ӥ��L�Ȧ��@��true ���G�N�Otrue
        print("true || true:" + (true || true));     //t
        print("true || false:" + (true || false));   //t
        print("false || true:" + (false || true));   //t
        print("false || false:" + (false || false)); //f

        //�C���d��: �ӧQ����: �_��>= 3�� �åB ��q �j�� 0 �~��L��
        print("�O�_�L��:" + (diamond >= 3 && hp > 0)); //f

        //�A�˹B��l!: �N���L���ܬۤ�
        print("!true:" + (!true));   //f
        print("!false:" + (!false)); //t

        #endregion
    }
}
