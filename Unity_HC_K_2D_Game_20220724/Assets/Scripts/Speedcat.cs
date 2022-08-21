
using UnityEngine;

namespace cat
{
   
    public class Speedcat : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("移動速度")]
        [Range(0.1f,2)]
        private float Speed = 0.5f;
        [SerializeField, Header("移動參數名稱")]
        private string perMove = "開關跑步";
        
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region 方法
        ///<summary>
        ///移動方法
        ///</summary>
        

        private void Move()
        {

        }

        #endregion
        #region 事件
        private void Awake()
        {
            
        }

        private void Update()
        {
            
        }

        #endregion




    }
}
