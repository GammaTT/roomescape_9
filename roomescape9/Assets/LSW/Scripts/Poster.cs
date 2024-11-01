using DG.Tweening;
using UnityEngine;

public class Poster : MonoBehaviour
{
    [SerializeField] private GameObject poster;
    [SerializeField] public GameObject text;
    [SerializeField] public GameObject story;


    public void OnPoster()
    {
        poster.transform.DOLocalMoveY(poster.transform.localPosition.y - 1200f, 1.6f).SetEase(Ease.OutCubic).OnComplete(() =>
        {
               
        });
    }

    public void OnClickPoster()
    {
         text.SetActive(true);
    }

    public void OnClickText()
    {
        text.SetActive(false);
        story.SetActive(true);
    } 
}