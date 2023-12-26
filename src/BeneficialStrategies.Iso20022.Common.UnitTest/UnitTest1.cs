namespace BeneficialStrategies.Iso20022.Common;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var dataSource = new BeneficialStrategies.Iso20222.Common.AcceptedStatusReasonCodeDropdownSource();
        foreach (var item in dataSource.DropdownValues)
        {
            Console.WriteLine($"{item.Value} {item.Key} {item.Description}");
        }
    }
}