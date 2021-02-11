using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

namespace UnityTime {
    [CreateAssetMenu(menuName="Unity Time/Time Data")]
    public class TimeData : ScriptableObject {

        [Header("References")]
        public GameEvent changeOfDayEvent;

        public GameEvent changeOfHourEvent;

        public GameEvent changeOfMinuteEvent;

        [Header("Settings")]
        public float dayLengthMultiplier;

        [Header("Time Data")]
        public float currentTimeInSeconds;

        int CurrentDayCount;
        public int currentDayCount {
            get {
                return CurrentDayCount;
            }
            set {
                if (CurrentDayCount != value) {
                    CurrentDayCount = value;
                    changeOfDayEvent.StartEvent();
                }
            }
        }

        int CurrentHour;
        public int currentHour {
            get {
                return CurrentHour;
            }
            set {
                if (CurrentHour != value) {
                    CurrentHour = value;
                    changeOfHourEvent.StartEvent();
                }
            }
        }

        int CurrentMinute;
        public int currentMinute {
            get {
                return CurrentMinute;
            }
            set {
                if (CurrentMinute != value) {
                    CurrentMinute = value;
                    changeOfMinuteEvent.StartEvent();
                }
            }
        }

        float TimeScale = 1f;
        public float timeScale {
            get {
                return TimeScale;
            }
        }

        

        public void SetTimeScale (int index) {
            if (index == 0) {
                Debug.Log("Game Paused");
                TimeScale = 0;
            } else if (index == 1) {
                Debug.Log("Normal Speed");
                TimeScale = 1;
            }
            if (index == 2) {
                Debug.Log("x2 Speed");
                TimeScale = 2;
            }
            if (index == 3) {
                Debug.Log("x3 Speed");
                TimeScale = 3;
            }
        }
    }
}