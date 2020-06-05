using UnityEngine;

public class PlayerColiision : MonoBehaviour {

    public Destructable destructable;
       void OnCollisionEnter (Collision collisionInfo) 
        {
            if (collisionInfo.collider.tag == "Obstacle")
             {
                FindObjectOfType<Destructable>().swapToBroken(collisionInfo.collider.gameObject);
                GetComponent<PlayerMovement>().enabled = false;
                FindObjectOfType<GameManager>().endGame();
             }
        }
   
}
