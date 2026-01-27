
partial class _80f11a886691d655
{
    public async Task<string> GenerateInfoMessage_ded4a1a4a82301b8()
    {
       return @"traces
                | where message contains "">> APP""
                | order by timestamp desc
                | limit 500"; // return the output port index according to your logic
    }
}
