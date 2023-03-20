using System;
using System.Runtime.InteropServices;

public static class MySynth
{
#if UNITY_IPHONE
    [DllImport ("__Internal")]
#else
    [DllImport("audioplugin_tapSynth.bundle")]
#endif
    private static extern IntPtr getInstance();


#if UNITY_IPHONE
    [DllImport ("__Internal")]
#else
    [DllImport("audioplugin_tapSynth.bundle")]
#endif
    public static extern void noteOn(IntPtr ptr, int note, float velocity);
    public static void noteOn(int note, float velo)
    {
        if (getInstance() != IntPtr.Zero)
            noteOn(getInstance(), note, velo);
    }

    public static void dostuff()
    { }

#if UNITY_IPHONE
    [DllImport ("__Internal")]
#else
    [DllImport("audioplugin_tapSynth.bundle")]
#endif
    public static extern void noteOff(IntPtr ptr, int note);
    public static void noteOff(int note)
    {
        if (getInstance() != IntPtr.Zero)
            noteOff(getInstance(), note);
    }
}