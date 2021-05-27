using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class graduation_project : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if(touch.phase==TouchPhase.Stationary ||touch.phase==TouchPhase.Moved)
        {
            Vector3 touchPosition = Camera.main.ScreenToViewportPoint(new Vector3(touch.position.x, Camera.main.nearClipPlane, touch.position.y));
            touchPosition.y = 0.0f;
            transform.position = Vector3.Lerp(transform.position, touchPosition, Time.deltaTime * 5.0f);
        }
    }
    
}
public class soundControle :MonoBehaviour
{
    public AudioSource music;
    public float defultMusicVolum = 1;
    public GameObject mute;
    public GameObject unmute;
    private void Start()
    {
        unmute.SetActive(true);
        mute.SetActive(false);

    }
    public void UnMuteSound()
    {
        unmute.SetActive(true);
        mute.SetActive(false);
        music.volume = defultMusicVolum;

    }
    public void MuteSound()
    { 
        music.volume = 0;
        unmute.SetActive(false);
        mute.SetActive(true);
    }
    public void volumeChange(float volume)
    {
        music.volume = volume;
    }

}
public class setPlayerGender : MonoBehaviour
{
    public GameObject [] player;
    private void Start()
    {
        
    }
    public void setGirleGender()
    {
        player[0].SetActive(false);
        player[1].SetActive(true);
    }
    public void setmaleGender()
    {
        player[0].SetActive(true);
        player[1].SetActive(false);
    }

}
public class setGmaeMode:MonoBehaviour
{
    public Scene[] gameMode;
    private void Start()
    {
        
    }
    public void startMode(int a)
    {
        for(int i=0;i<gameMode.Length;i++)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0 + a);
        }
    }
}
public class ButtonControl : MonoBehaviour
{
    public GameObject Resume;
    public GameObject pouse;
    public GameObject toShow;
    public GameObject toMain;
    public GameObject Setting;

    public void Pause()
    {
        Time.timeScale = 0;
        Resume.SetActive(true);
      pouse.SetActive(false);
        toShow.SetActive(false);
        toMain.SetActive(false);
    }
    public void resum()
    {
        Time.timeScale = 1;
        Resume.SetActive(false);
      pouse.SetActive(true);
        toShow.SetActive(true);
        toMain.SetActive(false);
    }
    public void MainMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);
    }
    public void setting()
    {
        Setting.SetActive(true);
        Resume.SetActive(false);
    }
    public void back()
    {
        Setting.SetActive(false);
        Resume.SetActive(true);
    }

}
https://github.com/18819999/bashar-Hazem
