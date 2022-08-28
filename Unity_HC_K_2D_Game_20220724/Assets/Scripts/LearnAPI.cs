using UnityEngine;
	/// <summary>
	/// 學習API 靜態的用法
	/// </summary>
	public class LearnAPI : MonoBehaviour
	{
    //private Vector3 v3A = new Vector3(1, 1, 1);
    //private Vector3 v3B = new Vector3(22, 22, 22);

		private void Start()
		{
        #region 認識靜態屬性
        //靜態屬性
        //1.Get 取得
        //語法:類別名稱.靜態屬性
        print($"<color=red>{Random.value}</color>");
			//2.設定 set (不能設定)
			//語法:類別名稱.靜態屬性 指定 值;
			//Random.value = 0.3f; 唯獨屬性不能設定
			Cursor.visible = false;
         #endregion

        // 練習 取得靜態屬性 1~2
        //print($"攝影機數量{ Camera.allCamerasCount }");
	    //print($"平台{ Application.platform }");

        Physics.sleepThreshold = 10;
        Time.timeScale = 0.5f;
        //print(Mathf.Round(2.5f));
        //print(Mathf.Floor(2.5f));
        //print(Mathf.Ceil(2.5F));

        //print($"A B 點距離 { Vector3.Distance(v3A, v3B)}");

        //Application.OpenURL("https://docs.unity3d.com/ScriptReference/");




        }
	    private void Update()
	    {
        #region 認識靜態方法
        //靜態方法
        //3. 使用方法
        //語法:類別名稱.靜態方法(對應引數)
        //print(Random.Range(1, 3));
        #endregion

        //練習 取得靜態屬性 3~4
        //print($"遊戲經過時間 {Time.time}");
        //print($"是否按下任意鍵 { Input.anyKeyDown}");

        //print($"是否按下空白 {Input.GetKeyDown(KeyCode.Space)}");
    }



}

