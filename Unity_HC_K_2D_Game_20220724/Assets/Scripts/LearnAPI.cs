using UnityEngine;
	/// <summary>
	/// �ǲ�API �R�A���Ϊk
	/// </summary>
	public class LearnAPI : MonoBehaviour
	{
    //private Vector3 v3A = new Vector3(1, 1, 1);
    //private Vector3 v3B = new Vector3(22, 22, 22);

		private void Start()
		{
        #region �{���R�A�ݩ�
        //�R�A�ݩ�
        //1.Get ���o
        //�y�k:���O�W��.�R�A�ݩ�
        print($"<color=red>{Random.value}</color>");
			//2.�]�w set (����]�w)
			//�y�k:���O�W��.�R�A�ݩ� ���w ��;
			//Random.value = 0.3f; �߿W�ݩʤ���]�w
			Cursor.visible = false;
         #endregion

        // �m�� ���o�R�A�ݩ� 1~2
        //print($"��v���ƶq{ Camera.allCamerasCount }");
	    //print($"���x{ Application.platform }");

        Physics.sleepThreshold = 10;
        Time.timeScale = 0.5f;
        //print(Mathf.Round(2.5f));
        //print(Mathf.Floor(2.5f));
        //print(Mathf.Ceil(2.5F));

        //print($"A B �I�Z�� { Vector3.Distance(v3A, v3B)}");

        //Application.OpenURL("https://docs.unity3d.com/ScriptReference/");




        }
	    private void Update()
	    {
        #region �{���R�A��k
        //�R�A��k
        //3. �ϥΤ�k
        //�y�k:���O�W��.�R�A��k(�����޼�)
        //print(Random.Range(1, 3));
        #endregion

        //�m�� ���o�R�A�ݩ� 3~4
        //print($"�C���g�L�ɶ� {Time.time}");
        //print($"�O�_���U���N�� { Input.anyKeyDown}");

        //print($"�O�_���U�ť� {Input.GetKeyDown(KeyCode.Space)}");
    }



}

