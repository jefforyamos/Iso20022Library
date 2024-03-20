﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeCollateralReport1.  ISO2002 ID# _NACgIPP5EeS_qLctCs2aRQ.
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
/// Details of collateral agreement between counterparties.
/// </summary>
[IsoId("_NACgIPP5EeS_qLctCs2aRQ")]
[DisplayName("Trade Collateral Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCollateralReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCollateralReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCollateralReport1( CollateralisationType1Code reqCollateralisation )
    {
        Collateralisation = reqCollateralisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information indicating the type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_UqGo0PP5EeS_qLctCs2aRQ")]
    [DisplayName("Collateralisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Collstn")]
    #endif
    [IsoXmlTag("Collstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralisationType1Code Collateralisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralisationType1Code Collateralisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationType1Code Collateralisation { get; init; } 
    #else
    public CollateralisationType1Code Collateralisation { get; set; } 
    #endif
    
    /// <summary>
    /// A unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_YX2F4PP5EeS_qLctCs2aRQ")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Portfolio { get; init; } 
    #else
    public System.String? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty. 
    /// Usage: Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// </summary>
    [IsoId("_6mj8gPP6EeS_qLctCs2aRQ")]
    [DisplayName("Initial Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstd")]
    #endif
    [IsoXmlTag("InitlMrgnPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd20Amount? InitialMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd20Amount? InitialMarginPosted { get; init; } 
    #else
    public ActiveCurrencyAnd20Amount? InitialMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty. 
    /// Usage: Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_GvA8EPP7EeS_qLctCs2aRQ")]
    [DisplayName("Variation Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstd")]
    #endif
    [IsoXmlTag("VartnMrgnPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd20Amount? VariationMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd20Amount? VariationMarginPosted { get; init; } 
    #else
    public ActiveCurrencyAnd20Amount? VariationMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty. 
    /// Usage: Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_i9s_YvP7EeS_qLctCs2aRQ")]
    [DisplayName("Initial Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvd")]
    #endif
    [IsoXmlTag("InitlMrgnRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd20Amount? InitialMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd20Amount? InitialMarginReceived { get; init; } 
    #else
    public ActiveCurrencyAnd20Amount? InitialMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Usage: Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_i9s_Y_P7EeS_qLctCs2aRQ")]
    [DisplayName("Variation Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvd")]
    #endif
    [IsoXmlTag("VartnMrgnRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd20Amount? VariationMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd20Amount? VariationMarginReceived { get; init; } 
    #else
    public ActiveCurrencyAnd20Amount? VariationMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_EdKPUAN_EeWs3sTa9Sj6Lg")]
    [DisplayName("Excess Collateral Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollPstd")]
    #endif
    [IsoXmlTag("XcssCollPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd20Amount? ExcessCollateralPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd20Amount? ExcessCollateralPosted { get; init; } 
    #else
    public ActiveCurrencyAnd20Amount? ExcessCollateralPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_LBAW0gN_EeWs3sTa9Sj6Lg")]
    [DisplayName("Excess Collateral Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollRcvd")]
    #endif
    [IsoXmlTag("XcssCollRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd20Amount? ExcessCollateralReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd20Amount? ExcessCollateralReceived { get; init; } 
    #else
    public ActiveCurrencyAnd20Amount? ExcessCollateralReceived { get; set; } 
    #endif
    
    
    #nullable disable
    
}
