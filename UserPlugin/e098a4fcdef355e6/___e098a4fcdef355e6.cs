
partial class _e098a4fcdef355e6
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
