using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Destructable destructable;
    PlayerScript ps;

    private void Awake()
    {
        ps = gameObject.GetComponent<PlayerScript>();
        Debug.Log("PS successfully inited");
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
            if (collisionInfo.collider.tag == "Obstacle")
             {
                FindObjectOfType<Destructable>().swapToBroken(collisionInfo.collider.gameObject);
                GetComponent<PlayerMovement>().enabled = false;
                FindObjectOfType<GameManager>().endGame();
             }

            if (collisionInfo.collider.tag == "Coin")
            {
                Destroy(collisionInfo.collider.gameObject);
                ps.AddCoins(1);
                ps.AddXP(5);
            }
    }
   
}
