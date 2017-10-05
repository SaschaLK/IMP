using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyCollisionChecker : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Use this for initialization
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        //gameOverPanel.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 0;
    }


}
