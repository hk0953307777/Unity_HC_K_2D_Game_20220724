
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace cat
{
   
    public class Speedcat : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("移動速度")]
        [Range(0.1f,7)]
        private float Speed = 6.5f;
        [SerializeField, Header("移動參數名稱")]
        private string parMove = "開關跑步";
        
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region 方法
        ///<summary>
        ///移動方法
        ///</summary>
        

        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            print("水平方向按鍵值:" + h);
            rig.velocity = new Vector2(h * Speed, rig.velocity.y);

            ani.SetBool(parMove, h != 0);

            //如果 水平絕對值 小於0.1就跳出
            if (Mathf.Abs(h) < 0.1f) return;

            float yAngle = h > 0 ? 0 : 180; 
            transform.eulerAngles = new Vector3(0, yAngle, 0);


        }

        #endregion
        #region 事件
        private void Awake()
        {
            //泛型方法 指任何類型 int fioat Vector2 Animator...
            //GetComponent<資料類型>()
            //作用:抓到與此腳本同樣物件上的動畫元件
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }

        //關閉事件:元件被關閉執行一次
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
            ani.SetBool(parMove, false);
        }

        #endregion




    }
}
