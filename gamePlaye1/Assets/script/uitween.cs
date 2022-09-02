using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uitween : MonoBehaviour
{
    [SerializeField] GameObject play;
    [SerializeField] GameObject losingp,gameover,coin, diamond, scor, replay, home;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(play, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(gameover, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(losing);
        LeanTween.moveLocal(gameover, new Vector3(10f, 110f, 2f), .4f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(gameover, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
    }

    // Update is called once per frame
    void losing()
    {
        LeanTween.moveLocal(losingp, new Vector3(3f, -62f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(replay, new Vector3(1f, 1f, 1f), 2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(home, new Vector3(1f, 1f, 1f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(scor.GetComponent<RectTransform>(), 1f, .5f).setDelay(1f);
        LeanTween.alpha(coin.GetComponent<RectTransform>(), 1f, .5f).setDelay(1.1f);
        LeanTween.alpha(diamond.GetComponent<RectTransform>(), 1f, .5f).setDelay(1.2f);
    }
}
