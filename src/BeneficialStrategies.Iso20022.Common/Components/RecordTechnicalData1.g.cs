﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecordTechnicalData1.  ISO2002 ID# _NUoVYB5REeWc9bJOIIhUUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument specific technical data to support identification.
/// </summary>
public partial record RecordTechnicalData1
     : IIsoXmlSerilizable<RecordTechnicalData1>
{
    #nullable enable
    
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    public required IsoISODateTime ReceiptDateTime { get; init; } 
    /// <summary>
    /// Describes the reason for the exchange of the transaction report between the competent authorities.
    /// </summary>
    public AuthorityExchangeReason1Code? ExchangeReason { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _TaRd8B5REeWc9bJOIIhUUw
    
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
        writer.WriteStartElement(null, "RctDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ReceiptDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        // Not sure how to serialize ExchangeReason, multiplicity Unknown
    }
    public static RecordTechnicalData1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
