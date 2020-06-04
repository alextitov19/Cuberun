using UnityEngine;

public class PlayerColiision : MonoBehaviour {


       void OnCollisionEnter (Collision collisionInfo) 
        {
            if (collisionInfo.collider.tag == "Obstacle")
             {
                GetComponent<PlayerMovement>().enabled = false;
                FindObjectOfType<GameManager>().endGame();
             }
        }
   
}
