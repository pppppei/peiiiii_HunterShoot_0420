using UnityEngine;

public class LearnMethod : MonoBehaviour
{    //自訂方式，需要呼叫才會執行

    //Unity的入口: 開始事件(藍色名稱)
    //播放遊戲後會執行一次
    private void Start()
    {
        //呼叫方法: 方法名稱();
        Test();
        PrintColorText();

        print("傳回10方法結果:" + ReturnTen());
        print("商品總價:" + CalculatePrice());

        Shoot("火球");                         //沒有填參數會以預設值執行
        Shoot("電球", "zzz");                  //覆蓋參數
        Shoot("雪球", effect: "snowflakes");   //雪球，音效預設，覆蓋特效參數

        Attack(50);           //近距離
        Attack(30, "火球");   //遠距離
    }

    //方法語法
    //傳回類型 方法自訂名稱 (參數1, 參數2, ...) {方法內容}
    //無傳回 void
    private void Test() 
    {
        //輸出(輸出訊息);
        print("Hello World :)");
    }

    #region 方法練習
    private void PrintColorText()
    {
        print("<color=yellow>黃色訊息</color>");
        print("<color=#B15BFF>紫色訊息</color>");
        print("<i><color=#02DF82>藍綠訊息</color></i>");
    }

    //傳回方法，必須搭配 return
    private int ReturnTen()
    {
        //傳回 資料 (此資料類型必須與傳回類型相同)
        return 10;
    }

    //商店系統: 99元，計算全部的商品價格
    public int countProduct = 10;
    public int countPrice = 99;

    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion

    #region//發射火球、發射電球 & 播放音效
    private void ShootFire()
    {
        print("發射火球");
        print("播放音效");
    }

    private void ShootLighting()
    {
        print("發射電球");
        print("播放音效");
    }
    #endregion

    //參數語法: 參數類型 參數名稱 指定 預設值
    //***有預設值的參數必須放最右邊
    private void Shoot(string type, string sound = "biu biu", string effect = "smoke")
    {
        print("發射:" + type);
        print("音效:" + sound);
        print("特效:" + effect);
    }

    //方法的多載 overload
    //定義: 1.相同名稱的方法 2.有不同數量或類型的參數
    private void TestMethod()
    {

    }

    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("近距離攻擊，攻擊力:" + atk);
    }

    private void Attack(float atk, string ball)
    {
        print("遠距離攻擊，攻擊力:" + atk);
        print("發射物件:" + ball);
    }

}
