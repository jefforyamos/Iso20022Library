﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace39.  ISO2002 ID# _hXcvnyp6EeyR9JrVGfaMKw.
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
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_hXcvnyp6EeyR9JrVGfaMKw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Aggregate Balance Per Safekeeping Place")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateBalancePerSafekeepingPlace39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateBalancePerSafekeepingPlace39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateBalancePerSafekeepingPlace39( SafeKeepingPlace3 reqSafekeepingPlace,Balance17 reqAggregateBalance )
    {
        SafekeepingPlace = reqSafekeepingPlace;
        AggregateBalance = reqAggregateBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_husxZyp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Place")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafeKeepingPlace3 SafekeepingPlace { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SafeKeepingPlace3 SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace3 SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace3 SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_husxbyp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Listing")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification3Choice_? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_husxdyp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pledgee")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pledgee3? Pledgee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pledgee3? Pledgee { get; init; } 
    #else
    public Pledgee3? Pledgee { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_husxeSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Aggregate Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Balance17 AggregateBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Balance17 AggregateBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance17 AggregateBalance { get; init; } 
    #else
    public Balance17 AggregateBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_husxgSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Available Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Balance18? AvailableBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance18? AvailableBalance { get; init; } 
    #else
    public Balance18? AvailableBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_husxiSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Not Available Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceQuantity14Choice_? NotAvailableBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity14Choice_? NotAvailableBalance { get; init; } 
    #else
    public BalanceQuantity14Choice_? NotAvailableBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_husxkSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation20? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation20? PriceDetails { get; init; } 
    #else
    public PriceInformation20? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_husxmSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Foreign Exchange Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_husxoSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Days Accrued")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DaysAccrued { get; init; } 
    #else
    public System.UInt64? DaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_husxqSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Base Currency Amounts")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_husxsSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instrument Currency Amounts")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_husxuSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity Breakdown")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown57? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown57? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown57? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_husxwSp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exposure Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType22Choice_? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType22Choice_? ExposureType { get; init; } 
    #else
    public ExposureType22Choice_? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_husxwyp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Breakdown")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubBalanceInformation20? BalanceBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceInformation20? BalanceBreakdown { get; init; } 
    #else
    public SubBalanceInformation20? BalanceBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_husxyyp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Balance Breakdown")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation20? AdditionalBalanceBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation20? AdditionalBalanceBreakdown { get; init; } 
    #else
    public AdditionalBalanceInformation20? AdditionalBalanceBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_husx0yp6EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Holding Additional Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HoldingAdditionalDetails { get; init; } 
    #else
    public System.String? HoldingAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
