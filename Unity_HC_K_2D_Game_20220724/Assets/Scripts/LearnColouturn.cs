using UnityEngine;
using System.Collections;   //1.�ޥΨt�ζ��X

namespace Pikachu
{
	/// <summary>
	/// �ǲߨ�P�{��
	/// </summary>
	public class LearnColouturn : MonoBehaviour
	{
		private void Awake()
		{
			StartCoroutine(Test());
		}

		private IEnumerator Test() 
		{
			print("�Ĥ@�q�{��");

			yield return new WaitForSeconds(3);

			print("�T������ĤG�q");

			yield return new WaitForSeconds(4);

			print("�|������ĤG�q");
		}

	}

}