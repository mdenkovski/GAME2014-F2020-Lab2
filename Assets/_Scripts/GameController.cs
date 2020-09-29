using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Update is called once per frame
    void Update()
    {
       switch(Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //SceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -200.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -200.0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                //SceneLabel.text = "LandscapeLeft";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -83.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -83.0f);
                break;
            case DeviceOrientation.LandscapeRight:
                //SceneLabel.text = "LandscapeRight";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -83.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-500.0f, -83.0f);
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown";
                break;
            default:
               // SceneLabel.text = "Some other orientation";
                break;
        }
    }
}
