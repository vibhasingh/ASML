// (C) ASML 2022 Submitted for Interview assignment

namespace ASML.InterviewTest.ProblemStrategy
{
    public class ProblemContext
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IStrategy _strategy;

        // Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public object ExecuteStrategy(object input)
        {
            return _strategy.ExecuteAlgorithm(input);
        }
    }
}