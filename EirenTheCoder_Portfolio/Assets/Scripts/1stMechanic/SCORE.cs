using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class SCORE : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float score=0;
    private float MAX_SCORE = 10000;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject finalPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score += 1;
        scoreText.text ="SCORE :"+ score.ToString();
    
    if(score >MAX_SCORE) finalPortal.SetActive(true);


        if (player !=null)
        {
            if (Vector3.Distance(player.transform.position, finalPortal.transform.position) < 1)
            {

                Utils.changeScene("FirstHUD");

            }
        }

    }


}
