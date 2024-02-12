﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCollateral13.  ISO2002 ID# _M3VawSqXEeyR9JrVGfaMKw.
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
/// Details of a security posted as collateral.
/// </summary>
[IsoId("_M3VawSqXEeyR9JrVGfaMKw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Collateral")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesCollateral13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesCollateral13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesCollateral13( SecurityIdentification19 reqSecurityIdentification,FinancialInstrumentQuantity33Choice_ reqQuantity,SafekeepingPlaceFormat29Choice_ reqSafekeepingPlace )
    {
        SecurityIdentification = reqSecurityIdentification;
        Quantity = reqQuantity;
        SafekeepingPlace = reqSafekeepingPlace;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_NnK8QSqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssetNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssetNumber { get; init; } 
    #else
    public System.String? AssetNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_NnK8QyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification19 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification19 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_NnK8RSqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maturity Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? MaturityDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    [IsoId("_NnK8RyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Ownership")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralOwnership3? CollateralOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralOwnership3? CollateralOwnership { get; init; } 
    #else
    public CollateralOwnership3? CollateralOwnership { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_NnK8SSqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Limited Coverage Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedCoverageIndicator { get; init; } 
    #else
    public System.String? LimitedCoverageIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    [IsoId("_NnK8SyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_NnK8TSqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Blocked Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity33Choice_? BlockedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_? BlockedQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_? BlockedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the security.
    /// </summary>
    [IsoId("_NnK8TyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price7? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price7? Price { get; init; } 
    #else
    public Price7? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_NnK8USqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarketValue { get; init; } 
    #else
    public System.Decimal? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_NnK8UyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Haircut")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_NnK8VSqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? CollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CollateralValue { get; init; } 
    #else
    public System.Decimal? CollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    [IsoId("_NnK8VyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_NnK8WSqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_LlFIsyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Block Chain Address Or Wallet")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_NnK8WyqXEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Place")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; set; } 
    #endif
    
    
    #nullable disable
    
}
