﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancingAgreementList1.  ISO2002 ID# _OTgzMTk1-AOSNFX-8224490.
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
/// Defines a list of party management registration and guarantee requests.
/// </summary>
[IsoId("_OTgzMTk1-AOSNFX-8224490")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financing Agreement List")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingAgreementList1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingAgreementList1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingAgreementList1( System.String reqIdentifier,System.DateOnly reqDate,QualifiedPartyIdentification1 reqAgreementRequestor,QualifiedPartyIdentification1 reqAgreementResponder,QualifiedPartyIdentification1 reqGuaranteeApplicant,QualifiedPartyIdentification1 reqGuaranteeBeneficiary,QualifiedPartyIdentification1 reqGuaranteeIssuer,System.String reqItemCount )
    {
        Identifier = reqIdentifier;
        Date = reqDate;
        AgreementRequestor = reqAgreementRequestor;
        AgreementResponder = reqAgreementResponder;
        GuaranteeApplicant = reqGuaranteeApplicant;
        GuaranteeBeneficiary = reqGuaranteeBeneficiary;
        GuaranteeIssuer = reqGuaranteeIssuer;
        ItemCount = reqItemCount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to unambiguously identify the agreement list.
    /// </summary>
    [IsoId("_OTgzMzQ4-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Creation date of this list.
    /// </summary>
    [IsoId("_OTgzMzQ5-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to related document.
    /// </summary>
    [IsoId("_OTgzMzUw-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Document")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Requestor of the agreement(s).
    /// </summary>
    [IsoId("_OTgzMzUx-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agreement Requestor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 AgreementRequestor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QualifiedPartyIdentification1 AgreementRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 AgreementRequestor { get; init; } 
    #else
    public QualifiedPartyIdentification1 AgreementRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Party the agreement(s) are (to be) made with.
    /// </summary>
    [IsoId("_OTgzMzUy-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agreement Responder")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 AgreementResponder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QualifiedPartyIdentification1 AgreementResponder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 AgreementResponder { get; init; } 
    #else
    public QualifiedPartyIdentification1 AgreementResponder { get; set; } 
    #endif
    
    /// <summary>
    /// Applicant of the guarantee.
    /// </summary>
    [IsoId("_OTgzMzUz-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Guarantee Applicant")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 GuaranteeApplicant { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QualifiedPartyIdentification1 GuaranteeApplicant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 GuaranteeApplicant { get; init; } 
    #else
    public QualifiedPartyIdentification1 GuaranteeApplicant { get; set; } 
    #endif
    
    /// <summary>
    /// Beneficiary of the guarantee.
    /// </summary>
    [IsoId("_OTgzMzUZ-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Guarantee Beneficiary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; } 
    #else
    public QualifiedPartyIdentification1 GuaranteeBeneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the guarantee.
    /// </summary>
    [IsoId("_OTgzMzU0-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Guarantee Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 GuaranteeIssuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QualifiedPartyIdentification1 GuaranteeIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 GuaranteeIssuer { get; init; } 
    #else
    public QualifiedPartyIdentification1 GuaranteeIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Party or parties to notify and to acknowledge the agreement.
    /// </summary>
    [IsoId("_OTgzMzU1-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notification Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingNotificationParties1? NotificationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingNotificationParties1? NotificationInformation { get; init; } 
    #else
    public FinancingNotificationParties1? NotificationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// List of agreement items.
    /// </summary>
    [IsoId("_OTgzMzU3-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Item")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public FinancingAgreementItem1? Item { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _OTgzMzU3-AOSNFX-8224501
    
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzMzU4-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Item Count")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText ItemCount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ItemCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ItemCount { get; init; } 
    #else
    public System.String ItemCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    [IsoId("_OTgzMzU5-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Control Sum")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Additional proprietary formal information concerning the list.
    /// </summary>
    [IsoId("_OTgzMzYw-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Validation status of the list.
    /// </summary>
    [IsoId("_OTgzMzYx-AOSNFX-8224501")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Validation Status Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #else
    public ValidationStatusInformation1? ValidationStatusInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
