using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    private TMP_Text timerText;
    [SerializeField] private float timeRemaining;

    void Awake()
    {
        timerText = transform.GetComponent<TMP_Text>();
        timerText.text = ((int)timeRemaining).ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        } else
        {
            timeRemaining = 0;
        }
        timerText.text = ((int)timeRemaining).ToString();
    }

    public void SetTime(float timerLength)
    {
        timeRemaining = timerLength;
    }
    public float GetTime()
    {
        return timeRemaining;
    }
}
