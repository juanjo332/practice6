using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnfacturarClicked (object sender, System.EventArgs e)
	{
		float producto1 = float.Parse(entryproducto1.Text);
		float producto2 = float.Parse(entryproducto2.Text);
		float producto3 = float.Parse(entryproducto3.Text);
		
		float subtotal = producto1 + producto2 + producto3;
		entrysubtotal.Text = subtotal.ToString();
		
		double iva = subtotal * .16;
		entryiva.Text = iva.ToString();
		
		
		double total = subtotal + iva;
		entrytotal.Text = total.ToString();
		
	}

	protected void OnBtnlimpiarClicked (object sender, System.EventArgs e)
	{ 
		string a = "";
		entryproducto1.Text = a;
		entryproducto2.Text = a;
		entryproducto3.Text = a;
		entrysubtotal.Text = a;
		entryiva.Text = a;
		entrytotal.Text = a;
		
	}
}

