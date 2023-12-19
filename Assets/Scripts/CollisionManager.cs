using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            Debug.Log("Target was hit!!!!");
            GameEventManager.current.TargetHit();
            Destroy(this.gameObject);
        }
    }
}
