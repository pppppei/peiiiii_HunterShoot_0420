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
    }

    //方法語法
    //傳回類型 方法自訂名稱 () {方法內容}
    //無傳回 void
    void Test() 
    {
        //輸出(輸出訊息);
        print("Hello World :)");
    }

    private void PrintColorText()
    {
        print("<color=yellow>黃色訊息</color>");
        print("<color=#B15BFF>紫色訊息</color>");
        print("<i><color=#02DF82>藍綠訊息</color></i>");
    }


}
