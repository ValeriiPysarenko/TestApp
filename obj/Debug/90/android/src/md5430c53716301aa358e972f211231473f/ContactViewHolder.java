package md5430c53716301aa358e972f211231473f;


public class ContactViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TestApp.ContactViewHolder, TestApp", ContactViewHolder.class, __md_methods);
	}


	public ContactViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ContactViewHolder.class)
			mono.android.TypeManager.Activate ("TestApp.ContactViewHolder, TestApp", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
