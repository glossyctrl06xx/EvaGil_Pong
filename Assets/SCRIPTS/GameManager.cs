using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Playernumber1;
    public int Playernumber2;
    string Points;
    public TextMeshProUGUI marcadorText;
    public AudioClip pointscount;
    public AudioClip winsound;
    AudioSource audioSource;
    public int pointsToWin = 5;
    public GameObject winpanel;



    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(Points);
        Time.timeScale = 1f;
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {


    }

    public void UpdatePointsText()
    {
        string lastPoints = Points;
        Points = Playernumber1 + "|" + Playernumber2;
        marcadorText.text = Points;

        if (Playernumber1 == 5)
        {
            SceneManager.LoadScene(0);
        }

        else if (Playernumber2 == 5)
        {
            SceneManager.LoadScene(0);
        }

        if (Playernumber1 >= pointsToWin || Playernumber2 >= pointsToWin)
        {
            audioSource.clip = winsound;
            winpanel.SetActive(true);
            Time.timeScale = 0f;

        }


    }



}
