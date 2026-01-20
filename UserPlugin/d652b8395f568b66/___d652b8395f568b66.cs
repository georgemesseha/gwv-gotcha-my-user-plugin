
partial class _d652b8395f568b66
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
