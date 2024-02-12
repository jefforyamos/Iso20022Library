﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherCertificateDataSet1.  ISO2002 ID# _Tncl2dp-Ed-ak6NoX_4Aeg_-105876723.
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
/// Formal document used to record a fact and used as proof of the fact, in the context of a commercial trade transaction.
/// </summary>
[IsoId("_Tncl2dp-Ed-ak6NoX_4Aeg_-105876723")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Other Certificate Data Set")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherCertificateDataSet1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherCertificateDataSet1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherCertificateDataSet1( DocumentIdentification1 reqDataSetIdentification,System.String reqCertificateIdentification,TradeCertificateType2Code reqCertificateType,System.DateOnly reqIssueDate,PartyIdentification26 reqIssuer )
    {
        DataSetIdentification = reqDataSetIdentification;
        CertificateIdentification = reqCertificateIdentification;
        CertificateType = reqCertificateType;
        IssueDate = reqIssueDate;
        Issuer = reqIssuer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the certificate data set.
    /// </summary>
    [IsoId("_TnmW0Np-Ed-ak6NoX_4Aeg_629308440")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Data Set Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 DataSetIdentification { get; init; } 
    #else
    public DocumentIdentification1 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_TnmW0dp-Ed-ak6NoX_4Aeg_1312675433")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CertificateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CertificateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateIdentification { get; init; } 
    #else
    public System.String CertificateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_TnmW0tp-Ed-ak6NoX_4Aeg_212738392")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCertificateType2Code CertificateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TradeCertificateType2Code CertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCertificateType2Code CertificateType { get; init; } 
    #else
    public TradeCertificateType2Code CertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_TnmW09p-Ed-ak6NoX_4Aeg_224743278")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issue Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateOnly IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssueDate { get; init; } 
    #else
    public System.DateOnly IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the certificate, typically the inspection company or its agent.
    /// </summary>
    [IsoId("_TnmW1Np-Ed-ak6NoX_4Aeg_722520574")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification26 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Issuer { get; init; } 
    #else
    public PartyIdentification26 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional and important information that could not be captured by structured fields.
    /// </summary>
    [IsoId("_TnmW1dp-Ed-ak6NoX_4Aeg_237674436")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CertificateInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateInformation { get; init; } 
    #else
    public System.String? CertificateInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
