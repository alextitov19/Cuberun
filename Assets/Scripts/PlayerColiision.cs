using UnityEngine;

public class PlayerColiision : MonoBehaviour {

    public Destructable destructable;
       void OnCollisionEnter (Collision collisionInfo) 
        {
            if (collisionInfo.collider.tag == "Obstacle")
             {
                FindObjectOfType<Destructable>().swapToBroken();
                GetComponent<PlayerMovement>().enabled = false;
                FindObjectOfType<GameManager>().endGame();
             }
        }
   
}
