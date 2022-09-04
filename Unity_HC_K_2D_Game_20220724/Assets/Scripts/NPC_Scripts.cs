using UnityEngine;

namespace Pikachu 
{ 
    /// <summary>
    /// NPC資料 : NPC 名稱與對話資料
    /// </summary>
    [CreateAssetMenu(menuName = "Pikachu/NPC Data", fileName = "NPC Data")]
    public class NPC_Scripts : ScriptableObject
    {
        [Header("NPC 名稱")]
        public string nameNPC;
        [Header("對話內容"), TextArea(3, 10)]
        public string[] content;
        [Header("攝影機名稱")]
        public string nameCamera;

        
		
            
		

	}
}