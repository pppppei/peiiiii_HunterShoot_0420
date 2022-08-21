using UnityEngine;

namespace Peiiiii
{
    //ScriptObject腳本化物件:腳本內容變成物件資料存放在Project內
    //必須搭配CreateAssetMenu
    [CreateAssetMenu(menuName ="Peiiiii/DataEnemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("血量"), Range(0, 10000)]
        public float hp;
        [Header("傷害"), Range(0, 10000)]
        public float damage;
    }
}
