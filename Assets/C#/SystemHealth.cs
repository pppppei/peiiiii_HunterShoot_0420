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
        [Header("�ĤH�ʵe���"), SerializeField]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "Trigger_����";

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
            float getDamage = 50;
            hp -= getDamage;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);
            Vector3 pos = transform.position + Vector3.up;
            SystemDamage tempDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            tempDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }

        private void Dead()
        {
            print("���`");
        }
    }

}
