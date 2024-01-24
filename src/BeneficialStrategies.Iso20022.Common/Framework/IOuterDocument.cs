namespace BeneficialStrategies.Iso20022.Common.Framework;

/// <summary>
/// Should be implemented by the document wrapper that is placed around each message that establishes the XML namespace.
/// </summary>
/// <typeparam name="TOuterRecord">Data type of the record included inside.</typeparam>
public interface IOuterDocument<TOuterRecord>
    where TOuterRecord: IOuterRecord
{
    public TOuterRecord Message { get; }
}