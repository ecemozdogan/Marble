using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameManager gm;

    // Update is called once per frame
    void Update()
    {
        if (!gm.isEnded)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
