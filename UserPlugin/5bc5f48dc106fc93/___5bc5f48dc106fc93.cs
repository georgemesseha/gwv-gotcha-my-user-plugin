
partial class _5bc5f48dc106fc93
{
    IPluginServices _srv;
     //IExecution _exec;

	public string SomeProp { get; private set;}

	public int AnotherProp { get; private set;}

	public void SetInput(string someProp, int anotherProp)
	{
		SomeProp = someProp;
		AnotherProp = anotherProp;
	}
}
