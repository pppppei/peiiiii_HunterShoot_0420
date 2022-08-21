using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Peiiiii
{
    /// <summary>
    /// ��q�t��:��s��q�B�����P���`�B�z
    /// </summary>
    public class SystemHealth : MonoBehaviour
    {
        [Header("�e���ˮ`����"), SerializeField]
        private GameObject goDamage;
        [Header("�Ϥ���q"), SerializeField]
        private Image imgHp;
        [Header("��r��q"), SerializeField]
        private TextMeshProUGUI textHp;
        [Header("�Ǫ����"), SerializeField]
        private DataEnemy dataEnemy;

        private float hp;

        private void Awake()
        {
            hp = dataEnemy.hp; 
            textHp.text = hp.ToString();
        }

        //�I���ƥ�
        //1. ��Ӫ��󥲶����@�ӱa��Rigibody
        //2. ��Ӫ��󥲶����I���� Collider
        //3. �O�_�Ŀ� Is Trigger
        //  3-1. ��̳��S�Ŀ�Is Trigger�ϥ�OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            //print("�I���쪺����:" + collision.gameObject);

            GetDamage();
        }

        /// <summary>
        /// ����
        /// </summary>
        private void GetDamage()
        {
            hp -= 50;
            //print("��q�ѤU:" + hp);
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;

            if (hp <= 0) Dead();
        }

        private void Dead()
        {
            print("���`");
        }
    }

}
