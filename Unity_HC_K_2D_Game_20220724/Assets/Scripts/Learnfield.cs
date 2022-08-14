using UnityEngine;

namespace Cat
{
    /// <summary>
    /// 學習欄位 field，保存遊戲內資料
    /// </summary>
    public class Learnfield : MonoBehaviour
    {
        //欄位語法:
        //資料類型 欄位自訂名稱;
        //資料類型 欄位自訂名稱 指定 值;
        //指定符號 = 將右邊指派給左邊
        //修飾詞 資料類型 欄位自訂名稱 指定 值;
        int number;

        //汽車資料
        //cc數
        //重量
        //品牌
        //是否有天窗
        //修飾詞預設為
        //私人 private 不顯示 不允許外部存取
        //公開 public 顯示 允許外部存取
        public int cc =1500;
        public float weight =3.5f;
        public string brand ="特斯拉";
        public bool hasSkyWindow =true;

        //欄位屬性[屬性名稱(值)]
        //1. 提示 Toolder(字串)
        //2. 標題 Header(字串)
        //3. 範圍Range(數值型態，數值型態)
        [Tooltip("這是玩家數量.....")]
        public int count;
        [Header("攻擊力")]
        [Range(0,50)]
        public float attack = 10.5f;
    }
}