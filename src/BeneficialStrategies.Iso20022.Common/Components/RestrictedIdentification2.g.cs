﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RestrictedIdentification2.  ISO2002 ID# _V6-HoNp-Ed-ak6NoX_4Aeg_-2073103164.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
public partial record RestrictedIdentification2
     : IIsoXmlSerilizable<RestrictedIdentification2>
{
    #nullable enable
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
    /// </summary>
    public required IsoRestrictedSEPACodeText IdentificationType { get; init; } 
    
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
        writer.WriteStartElement(null, "IdTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedSEPACodeText(IdentificationType)); // data type RestrictedSEPACodeText System.String
        writer.WriteEndElement();
    }
    public static RestrictedIdentification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
