﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CertificateManagementRequest2.  ISO2002 ID# _gt6twQ0UEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of certificate management.
/// </summary>
public partial record CertificateManagementRequest2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    public required GenericIdentification176 POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    public GenericIdentification176? TMIdentification { get; init; } 
    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    public required CardPaymentServiceType10Code CertificateService { get; init; } 
    /// <summary>
    /// Identification of the client and server public key infrastructures containing the certificate. In addition, it may identify specific requirements of the customer.
    /// </summary>
    public IsoMax70Text? SecurityDomain { get; init; } 
    /// <summary>
    /// PKCS#10 (Public Key Certificate Standard 10) certification request coded in base64 ASN.1/DER (Abstract Syntax Notation 1, Distinguished Encoding Rules) or PEM (Privacy Enhanced Message) format.
    /// </summary>
    public IsoMax20000Text? BinaryCertificationRequest { get; init; } 
    /// <summary>
    /// Certification request PKCS#10 (Public Key Certificate Standard 10) for creation or renewal of an X.509 certificate.
    /// </summary>
    public CertificationRequest1? CertificationRequest { get; init; } 
    /// <summary>
    /// Created certificate. The certificate is ASN.1/DER encoded, for renewal or revocation of certificate.
    /// </summary>
    public IsoMax10KBinary? ClientCertificate { get; init; } 
    /// <summary>
    /// Identification of the white list element, for white list addition or removal.
    /// </summary>
    public PointOfInteraction6? WhiteListIdentification { get; init; } 
    
    #nullable disable
}
