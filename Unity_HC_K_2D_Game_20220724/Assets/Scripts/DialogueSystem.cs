using UnityEngine;
using TMPro;

namespace Pikachu
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        /// <summary>
        /// 畫布對話
        /// </summary>
        private CanvasGroup groupDialogue;
        /// <summary>
        /// NPC 名稱
        /// </summary>
        private TextMeshProUGUI textNPC;
        /// <summary>
        /// 對話內容
        /// </summary>
        private TextMeshProUGUI textContent;

        [SerializeField, Header("對話框三角形")]
        private GameObject goTriangle;

        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC 名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
        }

    }
}

