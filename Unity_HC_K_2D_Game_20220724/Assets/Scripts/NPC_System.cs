using UnityEngine;
using System.Collections;
using cat;

namespace Pikachu 
{ 
	/// <summary>
	/// NPC �t��
	/// </summary>
    public class NPC_System : MonoBehaviour
    {
		#region ���}���
		[SerializeField, Header("�}�l��ܫ���")]
		private KeyCode keystartDialogue = KeyCode.E;
		[SerializeField, Header("NPC ���")]
		private NPC_Scripts dateNPC;
		#endregion
		#region �n�������
		private Speedcat Speedcat;

		private LearnJump LearnJump;     
        #endregion

        private CanvasGroup groupTip;

		private string namePlayer = "�M�h";
		private bool isInArea;
		/// <summary>
		/// �O�_��ܤ�
		/// </summary>
		private bool isDialogue;

		private void Awake()
		{
			groupTip = GameObject.Find("�e��").GetComponent<CanvasGroup>();

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
			print("<color=yellow>�I�������� " + collision.gameObject + "</color>");

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