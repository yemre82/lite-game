using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class EmailMissionController : MonoBehaviour
{
    public bool is_verified = false;
    public TMP_Text verifyText;
    public bool can_reward = false;
    public TMP_Text getRewardText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (is_verified)
        {
            verifyText.text = "Verified";
            verifyText.color = new Color(0.7490196f, 0.7490196f, 0.7490196f,1f);
            if (can_reward)
            {
                getRewardText.text = "Get Reward";
                getRewardText.color = new Color(0, 0, 0, 1f);
            }
            else
            {
                getRewardText.text = "Rewarded";
                getRewardText.color = new Color(0.7490196f, 0.7490196f, 0.7490196f, 1f);
            }
        }
        else
        {
            verifyText.text = "Verify";
            verifyText.color = new Color(0, 0, 0, 1f);
            getRewardText.text = "Rewarded";
            getRewardText.color = new Color(0.7490196f, 0.7490196f, 0.7490196f, 1f);
        }
    }
}
