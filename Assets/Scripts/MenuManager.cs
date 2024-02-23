using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    //makes tow public slideer objexts to be used so choose the voluem
    public Slider musicSlider;
    public Slider masterSlider;

    void Start()
    {
        //chekc s to see if the master slider exists
        if (masterSlider != null)
        {
            //calls getnastervolume frm the preferecne manager
            PreferencesManager.GetMasterVolume();
        }
        //cahecks to see if the music aliser exists
        if (musicSlider != null)
        {
            //calls getmusicvolume from the preferencesmanager
            PreferencesManager.GetMusicVolume();
        }
    }
    //recieves a float called soundlecel and calls the cahgnge sound volume method from sudiomanager using soundlevel ad the soundlsevel
    public void ChangeSoundVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSoundVolume(soundLevel);
    }
    //recieves a float called soundlecel and calls the cahgnge sound musci method from sudiomanager using soundlevel ad the soundlsevel
    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }
}
