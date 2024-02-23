using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;


namespace GeneralUtils
{

    public class Timers : MonoBehaviour
    {
        float CountDownTimer(double Seconds, double Minutes = 0, double Hours = 0, bool RepeatAfterDone = false)
        {
            Seconds = Seconds + (Minutes * 60) + (Hours * 3600);


            StartCoroutine(Timer());

            IEnumerator Timer()
            {

                while (Seconds > 0)
                {

                }

                yield return new WaitForFixedUpdate();
            }




        }







    }


}