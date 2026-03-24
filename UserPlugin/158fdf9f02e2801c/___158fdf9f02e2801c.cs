
partial class _158fdf9f02e2801c
{
    ITrn_PluginServicesPublic _srv;
     //IExecution _exec;

	public string SomeProp { get; private set;}

	public int AnotherProp { get; private set;} 

	public void Input(string someProp, int anotherProp)  
	{
		SomeProp = someProp;  
		AnotherProp = anotherProp;
	}
}
