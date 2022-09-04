using UnityEngine;
using System.Collections;
using cat;

namespace Pikachu 
{ 
	/// <summary>
	/// NPC 系統
	/// </summary>
    public class NPC_System : MonoBehaviour
    {
		#region 公開資料
		[SerializeField, Header("開始對話按鍵")]
		private KeyCode keystartDialogue = KeyCode.E;
		[SerializeField, Header("NPC 資料")]
		private NPC_Scripts dateNPC;
		#endregion
		#region 要停止的元件
		private Speedcat Speedcat;

		private LearnJump LearnJump;     
        #endregion

        private CanvasGroup groupTip;

		private string namePlayer = "騎士";
		private bool isInArea;
		/// <summary>
		/// 是否對話中
		/// </summary>
		private bool isDialogue;

		private void Awake()
		{
			groupTip = GameObject.Find("畫布").GetComponent<CanvasGroup>();

			Speedcat = FindObjectOfType<Speedcat>();
			LearnJump = FindObjectOfType<LearnJump>();
		}

        //60FPS
        private void Update()
        {
			InputAndStartDialogue();
        }
		private void InputAndStartDialogue()
        {
			if (isDialogue) return;

			if (isInArea && Input.GetKeyDown(keystartDialogue))
            {
				isDialogue = true;

				Speedcat.enabled = false;
				LearnJump.enabled = false;

				StopAllCoroutines();
				StartCoroutine(FadeGroup(false));

			}
        }
        private void OnTriggerEnter2D(Collider2D collision)
		{
			print("<color=yellow>碰撞的物件 " + collision.gameObject + "</color>");

			if (collision.name.Contains(namePlayer))
			{
				isInArea = true;
				StopAllCoroutines();
				StartCoroutine(FadeGroup());
			}	
		}

		private void OnTriggerExit2D(Collider2D Collision)
		{
			if (Collision.name.Contains(namePlayer)) 
			{
				isInArea = false;
				StopAllCoroutines();
				StartCoroutine(FadeGroup(false));
			}
		}

		private IEnumerator FadeGroup(bool fadeIn = true) 
		{
			groupTip.alpha = fadeIn ? 0 : 1;
			float increase = fadeIn ? 0.1f : -0.1f;
            for (int i = 0; i < 10; i++)
            {
				groupTip.alpha += increase;
				yield return new WaitForSeconds(0.05f);
            }
		}
	}
}