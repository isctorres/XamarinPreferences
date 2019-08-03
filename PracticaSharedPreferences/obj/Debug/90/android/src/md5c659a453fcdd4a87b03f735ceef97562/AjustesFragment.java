package md5c659a453fcdd4a87b03f735ceef97562;


public class AjustesFragment
	extends android.support.v7.preference.PreferenceFragmentCompat
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreatePreferences:(Landroid/os/Bundle;Ljava/lang/String;)V:GetOnCreatePreferences_Landroid_os_Bundle_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("PracticaSharedPreferences.AjustesFragment, PracticaSharedPreferences", AjustesFragment.class, __md_methods);
	}


	public AjustesFragment ()
	{
		super ();
		if (getClass () == AjustesFragment.class)
			mono.android.TypeManager.Activate ("PracticaSharedPreferences.AjustesFragment, PracticaSharedPreferences", "", this, new java.lang.Object[] {  });
	}


	public void onCreatePreferences (android.os.Bundle p0, java.lang.String p1)
	{
		n_onCreatePreferences (p0, p1);
	}

	private native void n_onCreatePreferences (android.os.Bundle p0, java.lang.String p1);

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
