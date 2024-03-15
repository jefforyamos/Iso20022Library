﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceInquiryRequest4.  ISO2002 ID# _TljRUS9DEeu125Ip9zFcsQ.
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
/// Content of the Balance Inquiry Request message.
/// </summary>
[IsoId("_TljRUS9DEeu125Ip9zFcsQ")]
[DisplayName("Balance Inquiry Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceInquiryRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_TyPpgS9DEeu125Ip9zFcsQ")]
    [DisplayName("Payment Account Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcctReq")]
    #endif
    [IsoXmlTag("PmtAcctReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    #else
    public PaymentAccountRequest1? PaymentAccountRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_TyPpgy9DEeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Account Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcctReq")]
    #endif
    [IsoXmlTag("LltyAcctReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccountRequest2? LoyaltyAccountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccountRequest2? LoyaltyAccountRequest { get; init; } 
    #else
    public LoyaltyAccountRequest2? LoyaltyAccountRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_TyPphS9DEeu125Ip9zFcsQ")]
    [DisplayName("Stored Value Account Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValAcctReq")]
    #endif
    [IsoXmlTag("StordValAcctReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueRequest4? StoredValueAccountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueRequest4? StoredValueAccountRequest { get; init; } 
    #else
    public StoredValueRequest4? StoredValueAccountRequest { get; set; } 
    #endif
    
    
    #nullable disable
    
}
