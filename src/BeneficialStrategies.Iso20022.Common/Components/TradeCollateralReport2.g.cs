﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeCollateralReport2.  ISO2002 ID# _Sh7OIS-_EeWvZpCvNOLJLQ.
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
[IsoId("_Sh7OIS-_EeWvZpCvNOLJLQ")]
[DisplayName("Trade Collateral Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCollateralReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information indicating the type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_Su5TIS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Collateralisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Collstn")]
    #endif
    [IsoXmlTag("Collstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralisationType1Code? Collateralisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationType1Code? Collateralisation { get; init; } 
    #else
    public CollateralisationType1Code? Collateralisation { get; set; } 
    #endif
    
    /// <summary>
    /// A unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_Su5TIy-_EeWvZpCvNOLJLQ")]
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
    [IsoId("_Su5TJS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Initial Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstd")]
    #endif
    [IsoXmlTag("InitlMrgnPstd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd20Amount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd20Amount? InitialMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InitialMarginPosted { get; init; } 
    #else
    public System.Decimal? InitialMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty. 
    /// Usage: Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_Su5TJy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Variation Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstd")]
    #endif
    [IsoXmlTag("VartnMrgnPstd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd20Amount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd20Amount? VariationMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? VariationMarginPosted { get; init; } 
    #else
    public System.Decimal? VariationMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty. 
    /// Usage: Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_Su5TKS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Initial Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvd")]
    #endif
    [IsoXmlTag("InitlMrgnRcvd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd20Amount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd20Amount? InitialMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InitialMarginReceived { get; init; } 
    #else
    public System.Decimal? InitialMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Usage: Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_Su5TKy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Variation Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvd")]
    #endif
    [IsoXmlTag("VartnMrgnRcvd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd20Amount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd20Amount? VariationMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? VariationMarginReceived { get; init; } 
    #else
    public System.Decimal? VariationMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_Su5TLS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Excess Collateral Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollPstd")]
    #endif
    [IsoXmlTag("XcssCollPstd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd20Amount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd20Amount? ExcessCollateralPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExcessCollateralPosted { get; init; } 
    #else
    public System.Decimal? ExcessCollateralPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_Su5TLy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Excess Collateral Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollRcvd")]
    #endif
    [IsoXmlTag("XcssCollRcvd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd20Amount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd20Amount? ExcessCollateralReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExcessCollateralReceived { get; init; } 
    #else
    public System.Decimal? ExcessCollateralReceived { get; set; } 
    #endif
    
    
    #nullable disable
    
}
