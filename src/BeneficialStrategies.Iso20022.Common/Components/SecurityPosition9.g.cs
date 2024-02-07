﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityPosition9.  ISO2002 ID# _CuyrkVtjEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the securities for which the meeting is organised.
/// </summary>
public partial record SecurityPosition9
     : IIsoXmlSerilizable<SecurityPosition9>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    public ValueList<EligiblePosition6> Position { get; init; } = [];
    
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
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pos", xmlNamespace );
        Position.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SecurityPosition9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
