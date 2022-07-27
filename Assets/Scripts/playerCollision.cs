using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public followPlayer maincamera;
    public Score score;

    void OnCollisionEnter(Collision collisionItem){

        if(collisionItem.collider.tag == "Obstacle"){
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
