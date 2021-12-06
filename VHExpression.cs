using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VHExpression : MonoBehaviour
{



    //public Slider frownSlider;
        public GameObject body;
        public int smileLimit = 80;
        public int frownLimit = 80;

        private SkinnedMeshRenderer smr;

    // void Start()
    // {

    //     frownSlider.minValue = 0;
    //     frownSlider.maxValue = 100;
    // }

    void Update()
    {
        if(!smr){
            smr = body.GetComponent<SkinnedMeshRenderer>();
        }
    }
    //smile blendshapes are 39 and 40
     IEnumerator toSmile() {
         for(int i =0; i<=smileLimit; i++){
            smr.SetBlendShapeWeight(39, i);
            smr.SetBlendShapeWeight(40, i);
            yield return null;
         }
     }

    IEnumerator toNeutral()
    {
         for(int i =smileLimit; i>=0; i--){
            smr.SetBlendShapeWeight(39, i);
            smr.SetBlendShapeWeight(40, i);
            yield return null;
         }
    }

    IEnumerator smileRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        StartCoroutine(toSmile());
        yield return new WaitForSeconds(5.0f);
        StartCoroutine(toNeutral());
    }


    public void smileFunction()
    {
       StartCoroutine(smileRoutine());
    }

    //frwon blenshapes 13 and 14
    // public void toFrown() {
    //    smr.SetBlendShapeWeight(13,frownSlider.value);
    //    smr.SetBlendShapeWeight(14,frownSlider.value);
    // }

 //frown blendshapes are 13 and 14
     IEnumerator toFrown() {
         for(int i =0; i<=frownLimit; i++){
            smr.SetBlendShapeWeight(13, i);
            smr.SetBlendShapeWeight(14, i);
            yield return null;
         }
     }

    IEnumerator frownRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        StartCoroutine(toFrown());
        yield return new WaitForSeconds(5.0f);
        StartCoroutine(toNeutral());
    }
    public void frownFunction()
    {
       StartCoroutine(frownRoutine());
    }
}
