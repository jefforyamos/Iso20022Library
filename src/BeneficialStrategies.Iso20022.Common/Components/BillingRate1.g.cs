﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingRate1.  ISO2002 ID# _6QGNppqlEeGSON8vddiWzQ_1919554496.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the billing rate.
/// </summary>
public partial record BillingRate1
     : IIsoXmlSerilizable<BillingRate1>
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of rate or factor.
    /// </summary>
    public required BillingRateIdentification1Choice_ Identification { get; init; } 
    /// <summary>
    /// Value of the rate or factor identified in the rate identification.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    /// <summary>
    /// Number of days in the statement period. ||Usage: Used along with DaysInYear for time dependent per annum rate value.
    /// </summary>
    public IsoNumber? DaysInPeriod { get; init; } 
    /// <summary>
    /// Number of days in the year.||Usage: Used along with DaysInPeriod for time dependent per annum rate value.
    /// </summary>
    public IsoNumber? DaysInYear { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Val", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Value)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
        if (DaysInPeriod is IsoNumber DaysInPeriodValue)
        {
            writer.WriteStartElement(null, "DaysInPrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(DaysInPeriodValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (DaysInYear is IsoNumber DaysInYearValue)
        {
            writer.WriteStartElement(null, "DaysInYr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(DaysInYearValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
    }
    public static BillingRate1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
