using UnityEngine;

namespace Cat
{
    /// <summary>
    /// �ǲ���� field�A�O�s�C�������
    /// </summary>
    public class Learnfield : MonoBehaviour
    {
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
        [Range(0,50)]
        public float attack = 10.5f;
    }
}