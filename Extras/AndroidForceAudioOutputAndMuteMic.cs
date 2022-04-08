using UnityEngine;

public class ForceAudioOutput : MonoBehaviour{
    AndroidJavaObject audioManager, activity;
    AndroidJavaClass unityPlayer;

    void Start() {
#if UNITY_ANDROID
        unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        audioManager = new AndroidJavaObject("android.media.AudioManager");
        activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        audioManager = activity.Call<AndroidJavaObject>("getSystemService", new AndroidJavaObject("java.lang.String", "audio"));
#endif
    }
    public void SetSpeaker(bool active) {
#if UNITY_ANDROID
        audioManager.Call("setMode", 2);
        audioManager.Call("setSpeakerphoneOn", active);
#endif
    }
    public void SetMicrophone(bool active) {
#if UNITY_ANDROID
        audioManager.Call("setMicrophoneMute", active);
#endif
    }
}
