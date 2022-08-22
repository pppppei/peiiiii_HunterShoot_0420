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
        [Header("怪物資料"), SerializeField]
        private DataEnemy dataEnemy;
        [Header("敵人動畫控制器"), SerializeField]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "Trigger_受傷";

        private void Awake()
        {
            hp = dataEnemy.hp; 
            textHp.text = hp.ToString();
        }

        //碰撞事件
        //1. 兩個物件必須有一個帶有Rigibody
        //2. 兩個物件必須有碰撞器 Collider
        //3. 是否勾選 Is Trigger
        //  3-1. 兩者都沒勾選Is Trigger使用OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            //print("碰撞到的物件:" + collision.gameObject);

            GetDamage();
        }

        /// <summary>
        /// 受傷
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
            print("死亡");
        }
    }

}
