﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceRate1.  ISO2002 ID# _Qa2uBdp-Ed-ak6NoX_4Aeg_101667231.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a price expressed as a rate.
/// </summary>
public partial record PriceRate1
     : IIsoXmlSerilizable<PriceRate1>
{
    #nullable enable
    
    /// <summary>
    /// Type of rate, eg, yield.
    /// </summary>
    public required PriceRateType3FormatChoice_ RateType { get; init; } 
    /// <summary>
    /// Price expressed as a rate, ie, percentage.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    
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
        writer.WriteStartElement(null, "RateTp", xmlNamespace );
        RateType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Rate)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static PriceRate1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
