using UnityEngine;
using System.Collections;

//�R�W�Ŷ�: namespace �Ŷ��W�� {�ӪŶ����e}
namespace Pei
{
    /// <summary>
    /// ���a����t��
    /// �������B�o�g�u�]
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region ���
        [Header("�b�Y")]
        public GameObject arrow;
        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;
        [Header("�u�]�w�m��")]
        public GameObject marble;
        [Header("�u�]�i�o�g�`��"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        [Header("�u�]�ͦ��I")]
        public Transform traSpawnPoint;
        [Header("�����ѼƦW��")]
        public string parAttack = "Trigger_����";
        [Header("�u�]�o�g�t��"), Range(0, 5000)]
        public float speedMarble = 1000;
        [Header("�u�]�o�g���j"), Range(0, 2)]
        public float intervalMarble = 0.5f;

        public Animator ani;
        #endregion

        #region �ƥ�
        //Awake�bStart���e����@��
        private void Awake()
        {
            ani = GetComponent <Animator>();
        }

        private void Update()
        {
            ShootMarble();
        }
        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��A�����⭱�V�ƹ���m
        /// </summary>
        private void TurnCharacter()
        {

        }
        /// <summary>
        /// �o�g�u�]�A�ھ��`�Ƶo�g�u�]����
        /// </summary>
        private void ShootMarble()
        {
            //���U�ƹ�����,��ܽb�Y
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }
            //��}�ƹ�����A�ͦ��õo�g�u�]
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                //print("��}����");
                arrow.SetActive(false);
                StartCoroutine(SpawnMarble());
            }
        }

        /// <summary>
        /// �ͦ��u�]���a���j�ɶ�
        /// </summary>
        private IEnumerator SpawnMarble()
        {
            for (int i = 0; i < canShootMarbleTotal; i++)
            {
                ani.SetTrigger(parAttack);
                //Object ���O�i�ٲ����g
                //�����z�L Object �����W�٨ϥ�
                //�ͦ�(�u�]);
                //Quaternion.identity �s����
                GameObject tempMarble = Instantiate(marble,traSpawnPoint.position,Quaternion.identity);
                //�Ȧs�u�] ���o���餸�� �K�[���O(����.�e��*�t��)
                //transform.forward ����e��
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                yield return new WaitForSeconds(intervalMarble);
            }
        }
        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }
        #endregion

    }
}
