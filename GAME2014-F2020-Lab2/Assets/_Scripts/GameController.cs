using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {

            case DeviceOrientation.Portrait:
                Debug.Log("Portrait");
                //SceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -185f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -185f);
               
                break;
            case DeviceOrientation.LandscapeLeft:
                Debug.Log("LandscapeLeft");
                SceneLabel.text = "Landscape Left";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -105f);
               
                break;
            case DeviceOrientation.LandscapeRight:
               // Debug.Log("LandscapeRight");
                SceneLabel.text = "Landscape Right";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-490.0f, -105f);
                
                break;
            
            case DeviceOrientation.Unknown:
                Debug.Log("Unknown");
                //SceneLabel.text = "Unknown";
                break;
           default:
                Debug.Log("Some other orientation");
                break;
        }

    }
}
