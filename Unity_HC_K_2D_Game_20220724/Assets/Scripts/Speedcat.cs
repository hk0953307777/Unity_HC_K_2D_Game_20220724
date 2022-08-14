
using UnityEngine;

namespace cat
{
   public class Speedcat : MonoBehaviour
    {
        [SerializeField, Header("移動速度")]
        [Range(0.1f,2)]
        private float Speed = 0.5f;
        [SerializeField, Header("移動參數名稱")]
        private string perMove = "開關跑步";
        
        private Animator ani;
        private Rigidbody2D rig;




    }
}
