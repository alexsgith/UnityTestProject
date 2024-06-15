using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBanner : MonoBehaviour
{
    [SerializeField] private List<Sprite> bannerImage;
    [SerializeField] private GameObject bannerImageobject;
    private ScrollRect scroll;
    private int currentScroll = 0;

    private void Awake()
    {
        scroll = GetComponent<ScrollRect>();
        var obj =Instantiate(bannerImageobject, scroll.content);
        obj.GetComponent<Image>().sprite = bannerImage[bannerImage.Count - 1];
        foreach (var im in bannerImage)
        {
            obj = Instantiate(bannerImageobject, scroll.content);
            obj.GetComponent<Image>().sprite = im;
        }

        StartCoroutine(StartSwipe());
    }

    IEnumerator StartSwipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            
        }
    }
    
}
