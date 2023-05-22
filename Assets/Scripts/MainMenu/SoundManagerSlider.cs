using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagerSlider : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] Slider volumeSlider;
    [SerializeField] GameObject musicObject;
    private float musicVolume;

    void Start(){
        musicVolume = PlayerPrefs.GetFloat("volume", 1.0f);
        AudioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;

        volumeSlider.onValueChanged.AddListener(VolumeUpdater);
    }

    void Update(){
        AudioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void VolumeUpdater(float volume){
        musicVolume = volume;
    }
}
