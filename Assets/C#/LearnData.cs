//沛，20220516
using UnityEngine;

//註解，藍字保留字、白色名稱、綠色資料類型
//欄位語法: 修飾詞 資料類型 欄位自訂名稱 指定 值 結束符號
public class LearnData : MonoBehaviour
{
    //儲存資料方式:欄位field
    //定義整數資料叫hp
    int hp = 100;

    //int:+-整數
    //float:+-小數點(後面加f)
    //string:文字(加"")
    //bool:T/F
    int lv = 50;
    float exp = 0.02f;
    string playerName = "@Pei16";
    bool hasCureSkill = true;
}
