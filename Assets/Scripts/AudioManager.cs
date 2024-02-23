using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using Unity.VisualScripting;

public class AudioManager : MonoBehaviour
{
    //creats a static instance of the sudio mamager lcass to be usde later
    private static AudioManager instance;
    //creates a public asudiomanager property called Instanse that retursn insatnvce
    public static AudioManager Instance { get { return instance; } }
    //creates a public sudiomiver veriable called mastermicer
    public AudioMixer masterMixer;

    public void Awake()
    {
        //checks to see if instance exisst if it does then it destroys the new one
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        //makes thsi.gameobject notdestroyonload
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        //sets the volume od the mastervolume and soundvolume to eht result of preferencwe maganer getvolume
        masterMixer.SetFloat("MasterVol", PreferencesManager.GetMasterVolume());
        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVolume());
    }
    public void ChangeSoundVolume(float soundLevel)
    {
        //sets the mastervolume to whatecer soundlevel is and chanes the prepference manager to make soundlevel the mastervolume
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }
    public void ChangeMusicVolume(float soundLevel)
    {
        //sets the musicvolume to whatecer soundlevel is and chanes the prepference manager to make soundlevel the muscivolume
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }
}
