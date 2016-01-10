public class CartProduct
{
	private int id;
	private string name;
	
	public CartProduct (id, name)
	{
		this.id = id;
		this.name = name;
	}
	
	public int GetId ()
	{
		return this.id;
	}
	
	public string GetName ()
	{
		return this.name;
	}

	public void SetId (string id)
	{
		this.id = id;
	}
	
	public void SetName (string name)
	{
		this.name = name;
	}
}