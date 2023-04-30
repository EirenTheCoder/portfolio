using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SCORE : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score += 1;
        Debug.Log(score);
        scoreText.text ="SCORE :"+ score.ToString();
    }
}
