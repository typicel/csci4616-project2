using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButtonEnter : MonoBehaviour
{
	public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

	void OnTriggerEnter() {
		source.Play();
    }
}
