using UnityEngine;

public class EndLineTrigger : MonoBehaviour
{
	public GameManager gameManager;

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Car")
		{
			gameManager.CompleteLevel();
		}

	}
}