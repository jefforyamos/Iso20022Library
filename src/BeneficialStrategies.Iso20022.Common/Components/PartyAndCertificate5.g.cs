﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyAndCertificate5.  ISO2002 ID# _D_AxJ249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and related security certificate.
/// </summary>
public partial record PartyAndCertificate5
     : IIsoXmlSerilizable<PartyAndCertificate5>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    public Modification1Code? ModificationCode { get; init; } 
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    public required PartyIdentification135 Party { get; init; } 
    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    public IsoMax10KBinary? Certificate { get; init; } 
    
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
        if (ModificationCode is Modification1Code ModificationCodeValue)
        {
            writer.WriteStartElement(null, "ModCd", xmlNamespace );
            writer.WriteValue(ModificationCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Certificate is IsoMax10KBinary CertificateValue)
        {
            writer.WriteStartElement(null, "Cert", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10KBinary(CertificateValue)); // data type Max10KBinary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static PartyAndCertificate5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
