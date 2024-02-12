﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashParties28.  ISO2002 ID# _Nb34KUGLEeWqy4niLuXETA.
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
/// Specifies cash parties in the framework of a corporate action event.
/// </summary>
[IsoId("_Nb34KUGLEeWqy4niLuXETA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cash Parties")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashParties28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_No9440GLEeWqy4niLuXETA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount120? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount120? Creditor { get; init; } 
    #else
    public PartyIdentificationAndAccount120? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_No9460GLEeWqy4niLuXETA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount121? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount121? CreditorAgent { get; init; } 
    #else
    public PartyIdentificationAndAccount121? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party that has reimbursed the account owner with funds to which they were legally entitled.
    /// </summary>
    [IsoId("_No9480GLEeWqy4niLuXETA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Claim Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount120? MarketClaimCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount120? MarketClaimCounterparty { get; init; } 
    #else
    public PartyIdentificationAndAccount120? MarketClaimCounterparty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
