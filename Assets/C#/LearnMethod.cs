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
    }

    //��k�y�k
    //�Ǧ^���� ��k�ۭq�W�� () {��k���e}
    //�L�Ǧ^ void
    void Test() 
    {
        //��X(��X�T��);
        print("Hello World :)");
    }

    private void PrintColorText()
    {
        print("<color=yellow>����T��</color>");
        print("<color=#B15BFF>����T��</color>");
        print("<i><color=#02DF82>�ź�T��</color></i>");
    }


}
