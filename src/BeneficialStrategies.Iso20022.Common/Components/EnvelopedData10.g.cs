﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnvelopedData10.  ISO2002 ID# _wKYgQXDOEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with encryption key.
/// </summary>
public partial record EnvelopedData10
     : IIsoXmlSerilizable<EnvelopedData10>
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Provides certificates of the originator.
    /// </summary>
    public OriginatorInformation1? OriginatorInformation { get; init; } 
    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    public Recipient14Choice_? Recipient { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _wSCAZXDOEe2MCaKO5AtGsA
    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    public EncryptedContent6? EncryptedContent { get; init; } 
    
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
        if (Version is IsoNumber VersionValue)
        {
            writer.WriteStartElement(null, "Vrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(VersionValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (OriginatorInformation is OriginatorInformation1 OriginatorInformationValue)
        {
            writer.WriteStartElement(null, "OrgtrInf", xmlNamespace );
            OriginatorInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize Recipient, multiplicity Unknown
        if (EncryptedContent is EncryptedContent6 EncryptedContentValue)
        {
            writer.WriteStartElement(null, "NcrptdCntt", xmlNamespace );
            EncryptedContentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static EnvelopedData10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
