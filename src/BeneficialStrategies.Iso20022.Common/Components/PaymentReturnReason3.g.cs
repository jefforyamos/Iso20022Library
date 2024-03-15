﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentReturnReason3.  ISO2002 ID# _nBkHYbTREeeyuKckOGlwuA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_nBkHYbTREeeyuKckOGlwuA")]
[DisplayName("Payment Return Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentReturnReason3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [IsoId("_nKYFJbTREeeyuKckOGlwuA")]
    [DisplayName("Original Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlBkTxCd")]
    #endif
    [IsoXmlTag("OrgnlBkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_nKYFJ7TREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification125? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification125? Originator { get; init; } 
    #else
    public PartyIdentification125? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_nKYFKbTREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnReason5Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnReason5Choice_? Reason { get; init; } 
    #else
    public ReturnReason5Choice_? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_nKYFK7TREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
