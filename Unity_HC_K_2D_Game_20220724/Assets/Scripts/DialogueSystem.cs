using UnityEngine;
using TMPro;

namespace Pikachu
{
    /// <summary>
    /// ��ܨt��
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        /// <summary>
        /// �e�����
        /// </summary>
        private CanvasGroup groupDialogue;
        /// <summary>
        /// NPC �W��
        /// </summary>
        private TextMeshProUGUI textNPC;
        /// <summary>
        /// ��ܤ��e
        /// </summary>
        private TextMeshProUGUI textContent;

        [SerializeField, Header("��ܮؤT����")]
        private GameObject goTriangle;

        private void Awake()
        {
            groupDialogue = GameObject.Find("�e�����").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC �W��").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
        }

    }
}

