using UnityEngine;

namespace cat
{
    /// <summary>
    /// �ǲߤ�k:�x�s�{���϶�(Code Block)�A
    /// ��k �禡 ��� �\�� Method Funtion
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        //��k�y�k:
        //�׹��� �Ǧ^��ƫ� ��k�ۭq�W�� (){ �{���϶� }
        //�L�Ǧ^���� void
        private void Test()
        {
            print("����");
        }

        //Ctrl + K + D �۰ʮ榡��(�ƪ�)

        private void Start()
        {
            //�I�s��k
            Test();
            Test();
            Test();

            float ten = ReturnTen();

            print("���G:" + ten);

        }

        private float ReturnTen()
        {
            // return �Ǧ^
            return 10.5f;

        }

    }



}