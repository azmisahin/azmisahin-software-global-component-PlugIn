using System.Collections.Generic;
using @as.PlugIn.Data.Models;

namespace @as.PlugIn
{
    /// <summary>
    /// Plug Base
    /// </summary>
    public abstract class PlugBase
    {
        #region Field
        public List<Result> result { get; set; }
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        public PlugBase()
        {
            Init(debug: true, progress: true);
        }

        /// <summary>
        /// Ctor Access
        /// </summary>
        /// <param name="debug"></param>
        /// <param name="progress"></param>
        public PlugBase(bool debug = false, bool progress = false)
        {
            Init(debug: debug, progress: progress);
        }
        #endregion

        #region Property

        /// <summary>
        /// Progress
        /// </summary>
        public abstract void Progress();

        /// <summary>
        /// Debug Progress
        /// </summary>
        public virtual void debugProgress()
        {
            result = new List<Result>();
        }
        #endregion

        #region Function
        /// <summary>
        /// Initalize
        /// </summary>
        /// <param name="debug"></param>
        /// <param name="progress"></param>
        private void Init(bool debug = false, bool progress = true)
        {
#if DEBUG
            if (debug) debugProgress();
#endif
            try
            {
                if (progress) Progress();
            }
            catch (System.Exception)
            {
#if DEBUG
                System.Diagnostics.Trace.Write(string.Format("Progress : {0} ", GetType()));
#endif
            }
        }

        #endregion
    }
}
