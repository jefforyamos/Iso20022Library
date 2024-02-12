﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalRequestInformation1.  ISO2002 ID# _TiOuodp-Ed-ak6NoX_4Aeg_1502660608.
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
/// Set of characteristics that unambiguously identify the original global invoice financing request.
/// </summary>
[IsoId("_TiOuodp-Ed-ak6NoX_4Aeg_1502660608")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Original Request Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalRequestInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalRequestInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalRequestInformation1( System.String reqIdentification,System.DateTime reqCreationDateTime,ValidationStatusInformation1 reqValidationStatusInformation )
    {
        Identification = reqIdentification;
        CreationDateTime = reqCreationDateTime;
        ValidationStatusInformation = reqValidationStatusInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the original request message as assigned by the original sending party.
    /// </summary>
    [IsoId("_TiOuotp-Ed-ak6NoX_4Aeg_1331216430")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the original request message was created.
    /// </summary>
    [IsoId("_TiOuo9p-Ed-ak6NoX_4Aeg_822273349")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creation Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Party that requests the invoice financing, on behalf of a creditor, as indicated in the original request message.
    /// </summary>
    [IsoId("_TiOupNp-Ed-ak6NoX_4Aeg_1500618546")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financing Requestor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount6? FinancingRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount6? FinancingRequestor { get; init; } 
    #else
    public PartyIdentificationAndAccount6? FinancingRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives the request from the financing requestor and forwards it to the first agent for execution, as indicated in the original request message.
    /// </summary>
    [IsoId("_TiOupdp-Ed-ak6NoX_4Aeg_745955200")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediary Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of financing requestor to which an invoice financing request is addressed, as indicated in the original request message.
    /// </summary>
    [IsoId("_TiOuptp-Ed-ak6NoX_4Aeg_989766263")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("First Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification6? FirstAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification6? FirstAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification6? FirstAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the validation status of the request message.
    /// </summary>
    [IsoId("_TiOup9p-Ed-ak6NoX_4Aeg_-1776871398")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Validation Status Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValidationStatusInformation1 ValidationStatusInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ValidationStatusInformation1 ValidationStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusInformation1 ValidationStatusInformation { get; init; } 
    #else
    public ValidationStatusInformation1 ValidationStatusInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the business status of the cancellation.
    /// </summary>
    [IsoId("_TiOuqNp-Ed-ak6NoX_4Aeg_-219603516")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation Status Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationStatusInformation1? CancellationStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatusInformation1? CancellationStatusInformation { get; init; } 
    #else
    public CancellationStatusInformation1? CancellationStatusInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
