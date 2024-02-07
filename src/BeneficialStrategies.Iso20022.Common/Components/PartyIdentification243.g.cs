﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification243.  ISO2002 ID# _JmJYYygxEeuqgbMAZaNiGw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification243
     : IIsoXmlSerilizable<PartyIdentification243>
{
    #nullable enable
    
    /// <summary>
    /// Legal entity.
    /// </summary>
    public PartyIdentification237? LegalPerson { get; init; } 
    /// <summary>
    /// Private person.
    /// </summary>
    public PartyIdentification217? NaturalPerson { get; init; } 
    
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
        if (LegalPerson is PartyIdentification237 LegalPersonValue)
        {
            writer.WriteStartElement(null, "LglPrsn", xmlNamespace );
            LegalPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NaturalPerson is PartyIdentification217 NaturalPersonValue)
        {
            writer.WriteStartElement(null, "NtrlPrsn", xmlNamespace );
            NaturalPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification243 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
