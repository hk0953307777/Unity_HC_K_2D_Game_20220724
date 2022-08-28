using UnityEngine;

public class LearnJump : MonoBehaviour
{
    #region ���
    [SerializeField, Header("���D����"), Range(0, 10000)]
    private float jump = 5;
    [SerializeField, Header("���D�ѼƦW��")]
    private string parJump = "�}�����D";

    private Animator ani;
    private Rigidbody2D rig;

    #endregion
    #region �ˬd�a�O���
    [SerializeField, Header("�ˬd�a�O�C��")]
    private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [SerializeField] private Vector3 checkGroundSize;
    [SerializeField] private Vector3 checkGoundOffset;
    [SerializeField, Header("�ˬd�a�O�ϼh")]
    private LayerMask checkGoundLayer;

    private bool isGrounded;    
    #endregion

    #region �ƥ�
    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = checkGroundColor;
        Gizmos.DrawCube(
            transform.position + checkGoundOffset,
            checkGroundSize);
    }
    private void Update()
    {
        CheckGround();
        Jump();

    }
    #endregion

    #region ��k
    /// <summary>
    /// �ˬd�a�O
    /// </summary>
    private void CheckGround()
    {
        Collider2D hit = Physics2D.OverlapBox(
            transform.position + checkGoundOffset,
            checkGroundSize, 0);
        //print("<color=red>�I�쪺����" + hit + "</color>");
        isGrounded = hit;
    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        //�p�G �b�a�O�W �åB ���U�ť��� �N���D
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion
}
