using UnityEngine;

/// <summary>
/// 學習運算子
/// 1. 數學運算子
/// 2. 比較運算子
/// 3. 邏輯運算子
/// </summary>
public class LearnOperator: MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private int c = 99;
    private int d = 1;

    private int diamond = 1;
    private int hp = 100;

    private void Start()
    {
        #region 數學運算子
        // 加+ 減- 乘* 除/ 餘%
        print("加法:" + (a + b));
        print("減法:" + (a - b));
        print("乘法:" + (a * b));
        print("除法:" + (a / b));
        print("餘法:" + (a % b));
        #endregion

        #region 比較運算子
        //小於< 大於> 小於等於<= 大於等於>= 不等於!= 等於==
        print("小於:" + (c < d));      //f
        print("大於:" + (c > d));      //t
        print("小於等於:" + (c <= d)); //f
        print("大於等於:" + (c >= d)); //t
        print("不等於:" + (c != d));   //t
        print("等於:" + (c == d));     //f
        #endregion

        #region 邏輯運算子
        //邏輯運算子，針對布林值
        //並且 &&: 兩個布林值有一個false 結果就是false
        print("true && true:" + (true && true));     //t
        print("true && false:" + (true && false));   //f
        print("false && true:" + (false && true));   //f
        print("false && false:" + (false && false)); //f

        //或者||: 兩個布林值有一個true 結果就是true
        print("true || true:" + (true || true));     //t
        print("true || false:" + (true || false));   //t
        print("false || true:" + (false || true));   //t
        print("false || false:" + (false || false)); //f

        //遊戲範例: 勝利條件: 寶石>= 3顆 並且 血量 大於 0 才能過關
        print("是否過關:" + (diamond >= 3 && hp > 0)); //f

        //顛倒運算子!: 將布林質變相反
        print("!true:" + (!true));   //f
        print("!false:" + (!false)); //t

        #endregion
    }
}
