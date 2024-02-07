﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for YieldCalculation2.  ISO2002 ID# _oLtAMNorEeCWg-hsBVGrDA_726632043.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return provided by a financial instrument.
/// </summary>
public partial record YieldCalculation2
     : IIsoXmlSerilizable<YieldCalculation2>
{
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    public required CalculationType1Code CalculationType { get; init; } 
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    public Price4? RedemptionPrice { get; init; } 
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    public DateTimePeriodChoice_? ValuePeriod { get; init; } 
    /// <summary>
    /// Included as needed to clarify yield irregularities associated with date, e.g. when it falls on a non-business day.
    /// </summary>
    public IsoISODate? CalculationDate { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Val", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Value)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ClctnTp", xmlNamespace );
        writer.WriteValue(CalculationType.ToString()); // Enum value
        writer.WriteEndElement();
        if (RedemptionPrice is Price4 RedemptionPriceValue)
        {
            writer.WriteStartElement(null, "RedPric", xmlNamespace );
            RedemptionPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueDate is IsoISODate ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ValuePeriod is DateTimePeriodChoice_ ValuePeriodValue)
        {
            writer.WriteStartElement(null, "ValPrd", xmlNamespace );
            ValuePeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CalculationDate is IsoISODate CalculationDateValue)
        {
            writer.WriteStartElement(null, "ClctnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(CalculationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static YieldCalculation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
