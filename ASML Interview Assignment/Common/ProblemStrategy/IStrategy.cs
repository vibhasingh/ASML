// (C) ASML 2022 Submitted for Interview assignment

namespace ASML.InterviewTest.ProblemStrategy
{
    /// <summary>
    /// Generic interface for executing the strategy for a given problem
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Executes the solution algorithm for a problem taking data as input
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        object ExecuteAlgorithm(object data);
    }
}