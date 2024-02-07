﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraDayMarginCall1.  ISO2002 ID# _dC8lAEG6EemxGPEh9hU2Xg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes an instance of an intraday margin call being made against a margin account.
/// </summary>
public partial record IntraDayMarginCall1
     : IIsoXmlSerilizable<IntraDayMarginCall1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the margin account against which the intraday margin call is being made.
    /// </summary>
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    /// <summary>
    /// Value of the call being made.
    /// </summary>
    public required IsoActiveCurrencyAndAmount IntraDayCall { get; init; } 
    /// <summary>
    /// Time at which the margin call was made.
    /// </summary>
    public required IsoISODateTime TimeStamp { get; init; } 
    
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
        writer.WriteStartElement(null, "MrgnAcctId", xmlNamespace );
        MarginAccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntraDayCall", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(IntraDayCall)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TmStmp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TimeStamp)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static IntraDayMarginCall1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
