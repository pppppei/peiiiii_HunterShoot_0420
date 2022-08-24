using UnityEngine;
using System.Collections;
using TMPro;

//�R�W�Ŷ�: namespace �Ŷ��W�� {�ӪŶ����e}
namespace Peiiiii
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
        public float speedMarble = 4200;
        [Header("�u�]�o�g���j"), Range(0, 2)]
        public float intervalMarble = 0.2f;
        [Header("�u�]�ƶq")]
        public TextMeshProUGUI textMarbleCount;

        private Animator ani;        
        
        /// <summary>
        /// ��_�o�g�u�]
        /// </summary>
        [HideInInspector]
        public bool canShootMarble = true;

        /// <summary>
        /// �ഫ�ƹ�����v��
        /// </summary>
        private Camera cameraMouse;
        /// <summary>
        /// �y���ഫ����骫��
        /// </summary>
        private Transform traMouse;

        #endregion

        #region �ƥ�
        //Awake�bStart���e����@��
        private void Awake()
        {
            ani = GetComponent <Animator>();

            textMarbleCount.text = "x" + canShootMarbleTotal;

            cameraMouse = GameObject.Find("�ഫ�ƹ�����v��").GetComponent<Camera>();
            //traMouse = GameObject.Find("�y���ഫ����骫��").GetComponent<Transform>();
            traMouse = GameObject.Find("�y���ഫ����骫��").transform;

            Physics.IgnoreLayerCollision(3, 3);
        }

        private void Update()
        {
            ShootMarble();
            TurnCharacter();
        }
        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��A�����⭱�V�ƹ���m
        /// </summary>
        private void TurnCharacter()
        {
            //�p�G ����o�g �N���X
            if (!canShootMarble) return;
            //1.�ƹ��y��
            Vector3 posMouse = Input.mousePosition;
            //print("<color=blue>�ƹ��y��:" + posMouse + "</color>");
            //����v����y�b�@��
            posMouse.z = 30;
            //2.�ƹ��y���ର�@�ɮy��
            Vector3 pos = cameraMouse.ScreenToWorldPoint(posMouse);
            //�N�ഫ�����@�ɮy�а��׳]�w�����⪺����
            pos.y = 0.5f;
            //3.�@�ɮy�е����骫��
            traMouse.position = pos;
            //�������ܧ�.���V(�y���ഫ����骫��)
            transform.LookAt(traMouse);
        }
        /// <summary>
        /// �o�g�u�]�A�ھ��`�Ƶo�g�u�]����
        /// </summary>
        private void ShootMarble()
        {

            //�p�G ����o�g�u�] �N���X
            if (!canShootMarble) return;

            //���U�ƹ�����,��ܽb�Y
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }
            //��}�ƹ�����A�ͦ��õo�g�u�]
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                //����o�g�u�]
                canShootMarble = false;

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
            int total = canShootMarbleTotal;

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

                total--;

                if (total > 0) textMarbleCount.text = "x" + total;
                else if (total == 0) textMarbleCount.text = "";

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
