using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private Sprite SoundONImage;
    public Sprite SoundOFFImage;
    public Button ButtonMute;
    private bool isOn = true;

    public AudioMixer MainMixer;
    public AudioSource audioSource;
    public static AudioManager instance;
        
    public void SetVolume (float SliderVolume)
    {
        MainMixer.SetFloat("Volume", SliderVolume);
    }
    
    void Start()
    {
       SoundONImage = ButtonMute.image.sprite;    
    }
    
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.audioSource);
        }
    }

        public void SetGameVolume(float Volume) {
        AudioListener.volume = Volume;
 
        PlayerPrefs.SetFloat("Volume", Volume);
 
 
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            ButtonMute.image.sprite = SoundOFFImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            ButtonMute.image.sprite = SoundONImage;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
