using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using libZPlay;

public class bpm : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string fname6 = "./ishin-furan.mp3";
        ZPlay player = new ZPlay();
        player.OpenFile(fname6, TStreamFormat.sfAutodetect);

        //int bpm = player.DetectFileBPM(fname3, TStreamFormat.sfMp3, TBPMDetectionMethod.dmPeaks);
        int bpm = player.DetectBPM(TBPMDetectionMethod.dmPeaks);
        //Console.WriteLine(bpm);
        player.StartPlayback();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
