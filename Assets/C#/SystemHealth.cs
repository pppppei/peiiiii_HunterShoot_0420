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
    }

}
