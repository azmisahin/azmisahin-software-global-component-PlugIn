namespace @as.PlugIn.Test.Sample.One
{
    /// <summary>
    /// One Factory
    /// </summary>
    public class TwoFactory : PlugFactory
    {
        /// <summary>
        /// Connect
        /// </summary>
        /// <returns></returns>
        public override PlugBase Connect()
        {
            return new TwoPlug();
        }
    }
}
