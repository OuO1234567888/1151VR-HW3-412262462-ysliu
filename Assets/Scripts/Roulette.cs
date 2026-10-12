using Unity.VisualScripting;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    [SerializeField] float maxRotateSpeed = 30;
    float currentRotateSpeed = 0;
    [SerializeField] float slowdownRate = 0.98f;
    bool canRotate = true;
    AudioSource audioSource;
    [SerializeField] AudioClip rotate;
    [SerializeField] AudioClip end;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(canRotate == true && Input.GetMouseButtonDown(0))
        {
            currentRotateSpeed = maxRotateSpeed;
            canRotate = false;
        }

        transform.Rotate(0, 0, currentRotateSpeed);

        currentRotateSpeed *= slowdownRate;

        // 停止時播音效
        if(currentRotateSpeed < 0.1f && canRotate == false)
        {
            currentRotateSpeed = 0;
            canRotate = true;
            audioSource.PlayOneShot(end);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        audioSource.PlayOneShot(rotate);
    }
}
