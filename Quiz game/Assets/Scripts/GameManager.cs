using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    QuizManager Quiz;
    EndScreen endscreen;
    Home Home;
    private void Awake()
    {
        Home = FindObjectOfType<Home>();
        Quiz = FindObjectOfType<QuizManager>();
        endscreen = FindObjectOfType<EndScreen>();
    }
    void Start()
    {
        Home.gameObject.SetActive(true);
        Quiz.gameObject.SetActive(false);
        endscreen.gameObject.SetActive(false);
    }

    
    void Update()
    {
        if (Quiz.IsCompleted)
        {
            endscreen.gameObject.SetActive(true);
            Home.gameObject.SetActive(false);
            Quiz.gameObject.SetActive(false);
            endscreen.ShowFinalScore();
        }
    }

    public void ReplayScence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void StartQuiz()
    {
        Quiz.gameObject.SetActive(true);
        Home.gameObject.SetActive(false);
        endscreen.gameObject.SetActive(false);
    }
}
