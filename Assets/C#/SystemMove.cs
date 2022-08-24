using UnityEngine;
using System.Collections;

namespace Peiiiii
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class SystemMove : MonoBehaviour
    {
        /// <summary>
        /// �^�X�t��
        /// </summary>
        private SystemTurn systemTurn;
        /// <summary>
        /// ���ʶZ��
        /// </summary>
        private float moveDistance = 2;
        /// <summary>
        /// ���ʶ��j
        /// </summary>
        private float moveInterval = 0.03f;

        private void Awake()
        {
            systemTurn = GameObject.Find("�^�X�t��").GetComponent<SystemTurn>();
            systemTurn.onTurnEnemy.AddListener(() => { StartCoroutine(Move()); });
        }

        /// <summary>
        /// ����
        /// </summary>
        private IEnumerator Move()
        {
            //print(gameObject + "���e����");
            float moveCount = 10;
            float perDistance = moveDistance / moveCount;

            for (int i = 0; i < moveCount; i++)
            {
                transform.position -= new Vector3(0, 0, perDistance);
                yield return new WaitForSeconds(moveInterval);
            }

            yield return new WaitForSeconds(1.0f);

            systemTurn.MoveEndSpawnEnemy();
        }
    }
}
