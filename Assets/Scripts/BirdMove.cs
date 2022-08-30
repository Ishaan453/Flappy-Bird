using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    [SerializeField]
    private float jump;

    [SerializeField]
    private Vector3 direction;

    [SerializeField]
    private float gravity = -9.8f;

    private string GROUND_TAG = "Ground";
    private string PIPE_TAG = "Pipes";
    private string SCORE_TAG = "Scorer";

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0)) {
            direction = Vector3.up * jump;
        }

        if(Input.touchCount > 0)
        {
            bool first = true;
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began && first == true)
            {
                direction = Vector3.up * jump;
                first = false;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG) || collision.gameObject.CompareTag(PIPE_TAG))
        { 
            Time.timeScale = 0f;
            Thread.Sleep(2000);
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(SCORE_TAG))
        {
            ScoreUpdate.ScoreUp();
        }

    }


}
