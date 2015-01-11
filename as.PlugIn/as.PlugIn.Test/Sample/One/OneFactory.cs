namespace @as.PlugIn.Test.Sample.One
{
    /// <summary>
    /// One Factory
    /// </summary>
    public class OneFactory :PlugFactory
    {
        /// <summary>
        /// Connect
        /// </summary>
        /// <returns></returns>
        public override PlugBase Connect()
        {
            return new OnePlug();
        }
    }
}
