﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternateClassification.  ISO2002 ID# _T81ZQ21MEeiqaPNRWUnGNA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType2Choice;

/// <summary>
/// Other type of classification of the financial instrument.
/// </summary>
public partial record AlternateClassification : SecurityClassificationType2Choice_
     , IIsoXmlSerilizable<AlternateClassification>
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (Issuer is IsoMax35Text IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new AlternateClassification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
