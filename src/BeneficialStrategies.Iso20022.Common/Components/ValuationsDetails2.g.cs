﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ValuationsDetails2.  ISO2002 ID# _LuJTafGMEei2UYJ62ws-Fw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation details for the cash position.
/// </summary>
public partial record ValuationsDetails2
     : IIsoXmlSerilizable<ValuationsDetails2>
{
    #nullable enable
    
    /// <summary>
    /// Securities collateral position valuation amounts.
    /// </summary>
    public CollateralAmount9? ValuationDetailsAmount { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _LuJTcfGMEei2UYJ62ws-Fw
    /// <summary>
    /// Haircut or margin on the security  expressed as a percentage.
    /// </summary>
    public required IsoBaseOneRate Haircut { get; init; } 
    
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
        // Not sure how to serialize ValuationDetailsAmount, multiplicity Unknown
        writer.WriteStartElement(null, "Hrcut", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(Haircut)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
    }
    public static ValuationsDetails2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
