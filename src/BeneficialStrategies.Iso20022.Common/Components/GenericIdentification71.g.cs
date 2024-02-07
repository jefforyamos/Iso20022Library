﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification71.  ISO2002 ID# __g3i8WpIEeSR-ZWLvO-1dg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity.
/// </summary>
public partial record GenericIdentification71
     : IIsoXmlSerilizable<GenericIdentification71>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    public PartyType5Code? Type { get; init; } 
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    public PartyType6Code? Issuer { get; init; } 
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    public IsoMin2Max3AlphaText? Country { get; init; } 
    /// <summary>
    /// Name of the entity.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (Type is PartyType5Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Issuer is PartyType6Code IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(IssuerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Country is IsoMin2Max3AlphaText CountryValue)
        {
            writer.WriteStartElement(null, "Ctry", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin2Max3AlphaText(CountryValue)); // data type Min2Max3AlphaText System.String
            writer.WriteEndElement();
        }
        if (ShortName is IsoMax35Text ShortNameValue)
        {
            writer.WriteStartElement(null, "ShrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ShortNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static GenericIdentification71 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
