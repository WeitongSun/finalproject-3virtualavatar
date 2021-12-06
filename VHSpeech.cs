using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;
public class VHSpeech : MonoBehaviour
{
    private LipSync ls;
    public LipSyncData[] lsAudio;
    void Start()
    {
        ls = GameObject.Find("remy").GetComponent<LipSync>();
    }


    void Update()
    {
        if(!ls){
            ls = GameObject.Find("remy").GetComponent<LipSync>();
        }
    }

    public void orderIsReady(){
        ls.Play(lsAudio[0]);
    }

    public void iWasBornHere() {
        ls.Play(lsAudio[1]);
    }

    public void getOut() {
        ls.Play(lsAudio[2]);
    }
    public void showsBias() {
        ls.Play(lsAudio[3]);
    }
    public void noOfffense() {
        ls.Play(lsAudio[4]);
    }
    public void suitYourself() {
        ls.Play(lsAudio[5]);
    }
    public void noProblem() {
        ls.Play(lsAudio[6]);
    }
    public void seeYouNextTime() {
        ls.Play(lsAudio[7]);
    }
    public void justLeave() {
        ls.Play(lsAudio[8]);
    }
    public void haveANiceDay() {
        ls.Play(lsAudio[9]);
    }
}
