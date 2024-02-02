namespace BeneficialStrategies.Iso20022;

  public class ValueList<T>:List<T>
{
    //private readonly bool _requireMathcingOrder;
    public ValueList()
    {
        
    }
    public override bool Equals(object? other)
    {
        if (other is null) return false;
        if (!(other is IEnumerable<T> enumerable)) return false;
        // if(!_requireMathcingOrder)return enumerable.ScrambledEquals(this);
        return enumerable.SequenceEqual(this);
    }

    public override int GetHashCode()
    {
        var hashCode = 0;
        foreach (var item in this)
        {
            hashCode ^= item?.GetHashCode() ?? 0;
        }

        return hashCode;
    }
}
