using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KnifeStopperManager : MonoBehaviour
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            other.gameObject.transform.rotation =
                Quaternion.Euler(new Vector3(90, other.gameObject.transform.rotation.y, 0));
            other.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
            _audioSource.Play();
        }
    }
}
