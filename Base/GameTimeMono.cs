using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTime {
    public class GameTimeMono : MonoBehaviour {

        public TimeData timeData;

        float timeMultipler;

        void Awake () {
            timeData.currentHour = 0;
            timeData.currentMinute = 0;
            timeData.currentDayCount = 0;
            timeData.currentTimeInSeconds = 0;
        }

        void FixedUpdate () {
            timeMultipler = timeData.dayLengthMultiplier * timeData.timeScale;
            
            timeData.currentTimeInSeconds += Time.deltaTime * timeMultipler;
            if (timeData.currentTimeInSeconds >= 1440) {
                timeData.currentTimeInSeconds = 0;
                timeData.currentDayCount += 1;
            }
            timeData.currentHour = (int)timeData.currentTimeInSeconds / 60;
            timeData.currentMinute = (int)timeData.currentTimeInSeconds - (int)timeData.currentHour * 60;

        }
    }
}