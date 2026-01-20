
partial class _d58ce547de846b7a
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
