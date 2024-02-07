﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMSecurityConfiguration4.  ISO2002 ID# _u0cgsYr8EeSvuOJS0mmL0g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration of the digital signatures if the security module is able to perform digital signatures with an asymmetric key.
/// </summary>
public partial record ATMSecurityConfiguration4
     : IIsoXmlSerilizable<ATMSecurityConfiguration4>
{
    #nullable enable
    
    /// <summary>
    /// Maximum number of certificates in a certificate path, the security module is able to manage.
    /// </summary>
    public IsoNumber? MaximumCertificates { get; init; } 
    /// <summary>
    /// Maximum number of cosigners, the security module is able to manage in a digital signature.
    /// </summary>
    public IsoNumber? MaximumSignatures { get; init; } 
    /// <summary>
    /// Digital signature algorithm the security module is able to manage.
    /// </summary>
    public Algorithm14Code? DigitalSignatureAlgorithm { get; init; } 
    
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
        if (MaximumCertificates is IsoNumber MaximumCertificatesValue)
        {
            writer.WriteStartElement(null, "MaxCerts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(MaximumCertificatesValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (MaximumSignatures is IsoNumber MaximumSignaturesValue)
        {
            writer.WriteStartElement(null, "MaxSgntrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(MaximumSignaturesValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (DigitalSignatureAlgorithm is Algorithm14Code DigitalSignatureAlgorithmValue)
        {
            writer.WriteStartElement(null, "DgtlSgntrAlgo", xmlNamespace );
            writer.WriteValue(DigitalSignatureAlgorithmValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static ATMSecurityConfiguration4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
