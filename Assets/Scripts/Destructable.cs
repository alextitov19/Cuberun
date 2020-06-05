using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject destroyedVersion;
    Vector3 translocation = new Vector3(-4, 0, -4);
    public void swapToBroken(GameObject hitObject)
    {
        Debug.Log("Enter swaptobroken");
        Debug.Log(hitObject.transform.position);
        Instantiate(destroyedVersion, hitObject.transform.position + translocation, hitObject.transform.rotation);
        Destroy(hitObject);
        Debug.Log("Exit swaptobroken");
    }
}
