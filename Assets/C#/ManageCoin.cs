using UnityEngine;
using TMPro;

namespace Peiiiii
{
    /// <summary>
    /// 管理金幣:更新金幣數量
    /// </summary>
    public class ManageCoin : MonoBehaviour
    {
        /// <summary>
        /// 金幣數量
        /// </summary>
        private TextMeshProUGUI textCoin;
        /// <summary>
        /// 金幣總數
        /// </summary>
        private int totalCoin;

        private void Awake()
        {
            textCoin = GameObject.Find("coin amount").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// 添加一個金幣並更新介面
        /// </summary>
        public void AddCoinAndUpdateUI()
        {
            totalCoin++;
            textCoin.text = totalCoin.ToString();
        }
    }
}
