using UnityEngine;

namespace cat
{
    /// <summary>
    /// 學習方法:儲存程式區塊(Code Block)，
    /// 方法 函式 函數 功能 Method Funtion
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        //方法語法:
        //修飾詞 傳回資料型 方法自訂名稱 (){ 程式區塊 }
        //無傳回類型 void
        private void Test()

        {
            print("測試");
        }

        //Ctrl + K + D 自動格式化(排版)

        private void Start()
        {
            //呼叫方法
            Test();
            Test();
            Test();

            float ten = ReturnTen();

            print("結果:" + ten);

            AddTen(7);
            Add(100, 300);
            Add(50, 999);
            Skill("火球");
            Skill("冰球");
            Skill("電球", "滋滋滋");


        }

        private float ReturnTen()
        {
            // return 傳回
            return 10.5f;
        }

        private void AddTen(float number)
        {
            number = number + 10;
            //print("加十的結果:" + number);
        }

        private void Add(float numberA, float numberB)
        {
            //print("<color=yellow>數字相加的結果" + (numberA +numberB) + "</color>");
        
        }

        //施放技能:火球 冰球 電球...
        //有預設值的參數:選擇式參數-必須寫在右邊，呼叫時不填會以預設帶入
        private void Skill(string skillType, string sound = "哒哒哒")
        {
            //print("施放技能特效:" + skillType);
            //print("技能音效:" + sound);
        }
    }

}