﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequiredSubmission4.  ISO2002 ID# _TnmW1tp-Ed-ak6NoX_4Aeg_-1858308306.
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
[IsoId("_TnmW1tp-Ed-ak6NoX_4Aeg_-1858308306")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Required Submission")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequiredSubmission4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequiredSubmission4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequiredSubmission4( TradeCertificateType1Code reqCertificateType,System.String reqMatchIssueDate,System.String reqMatchInspectionDate,System.String reqAuthorisedInspectorIndicator,System.String reqMatchConsignee )
    {
        CertificateType = reqCertificateType;
        MatchIssueDate = reqMatchIssueDate;
        MatchInspectionDate = reqMatchInspectionDate;
        AuthorisedInspectorIndicator = reqAuthorisedInspectorIndicator;
        MatchConsignee = reqMatchConsignee;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_TnmW19p-Ed-ak6NoX_4Aeg_-1858308280")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public BICIdentification1? Submitter { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _TnmW19p-Ed-ak6NoX_4Aeg_-1858308280
    
    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_TnmW2Np-Ed-ak6NoX_4Aeg_-150714604")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCertificateType1Code CertificateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TradeCertificateType1Code CertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCertificateType1Code CertificateType { get; init; } 
    #else
    public TradeCertificateType1Code CertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the issuer must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH0Np-Ed-ak6NoX_4Aeg_1034550595")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification27? MatchIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification27? MatchIssuer { get; init; } 
    #else
    public PartyIdentification27? MatchIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the issue date must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH0dp-Ed-ak6NoX_4Aeg_-530283967")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Issue Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MatchIssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String MatchIssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchIssueDate { get; init; } 
    #else
    public System.String MatchIssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the inspection date must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH0tp-Ed-ak6NoX_4Aeg_-523817028")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Inspection Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MatchInspectionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String MatchInspectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchInspectionDate { get; init; } 
    #else
    public System.String MatchInspectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the indication of an authorised inspector must be present as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH09p-Ed-ak6NoX_4Aeg_-456402441")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authorised Inspector Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AuthorisedInspectorIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String AuthorisedInspectorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AuthorisedInspectorIndicator { get; init; } 
    #else
    public System.String AuthorisedInspectorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the consignee must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH1Np-Ed-ak6NoX_4Aeg_-198739488")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Consignee")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MatchConsignee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String MatchConsignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchConsignee { get; init; } 
    #else
    public System.String MatchConsignee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the manufacturer must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH1dp-Ed-ak6NoX_4Aeg_99351627")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Manufacturer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification27? MatchManufacturer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification27? MatchManufacturer { get; init; } 
    #else
    public PartyIdentification27? MatchManufacturer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the certificate data set is required in relation to specific line items, and which line items.
    /// </summary>
    [IsoId("_TnwH1tp-Ed-ak6NoX_4Aeg_161434273")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Line Item Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? LineItemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LineItemIdentification { get; init; } 
    #else
    public System.String? LineItemIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
