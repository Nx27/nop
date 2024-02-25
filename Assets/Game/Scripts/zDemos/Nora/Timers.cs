using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;


namespace GeneralUtils
{

    public class GenTesting : MonoBehaviour
    {
        public delegate void _ExecuteableFunction();
        void Start ()
        {
            CountdownTimer(100);
        }                                                                                                              //MAKE SURE THAT THE FUNCTION IS PUBLIC PLEASE FOR THE LOVE OF GOD
        void CountdownTimer(double Seconds, double Minutes = 0, double Hours = 0, int IntervalOfRepeat = 0, _ExecuteableFunction ExecuteableFunction = null)
        {
            Seconds = Seconds + (Minutes * 60) + (Hours * 3600);


            StartCoroutine(Timer());

            IEnumerator Timer()
            {

                while (Seconds > 0)
                {
                    Seconds -= Time.deltaTime;
                    //Debug.Log(Seconds);
                    yield return new WaitForFixedUpdate();
                }

                if (IntervalOfRepeat > 0)
                {
                    StartCoroutine(RepetitionAfter());
                }
                
            }

            IEnumerator RepetitionAfter() {

                ExecuteableFunction();

                yield return new WaitForSeconds(IntervalOfRepeat); 
            }


        }







    }


}