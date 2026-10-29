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

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(Points);
        

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void UpdatePointsText()
    {
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
    }
    

}
