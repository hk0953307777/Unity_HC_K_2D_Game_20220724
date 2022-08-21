using UnityEngine;
	/// <summary>
	/// 學習API 靜態的用法
	/// </summary>
	public class LearnAPI : MonoBehaviour
	{
		private void Start()
		{
			//靜態屬性
			//1.Get 取得
			//語法:類別名稱.靜態屬性
			print($"<color=red>{Random.value}</color>");
			//2.設定 set (不能設定)
			//語法:類別名稱.靜態屬性 指定 值;
			//Random.value = 0.3f; 唯獨屬性不能設定
			Cursor.visible = false;
		}
	    private void Update()
	    {
		//靜態方法
		//3. 使用方法
		//語法:類別名稱.靜態方法(對應引數)
		print(Random.Range(1, 3));
		
	    }



}

