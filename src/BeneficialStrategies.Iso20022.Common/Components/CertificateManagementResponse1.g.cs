﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CertificateManagementResponse1.  ISO2002 ID# _PATyUI4WEeW6h7rGyYlyTg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result of the certificate management request.
/// </summary>
public partial record CertificateManagementResponse1
     : IIsoXmlSerilizable<CertificateManagementResponse1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    public required GenericIdentification72 POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    public GenericIdentification72? TMIdentification { get; init; } 
    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    public required CardPaymentServiceType10Code CertificateService { get; init; } 
    /// <summary>
    /// Outcome of the certificate service processing.
    /// </summary>
    public required ResponseType6 Result { get; init; } 
    /// <summary>
    /// Identification of the security profile, for creation, renewal or revocation of certificate.
    /// </summary>
    public IsoMax35Text? SecurityProfile { get; init; } 
    /// <summary>
    /// Created or renewed certificate. The certificate is ASN.1/DER encoded.
    /// </summary>
    public IsoMax3000Binary? ClientCertificate { get; init; } 
    /// <summary>
    /// Certificate of the client certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    public IsoMax10KBinary? ClientCertificatePath { get; init; } 
    /// <summary>
    /// Certificate of the server certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    public IsoMax10KBinary? ServerCertificatePath { get; init; } 
    
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
        writer.WriteStartElement(null, "POIId", xmlNamespace );
        POIIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TMIdentification is GenericIdentification72 TMIdentificationValue)
        {
            writer.WriteStartElement(null, "TMId", xmlNamespace );
            TMIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CertSvc", xmlNamespace );
        writer.WriteValue(CertificateService.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rslt", xmlNamespace );
        Result.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityProfile is IsoMax35Text SecurityProfileValue)
        {
            writer.WriteStartElement(null, "SctyPrfl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecurityProfileValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientCertificate is IsoMax3000Binary ClientCertificateValue)
        {
            writer.WriteStartElement(null, "ClntCert", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3000Binary(ClientCertificateValue)); // data type Max3000Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (ClientCertificatePath is IsoMax10KBinary ClientCertificatePathValue)
        {
            writer.WriteStartElement(null, "ClntCertPth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10KBinary(ClientCertificatePathValue)); // data type Max10KBinary System.Byte[]
            writer.WriteEndElement();
        }
        if (ServerCertificatePath is IsoMax10KBinary ServerCertificatePathValue)
        {
            writer.WriteStartElement(null, "SvrCertPth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10KBinary(ServerCertificatePathValue)); // data type Max10KBinary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static CertificateManagementResponse1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
