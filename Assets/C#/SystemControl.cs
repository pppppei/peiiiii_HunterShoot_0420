using UnityEngine;

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
        #endregion

        #region �ƥ�
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
