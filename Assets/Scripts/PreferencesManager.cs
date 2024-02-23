using UnityEngine;

public static class PreferencesManager
{
    public static float GetMusicVolume()
    {
        //returns a float with the value of msuci voluem
        return PlayerPrefs.GetFloat("MusicVolume", 1f);
    }
    public static float GetMasterVolume()
    {
        //returns a float with the value of macster voluem
        return PlayerPrefs.GetFloat("MasterVolume", 1f);
    }
    public static void SetMusicVolume(float soundLevel)
    {
        //sets music voleum equla to soundleel
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }
    public static void SetMasterVolume(float soundLevel)
    {
        //sets master voleum equla to soundleel
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }
}
