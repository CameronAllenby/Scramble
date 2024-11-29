using UnityEngine;
using UnityEngine.UI;
public class Sliders : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;




    private void Start()
    {

        _musicSlider.value = PlayerPrefs.GetFloat("music");
        _sfxSlider.value = PlayerPrefs.GetFloat("sfx");
    }
    public void MusicVolume()
    {

        SoundManager.Instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        SoundManager.Instance.SFXVolume(_sfxSlider.value);
    }

    private void Update()
    {

        PlayerPrefs.SetFloat("music", _musicSlider.value);
        PlayerPrefs.SetFloat("sfx", _sfxSlider.value);

    }
}
