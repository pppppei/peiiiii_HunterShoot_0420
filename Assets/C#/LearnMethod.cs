using UnityEngine;

public class LearnMethod : MonoBehaviour
{    //�ۭq�覡�A�ݭn�I�s�~�|����

    //Unity���J�f: �}�l�ƥ�(�Ŧ�W��)
    //����C����|����@��
    private void Start()
    {
        //�I�s��k: ��k�W��();
        Test();
        PrintColorText();

        print("�Ǧ^10��k���G:" + ReturnTen());
        print("�ӫ~�`��:" + CalculatePrice());

        Shoot("���y");                         //�S����ѼƷ|�H�w�]�Ȱ���
        Shoot("�q�y", "zzz");                  //�л\�Ѽ�
        Shoot("���y", effect: "snowflakes");   //���y�A���Ĺw�]�A�л\�S�İѼ�

        Attack(50);           //��Z��
        Attack(30, "���y");   //���Z��
    }

    //��k�y�k
    //�Ǧ^���� ��k�ۭq�W�� (�Ѽ�1, �Ѽ�2, ...) {��k���e}
    //�L�Ǧ^ void
    private void Test() 
    {
        //��X(��X�T��);
        print("Hello World :)");
    }

    #region ��k�m��
    private void PrintColorText()
    {
        print("<color=yellow>����T��</color>");
        print("<color=#B15BFF>����T��</color>");
        print("<i><color=#02DF82>�ź�T��</color></i>");
    }

    //�Ǧ^��k�A�����f�t return
    private int ReturnTen()
    {
        //�Ǧ^ ��� (��������������P�Ǧ^�����ۦP)
        return 10;
    }

    //�ө��t��: 99���A�p��������ӫ~����
    public int countProduct = 10;
    public int countPrice = 99;

    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion

    #region//�o�g���y�B�o�g�q�y & ���񭵮�
    private void ShootFire()
    {
        print("�o�g���y");
        print("���񭵮�");
    }

    private void ShootLighting()
    {
        print("�o�g�q�y");
        print("���񭵮�");
    }
    #endregion

    //�Ѽƻy�k: �Ѽ����� �ѼƦW�� ���w �w�]��
    //***���w�]�Ȫ��Ѽƥ�����̥k��
    private void Shoot(string type, string sound = "biu biu", string effect = "smoke")
    {
        print("�o�g:" + type);
        print("����:" + sound);
        print("�S��:" + effect);
    }

    //��k���h�� overload
    //�w�q: 1.�ۦP�W�٪���k 2.�����P�ƶq���������Ѽ�
    private void TestMethod()
    {

    }

    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("��Z�������A�����O:" + atk);
    }

    private void Attack(float atk, string ball)
    {
        print("���Z�������A�����O:" + atk);
        print("�o�g����:" + ball);
    }

}
