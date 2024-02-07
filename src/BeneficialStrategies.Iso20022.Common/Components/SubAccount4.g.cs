﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccount4.  ISO2002 ID# __mJHsWpMEeSjPYeXoHq7Ng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record SubAccount4
     : IIsoXmlSerilizable<SubAccount4>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentification26 Identification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Specifies additional properties of the account.
    /// </summary>
    public IsoMax35Text? Characteristic { get; init; } 
    
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
        if (Name is IsoMax35Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Characteristic is IsoMax35Text CharacteristicValue)
        {
            writer.WriteStartElement(null, "Chrtc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CharacteristicValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static SubAccount4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
