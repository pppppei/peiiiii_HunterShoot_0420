using UnityEngine;
using TMPro;

namespace Peiiiii
{
    /// <summary>
    /// �޲z����:��s�����ƶq
    /// </summary>
    public class ManageCoin : MonoBehaviour
    {
        /// <summary>
        /// �����ƶq
        /// </summary>
        private TextMeshProUGUI textCoin;
        /// <summary>
        /// �����`��
        /// </summary>
        private int totalCoin;

        private void Awake()
        {
            textCoin = GameObject.Find("coin amount").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// �K�[�@�Ӫ����ç�s����
        /// </summary>
        public void AddCoinAndUpdateUI()
        {
            totalCoin++;
            textCoin.text = totalCoin.ToString();
        }
    }
}
