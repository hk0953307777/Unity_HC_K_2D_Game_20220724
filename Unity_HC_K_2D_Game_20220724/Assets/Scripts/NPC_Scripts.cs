using UnityEngine;

namespace Pikachu 
{ 
    /// <summary>
    /// NPC��� : NPC �W�ٻP��ܸ��
    /// </summary>
    [CreateAssetMenu(menuName = "Pikachu/NPC Data", fileName = "NPC Data")]
    public class NPC_Scripts : ScriptableObject
    {
        [Header("NPC �W��")]
        public string nameNPC;
        [Header("��ܤ��e"), TextArea(3, 10)]
        public string[] content;
        [Header("��v���W��")]
        public string nameCamera;

        
		
            
		

	}
}