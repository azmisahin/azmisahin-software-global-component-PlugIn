using @as.PlugIn.Data.Models;
using System.Collections.Generic;

namespace @as.PlugIn.Test.Sample.One
{
    /// <summary>
    /// One Plug
    /// </summary>
    public class OnePlug :PlugBase
    {
        #region Ctor
        public OnePlug(bool debug = true, bool progress = true) : base(debug: debug, progress: progress) { }//Base Connector
        #endregion

        #region Progress Function
        /// <summary>
        /// PlugIn Relase Progress
        /// </summary>
        public override void Progress()
        {
            result = new List<Result>();
            result.Add(new Result { id = 1 });            
            //No Return 
        }
        #endregion
    }
}
