using UnityEngine;

namespace Cat
{
   
    /// <summary>
    /// �ǲ���� field�A�O�s�C�������
    /// </summary>
    public class Learnfield : MonoBehaviour
    { 
        #region ����¦�y�k
        //���y�k:
        //������� ���ۭq�W��;
        //������� ���ۭq�W�� ���w ��;
        //���w�Ÿ� = �N�k�����������
        //�׹��� ������� ���ۭq�W�� ���w ��;
        int number;

        //�T�����
        //cc��
        //���q
        //�~�P
        //�O�_���ѵ�
        //�׹����w�]��
        //�p�H private ����� �����\�~���s��
        //���} public ��� ���\�~���s��
        public int cc =1500;
        public float weight =3.5f;
        public string brand ="�S����";
        public bool hasSkyWindow =true;

        //����ݩ�[�ݩʦW��(��)]
        //1. ���� Toolder(�r��)
        //2. ���D Header(�r��)
        //3. �d��Range(�ƭȫ��A�A�ƭȫ��A)
        [Tooltip("�o�O���a�ƶq.....")]
        public int count;
        [Header("�����O")]
        [Range(1, 999)]
        public float attack = 10.5f;
        [Header("�Z���W��")]
        [Tooltip("���a�Z��")]
        public string weapon = "�p�M";
        [Header("�O�_���`"), Tooltip("���a�O�_���`")]
        public bool isDead = false;

        //C#  00P ����ɦV�{���]�p
        // �T�j�S��:�~�� �ʸ� �h��
        //�ʸ�:�N�����O�����e�ʳ��b���O���Ȩѥ~���ݭn�����f
        public string password = "123456789";

        /// <summary>
        /// �ǦC�����A�ʸ˦���Ʀ���ܸ�Ʀb�ݩʭ��O
        /// </summary>
        [SerializeField]
        private int speed = 10;
        #endregion
        #region Unity ���������
        //�x�s����
        public GameObject goCamer;

        //�C��P�y��
        public Color color;
        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorCustom = new Color(0.5f, 0.5f, 0);
        public Color colorCustomAlpha = new Color(0, 0, 1, 0.5f);

        public Vector2 v2;
        public Vector2 v2Right = Vector2.right;  // 1, 0
        public Vector2 v2Up = Vector2.up;        // 0, 1
        public Vector2 v2Custom = new Vector2(9, 1);

        public Vector3 v3Custom = new Vector3(9, 10, 11);
        public Vector3 v3Right = Vector3.right;

        public Vector4 v4Custom = new Vector4(1, 2, 3, 4);

        //�h��P�C�|
        public LayerMask layer;

        public LightType lightType;
        public LightType lightTypeArea = LightType.Area;
        public KeyCode keyA;
        public KeyCode keyJump = KeyCode.Space;
        #endregion
    }
}