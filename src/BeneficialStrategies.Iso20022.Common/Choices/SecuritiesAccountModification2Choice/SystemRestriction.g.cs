﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SystemRestriction.  ISO2002 ID# _8IwTgzp0Eemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountModification2Choice;

/// <summary>
/// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
/// </summary>
public partial record SystemRestriction : SecuritiesAccountModification2Choice_
     , IIsoXmlSerilizable<SystemRestriction>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the date from which the restriction is valid.
    /// </summary>
    public required IsoISODateTime ValidFrom { get; init; } 
    /// <summary>
    /// Specifies the date until which the restriction is valid.
    /// </summary>
    public IsoISODateTime? ValidTo { get; init; } 
    /// <summary>
    /// Specifies the identification of a restriction.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "VldFr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ValidFrom)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (ValidTo is IsoISODateTime ValidToValue)
        {
            writer.WriteStartElement(null, "VldTo", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ValidToValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Type)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new SystemRestriction Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
