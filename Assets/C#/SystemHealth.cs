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
        #region ���
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

        #endregion

        /// <summary>
        /// �I��|���˪�����W��
        /// </summary>
        [Header("�I��|���˪�����W��"),SerializeField]
        private string nameHurtObject;

        [Header("���a�����ˮ`�ϰ�")]
        [SerializeField] private Vector3 v3DamageSize;
        [SerializeField] private Vector3 v3DamagePosition;
        [Header("�����ˮ`���ϼh"), SerializeField]
        private LayerMask LayerDamage;

        private SystemSpawn systemSpawn;

        private void OnDrawGizmos()
        {
            //�u���bunity�W�ݱo���C���l
            Gizmos.color = new Color(0.2f, 1, 0.2f, 0.5f);
            Gizmos.DrawCube(v3DamagePosition, v3DamageSize);
        }

        private void Awake()
        {
            hp = dataEnemy.hp; 
            textHp.text = hp.ToString();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
        }

        private void Update()
        {
            CheckObjectInDamageArea();
        }

        //�I���ƥ�
        //1. ��Ӫ��󥲶����@�ӱa��Rigibody
        //2. ��Ӫ��󥲶����I���� Collider
        //3. �O�_�Ŀ� Is Trigger
        //  3-1. ��̳��S�Ŀ�Is Trigger�ϥ�OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            //print("�I���쪺����:" + collision.gameObject);
            if(collision.gameObject.name.Contains(nameHurtObject))
               GetDamage(collision.gameObject.GetComponent<SystemAttack>().valueAttack);
        }

        /// <summary>
        /// �ˬd����O�_�ɨ���˰ϰ�
        /// </summary>
        private void CheckObjectInDamageArea()
        {
            Collider[] hits = Physics.OverlapBox(
                v3DamagePosition, v3DamageSize / 2, 
                Quaternion.identity, LayerDamage);

            if (hits.Length > 0)
            {
                GetDamage(hits[0].GetComponent<SystemAttack>().valueAttack);
                Destroy(hits[0].gameObject);
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        private void GetDamage(float getDamage)
        {
            hp -= getDamage;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);
            Vector3 pos = transform.position + Vector3.up;
            SystemDamage tempDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            tempDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }

        /// <summary>
        /// ���`
        /// </summary>
        private void Dead()
        {
            //print("���`");
            Destroy(gameObject);
            systemSpawn.totalCountEnemyLive--;
            //print("<color=red>�Ǫ��ƶq:" + systemSpawn.totalCountEnemyLive + "</color>");
            DropCoin();
        }

        /// <summary>
        /// ��������
        /// </summary>
        private void DropCoin()
        {
            int range = Random.Range(dataEnemy.v2CoinRange.x, dataEnemy.v2CoinRange.y);

            for (int i = 0; i < range; i++)
            {
                float x = Random.Range(-1, 1);
                float z = Random.Range(-1, 1);

                Instantiate(
                    dataEnemy.goCoin,
                    transform.position + new Vector3(x, 2.5f, z),
                    Quaternion.Euler(-90, 0, 0));
            }
        }
    }

}
