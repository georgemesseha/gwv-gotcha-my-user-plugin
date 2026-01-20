
partial class _80f11a886691d655
{
    IPluginServices _srv;
     //IExecution _exec;

	public string SomeProp { get; private set;}

	public int AnotherProp { get; private set;}

	public void Input(string someProp, int anotherProp)
	{
		SomeProp = someProp;
		AnotherProp = anotherProp;
	}
}
