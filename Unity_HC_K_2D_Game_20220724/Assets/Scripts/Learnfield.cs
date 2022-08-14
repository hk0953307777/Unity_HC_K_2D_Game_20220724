using UnityEngine;

namespace Cat
{
   
    /// <summary>
    /// 學習欄位 field，保存遊戲內資料
    /// </summary>
    public class Learnfield : MonoBehaviour
    { 
        #region 欄位基礎語法
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
        [Range(1, 999)]
        public float attack = 10.5f;
        [Header("武器名稱")]
        [Tooltip("玩家武器")]
        public string weapon = "小刀";
        [Header("是否死亡"), Tooltip("玩家是否死亡")]
        public bool isDead = false;

        //C#  00P 物件導向程式設計
        // 三大特性:繼承 封裝 多型
        //封裝:將該類別的內容封閉在類別內僅供外不需要的窗口
        public string password = "123456789";

        /// <summary>
        /// 序列化欄位，封裝此資料但顯示資料在屬性面板
        /// </summary>
        [SerializeField]
        private int speed = 10;
        #endregion
        #region Unity 內資料類型
        //儲存物件
        public GameObject goCamer;

        //顏色與座標
        public Color color;
        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorCustom = new Color(0.5f, 0.5f, 0);
        public Color colorCustomAlpha = new Color(0, 0, 1, 0.5f);

        public Vector2 v2;
        public Vector2 v2Right = Vector2.right;  // 1, 0
        public Vector2 v2Up = Vector2.up;        // 0, 1
        public Vector2 v2Custom = new Vector2(9, 1);

        public Vector3 v3Custom = new Vector3(9, 10, 11);
        public Vector3 v3Right = Vector3.right;

        public Vector4 v4Custom = new Vector4(1, 2, 3, 4);

        //多選與列舉
        public LayerMask layer;

        public LightType lightType;
        public LightType lightTypeArea = LightType.Area;
        public KeyCode keyA;
        public KeyCode keyJump = KeyCode.Space;
        #endregion
    }
}