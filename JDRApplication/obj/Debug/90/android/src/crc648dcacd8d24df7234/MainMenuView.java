package crc648dcacd8d24df7234;


public class MainMenuView
	extends crc647c651b09c9fa4e8e.BaseView_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("JDRApplication.Views.MainMenuView, JDRApplication.droid", MainMenuView.class, __md_methods);
	}


	public MainMenuView ()
	{
		super ();
		if (getClass () == MainMenuView.class)
			mono.android.TypeManager.Activate ("JDRApplication.Views.MainMenuView, JDRApplication.droid", "", this, new java.lang.Object[] {  });
	}

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
