using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Peiiiii
{
    /// <summary>
    /// 血量系統:更新血量、介面與死亡處理
    /// </summary>
    public class SystemHealth : MonoBehaviour
    {
        [Header("畫布傷害物件"), SerializeField]
        private GameObject goDamage;
        [Header("圖片血量"), SerializeField]
        private Image imgHp;
        [Header("文字血量"), SerializeField]
        private TextMeshProUGUI textHp;
    }

}
