using UnityEngine;
	/// <summary>
	/// �ǲ�API �R�A���Ϊk
	/// </summary>
	public class LearnAPI : MonoBehaviour
	{
		private void Start()
		{
			//�R�A�ݩ�
			//1.Get ���o
			//�y�k:���O�W��.�R�A�ݩ�
			print($"<color=red>{Random.value}</color>");
			//2.�]�w set (����]�w)
			//�y�k:���O�W��.�R�A�ݩ� ���w ��;
			//Random.value = 0.3f; �߿W�ݩʤ���]�w
			Cursor.visible = false;
		}
	    private void Update()
	    {
		//�R�A��k
		//3. �ϥΤ�k
		//�y�k:���O�W��.�R�A��k(�����޼�)
		print(Random.Range(1, 3));
		
	    }



}

