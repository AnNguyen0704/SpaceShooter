using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class testdotween : MonoBehaviour
{
    [SerializeField]private GameObject a;
    [SerializeField]private GameObject b;
    [SerializeField]private Image Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveAtoB();
        }
    }
    private void moveAtoB()
    {

        //a.transform.DOMoveX(b.transform.position.x, 1f).SetLoops(3, LoopType.Yoyo).OnComplete(() => 
        //{
        //    a.transform.DOScale(1.5f, 0.5f).SetLoops(-1, LoopType.Yoyo);
        //});
        //a.transform.DOMoveX(b.transform.position.x, 1f).SetEase(Ease.OutBack);
        a.transform.DOJump(b.transform.position, 6f, 3,3f   );
        Health.DOFillAmount(1, 2f);
    }

}
