﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption19.  ISO2002 ID# _qNmb4fL_Ed-3lpUMQaXLjQ.
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
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_qNmb4fL_Ed-3lpUMQaXLjQ")]
[DisplayName("Securities Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOption19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOption19( SecurityIdentification14 reqSecurityIdentification,CreditDebitCode reqCreditDebitIndicator,Quantity6Choice_ reqPostingQuantity,DateAndDateTimeChoice_ reqPostingDate )
    {
        SecurityIdentification = reqSecurityIdentification;
        CreditDebitIndicator = reqCreditDebitIndicator;
        PostingQuantity = reqPostingQuantity;
        PostingDate = reqPostingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_qNmb4_L_Ed-3lpUMQaXLjQ")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification14 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_qNmb5fL_Ed-3lpUMQaXLjQ")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [IsoId("_qNmb5_L_Ed-3lpUMQaXLjQ")]
    [DisplayName("Posting Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngQty")]
    #endif
    [IsoXmlTag("PstngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ PostingQuantity { get; init; } 
    #else
    public Quantity6Choice_ PostingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_qNmb6fL_Ed-3lpUMQaXLjQ")]
    [DisplayName("Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDt")]
    #endif
    [IsoXmlTag("PstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ PostingDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ PostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_qNmb6_L_Ed-3lpUMQaXLjQ")]
    [DisplayName("Original Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPstngDt")]
    #endif
    [IsoXmlTag("OrgnlPstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? OriginalPostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? OriginalPostingDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? OriginalPostingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
