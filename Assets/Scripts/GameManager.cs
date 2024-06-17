using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string ScenesToLoad;
    public Text textPuntaje;
    public int points;
    void Start()
    {
        SumarPuntos(0);
    }
    void Update()
    {
    }

    public void SumarPuntos(int addPoints)
    {
        points = points + addPoints;
        if(textPuntaje != null)
        {
            textPuntaje.text = "Score: " + points;
        }       
    }
    public void Jugar()
    {
        SceneManager.LoadScene("Game");
    }
   
}
