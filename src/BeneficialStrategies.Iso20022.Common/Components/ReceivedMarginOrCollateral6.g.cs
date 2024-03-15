﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceivedMarginOrCollateral6.  ISO2002 ID# _lgGRIYmKEeybbN9emGqfiw.
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
/// Information on the received margin or collateral of the transaction.
/// </summary>
[IsoId("_lgGRIYmKEeybbN9emGqfiw")]
[DisplayName("Received Margin Or Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceivedMarginOrCollateral6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_lhNEYYmKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Received Pre Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvdPreHrcut")]
    #endif
    [IsoXmlTag("InitlMrgnRcvdPreHrcut")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAnd20DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginReceivedPreHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InitialMarginReceivedPreHaircut { get; init; } 
    #else
    public System.Decimal? InitialMarginReceivedPreHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_lhNEY4mKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Received Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvdPstHrcut")]
    #endif
    [IsoXmlTag("InitlMrgnRcvdPstHrcut")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAnd20DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginReceivedPostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InitialMarginReceivedPostHaircut { get; init; } 
    #else
    public System.Decimal? InitialMarginReceivedPostHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_lhNEZYmKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Received Pre Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvdPreHrcut")]
    #endif
    [IsoXmlTag("VartnMrgnRcvdPreHrcut")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAnd20DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginReceivedPreHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? VariationMarginReceivedPreHaircut { get; init; } 
    #else
    public System.Decimal? VariationMarginReceivedPreHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_lhNEZ4mKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Received Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvdPstHrcut")]
    #endif
    [IsoXmlTag("VartnMrgnRcvdPstHrcut")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAnd20DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginReceivedPostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? VariationMarginReceivedPostHaircut { get; init; } 
    #else
    public System.Decimal? VariationMarginReceivedPostHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_lhNEaYmKEeybbN9emGqfiw")]
    [DisplayName("Excess Collateral Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollRcvd")]
    #endif
    [IsoXmlTag("XcssCollRcvd")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAnd20DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAnd20DecimalAmount? ExcessCollateralReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExcessCollateralReceived { get; init; } 
    #else
    public System.Decimal? ExcessCollateralReceived { get; set; } 
    #endif
    
    
    #nullable disable
    
}
