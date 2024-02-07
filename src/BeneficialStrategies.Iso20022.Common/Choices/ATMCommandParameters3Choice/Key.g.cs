﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Key.  ISO2002 ID# _htqcO12aEeekzJIz1JxYSQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters3Choice;

/// <summary>
/// Parameters to be used by the various cryptographic key commands.
/// </summary>
public partial record Key : ATMCommandParameters3Choice_
     , IIsoXmlSerilizable<Key>
{
    #nullable enable
    
    /// <summary>
    /// Category of the cryptographic key.
    /// </summary>
    public CryptographicKeyType4Code? KeyCategory { get; init; } 
    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    public IsoMax140Binary? HostChallenge { get; init; } 
    /// <summary>
    /// Ordered certificate chain of the asymmetric key encryption key, starting with the host certificate.
    /// </summary>
    public IsoMax5000Binary? Certificate { get; init; } 
    /// <summary>
    /// Cryptographic key involved in the security command.
    /// </summary>
    public KEKIdentifier4? KeyProperties { get; init; } 
    
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
        if (KeyCategory is CryptographicKeyType4Code KeyCategoryValue)
        {
            writer.WriteStartElement(null, "KeyCtgy", xmlNamespace );
            writer.WriteValue(KeyCategoryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (HostChallenge is IsoMax140Binary HostChallengeValue)
        {
            writer.WriteStartElement(null, "HstChllng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Binary(HostChallengeValue)); // data type Max140Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (Certificate is IsoMax5000Binary CertificateValue)
        {
            writer.WriteStartElement(null, "Cert", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5000Binary(CertificateValue)); // data type Max5000Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (KeyProperties is KEKIdentifier4 KeyPropertiesValue)
        {
            writer.WriteStartElement(null, "KeyProps", xmlNamespace );
            KeyPropertiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Key Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
