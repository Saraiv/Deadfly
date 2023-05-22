using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake(){
        if(GameObject.FindGameObjectsWithTag("GameMusic").Length > 1)
            Destroy(this.gameObject);
        
        if(GameObject.FindGameObjectsWithTag("VolumeSlider").Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}
