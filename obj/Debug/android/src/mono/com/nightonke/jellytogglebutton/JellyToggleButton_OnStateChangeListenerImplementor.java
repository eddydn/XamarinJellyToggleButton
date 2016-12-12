package mono.com.nightonke.jellytogglebutton;


public class JellyToggleButton_OnStateChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nightonke.jellytogglebutton.JellyToggleButton.OnStateChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onStateChange:(FLcom/nightonke/jellytogglebutton/State;Lcom/nightonke/jellytogglebutton/JellyToggleButton;)V:GetOnStateChange_FLcom_nightonke_jellytogglebutton_State_Lcom_nightonke_jellytogglebutton_JellyToggleButton_Handler:Com.Nightonke.Jellytogglebutton.JellyToggleButton/IOnStateChangeListenerInvoker, JellyToggleButton\n" +
			"";
		mono.android.Runtime.register ("Com.Nightonke.Jellytogglebutton.JellyToggleButton+IOnStateChangeListenerImplementor, JellyToggleButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", JellyToggleButton_OnStateChangeListenerImplementor.class, __md_methods);
	}


	public JellyToggleButton_OnStateChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == JellyToggleButton_OnStateChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nightonke.Jellytogglebutton.JellyToggleButton+IOnStateChangeListenerImplementor, JellyToggleButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onStateChange (float p0, com.nightonke.jellytogglebutton.State p1, com.nightonke.jellytogglebutton.JellyToggleButton p2)
	{
		n_onStateChange (p0, p1, p2);
	}

	private native void n_onStateChange (float p0, com.nightonke.jellytogglebutton.State p1, com.nightonke.jellytogglebutton.JellyToggleButton p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
