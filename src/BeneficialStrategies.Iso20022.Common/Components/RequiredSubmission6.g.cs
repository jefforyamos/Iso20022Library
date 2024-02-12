﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequiredSubmission6.  ISO2002 ID# _7keh8QgIEeSeS5xdjFfOTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of the certificate data set.
/// </summary>
[IsoId("_7keh8QgIEeSeS5xdjFfOTw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Required Submission")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequiredSubmission6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequiredSubmission6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequiredSubmission6( System.String reqCertificateType,System.String reqCertificateTypeDescription )
    {
        CertificateType = reqCertificateType;
        CertificateTypeDescription = reqCertificateTypeDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_77-b8QgIEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public BICIdentification1? Submitter { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _77-b8QgIEeSeS5xdjFfOTw
    
    /// <summary>
    /// Specifies the type of the certificate, in 4 letters, for example BENE for beneficiary certificate, SHIP for shipping line certifcate.
    /// </summary>
    [IsoId("_77-b8wgIEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact4AlphaNumericText CertificateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateType { get; init; } 
    #else
    public System.String CertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the certificate type required.
    /// </summary>
    [IsoId("_klV3QAgJEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Type Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text CertificateTypeDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CertificateTypeDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateTypeDescription { get; init; } 
    #else
    public System.String CertificateTypeDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
