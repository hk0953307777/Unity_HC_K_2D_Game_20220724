using UnityEngine;

namespace pikachu
{
    /// <summary>
    /// �ǲ߫D�R�A API
    /// �P�R�A���t�O:�ݭn�����骫��
    /// </summary>
    public class LearnAPINO : MonoBehaviour
    {
        //1.�����O�����
        //2.�ݩʭ��O�������o���骫��
        //3.�ϥΫD�R�A�ݩʩΤ�k
        public GameObject goKnight;

        public Camera cam;
        public SphereCollider sphereCollider;
        public Transform traCapsule;

        public Transform traCube, traSphere;
        public Rigidbody rigCapsule;
         

        private void Start()
        {
            //�D�R�A�ݩ�
            //1. ���o Get
            // �y�k:���W�� �D�R�A�ݩ�
            print($"�M�h�ϼh {goKnight.layer}");

            // 2. �]�w Set
            //�y�k:���W��.�D�R�A�ݩ� ���w �� ;
            goKnight.layer = 4;

            //�D�R�A��k
            //3. �ϥ�
            //�y�k:���W��.�D�R�A��k(�����޼�)
            goKnight.SetActive(false);

            //print($"Camera Depth { cam.depth }");
            //print($"�y��b�| { sphereCollider.radius }");

            cam.backgroundColor = Random.ColorHSV();
            traCube.localScale = new Vector3(3, 2, 1);
        }

        private void Update()
        {
            //traCube.RotateAround(traSphere.position, traSphere.forward, 5);
            //rigCapsule.AddForce(new Vector3(0, 10, 0));
        }

    }
    
}