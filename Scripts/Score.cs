using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        float new_result = player.position.z / 5f;
        scoreText.text = new_result.ToString("0");
    }
}