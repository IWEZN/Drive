using UnityEngine;
using System.Collections;

public class buttonHover : MonoBehaviour
{
    public int timeRemaining = 5;
    public GameObject ball;
    
    void countDown()
    {
        timeRemaining --;
        if (timeRemaining <=0)
        {
            playVideo();
            
            //Reset timer
            CancelInvoke("countDown");
            timeRemaining = 5;
            print ("Reset time");
         ｝
      ｝
      
      void playVideo()
      {
          print ("FINISHED COUNTDOWN");
          Vector3 newpos = transform.position;
          ball.transform.position = newpos;
      }
      
      public void MouseOver()
      {
          InvokeRepeating ("countDown", 1, 1);
      }
      
      public void MouseOut()
      {
          CancelInvoke ("countDown");
          timeRemaining ~ 5;
      }
}
