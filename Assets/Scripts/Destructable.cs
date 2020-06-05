using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject destroyedVersion;
    public void swapToBroken()
    {
        Debug.Log("Enter swaptobroken");
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Exit swaptobroken");
    }
}
