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
        #region 資料
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

        #endregion

        /// <summary>
        /// 碰到會受傷的物件名稱
        /// </summary>
        [Header("碰到會受傷的物件名稱"),SerializeField]
        private string nameHurtObject;

        [Header("玩家接收傷害區域")]
        [SerializeField] private Vector3 v3DamageSize;
        [SerializeField] private Vector3 v3DamagePosition;
        [Header("接受傷害的圖層"), SerializeField]
        private LayerMask LayerDamage;

        private SystemSpawn systemSpawn;

        private void OnDrawGizmos()
        {
            //只有在unity上看得到顏色格子
            Gizmos.color = new Color(0.2f, 1, 0.2f, 0.5f);
            Gizmos.DrawCube(v3DamagePosition, v3DamageSize);
        }

        private void Awake()
        {
            hp = dataEnemy.hp; 
            textHp.text = hp.ToString();
            systemSpawn = GameObject.Find("生成怪物系統").GetComponent<SystemSpawn>();
        }

        private void Update()
        {
            CheckObjectInDamageArea();
        }

        //碰撞事件
        //1. 兩個物件必須有一個帶有Rigibody
        //2. 兩個物件必須有碰撞器 Collider
        //3. 是否勾選 Is Trigger
        //  3-1. 兩者都沒勾選Is Trigger使用OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            //print("碰撞到的物件:" + collision.gameObject);
            if(collision.gameObject.name.Contains(nameHurtObject))
               GetDamage(collision.gameObject.GetComponent<SystemAttack>().valueAttack);
        }

        /// <summary>
        /// 檢查物件是否盡到受傷區域
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
        /// 受傷
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
        /// 死亡
        /// </summary>
        private void Dead()
        {
            //print("死亡");
            Destroy(gameObject);
            systemSpawn.totalCountEnemyLive--;
            //print("<color=red>怪物數量:" + systemSpawn.totalCountEnemyLive + "</color>");
            DropCoin();
        }

        /// <summary>
        /// 掉落金幣
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
