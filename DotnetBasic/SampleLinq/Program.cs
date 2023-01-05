using Sample101Linq.DataSource;

public class Program
{
    public static void Main()
    {
        AggregateOperator aggregateOperator = new AggregateOperator();
        aggregateOperator.CountSyntax();
        aggregateOperator.CountNested();
        aggregateOperator.MaxProjection();
        aggregateOperator.MaxGrouped();
        aggregateOperator.GroupedCount();
        aggregateOperator.SumSyntax();
        aggregateOperator.SumProjection();
        aggregateOperator.SumGrouped();
        aggregateOperator.MinSyntax();
        aggregateOperator.MinProjection();
        aggregateOperator.MinGrouped();
        aggregateOperator.MinEachGroup();
        aggregateOperator.MaxSyntax();
        aggregateOperator.MaxEachGroup();
        aggregateOperator.AverageSyntax();
        aggregateOperator.AverageProjection();
        aggregateOperator.AverageGrouped();
        aggregateOperator.AggregateSyntax();
        aggregateOperator.SeededAggregate();

    }
}
