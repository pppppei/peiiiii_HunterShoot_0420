using UnityEngine;

//汽車藍圖>物件
//場景上物件>Add Component

//欄位語法: 修飾詞 資料類型 欄位自訂名稱 指定 值 結束符號

//兩大修飾詞: public、private(預設值，可省略)
//是否允許外部存取&顯示於屬性面板

/*欄位屬性語法:[屬性名稱(值)]
1.提示 Tooltip
2.標題 Header
3.範圍 Range (僅限int/float) */

public class Car : MonoBehaviour
{
    //重量、高度、品牌、有無天窗
    [Header("汽車重量"),Tooltip("單位:噸"),Range(1,10)]
    public int weight = 3;
    [Header("汽車高度"),Tooltip("單位:公尺"),Range(1,3)]
    public float height = 2.1f;
    [Header("汽車品牌名稱")]
    public string brand = "Tesla";
    [Header("是否有天窗")]
    public bool hasSkyWindow = true;
}
