using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartManager : MonoBehaviour
{
    public Sprite fullHeart, threeQuarterHeart, halfHeart, oneQuarterHeart, emptyHeart;
    Image heartImage;

    private void Awake()
    {
        heartImage = GetComponent<Image>();
    }

    public void SetHeartImage(HeartStatus status)
    {
        switch (status)
        {
            case HeartStatus.Empty:
                heartImage.sprite = emptyHeart;
                break;
            case HeartStatus.OneQuarter:
                heartImage.sprite = oneQuarterHeart;
                break;
            case HeartStatus.Half:
                heartImage.sprite = halfHeart;
                break;
            case HeartStatus.ThreeQuarter:
                heartImage.sprite = threeQuarterHeart;
                break;
            case HeartStatus.Full:
                heartImage.sprite = fullHeart;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

public enum HeartStatus
{
    Empty = 0,
    OneQuarter = 1,
    Half = 2,
    ThreeQuarter = 3,
    Full = 4
}
