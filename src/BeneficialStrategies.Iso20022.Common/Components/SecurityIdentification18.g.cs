﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification18.  ISO2002 ID# _el9wcID3EeSQoe-8fZQlpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security by its symbol.
/// </summary>
public partial record SecurityIdentification18
     : IIsoXmlSerilizable<SecurityIdentification18>
{
    #nullable enable
    
    /// <summary>
    /// Security identification source of the trade.
    /// </summary>
    public required IdentificationType2Code SecurityIdentificationSource { get; init; } 
    /// <summary>
    /// Security identification of the trade.
    /// </summary>
    public required IsoMax35Text SecurityIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "SctyIdSrc", xmlNamespace );
        writer.WriteValue(SecurityIdentificationSource.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(SecurityIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static SecurityIdentification18 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
