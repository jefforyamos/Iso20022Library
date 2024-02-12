﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransaction37.  ISO2002 ID# _DRVSMXhQEeu3kecHd7QKUQ.
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
/// Provides details of the trade transaction.
/// </summary>
[IsoId("_DRVSMXhQEeu3kecHd7QKUQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Trade Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransaction37
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransaction37 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransaction37( UniqueTransactionIdentifier1Choice_ reqUniqueTransactionIdentifier )
    {
        UniqueTransactionIdentifier = reqUniqueTransactionIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
    /// </summary>
    [IsoId("_Df6gwXhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unique Transaction Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UniqueTransactionIdentifier1Choice_ UniqueTransactionIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public UniqueTransactionIdentifier1Choice_ UniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier1Choice_ UniqueTransactionIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier1Choice_ UniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the UTI assigned to the predecessor transaction that has given rise to the reported transaction due to a lifecycle event.
    /// |
    /// Usage: This data element is not applicable when reporting many-to-one and many-to-many relations between transactions (for example, in the case of a compression).
    /// This data element may be applicable when reporting one-to-one and one-to-many relations between transactions (for example, in the case of a clearing).|
    /// </summary>
    [IsoId("_Df6gw3hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Prior Unique Transaction Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier1Choice_? PriorUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier1Choice_? PriorUniqueTransactionIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier1Choice_? PriorUniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [IsoId("_Df6gxXhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Report Tracking Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportTrackingNumber { get; init; } 
    #else
    public System.String? ReportTrackingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading platform on which the derivative transaction was executed (e.g. exchange, multilateral trading facility, swap execution facility). ||
    /// Usage: |For transactions where no trading facility was involved, specific predefined codes have to be used.
    /// </summary>
    [IsoId("_Df6gx3hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Platform Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? PlatformIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlatformIdentifier { get; init; } 
    #else
    public System.String? PlatformIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// </summary>
    [IsoId("_Df6gyXhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Compression")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Compression { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Compression { get; init; } 
    #else
    public System.String? Compression { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_Df6gy3hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceData1? TransactionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceData1? TransactionPrice { get; init; } 
    #else
    public PriceData1? TransactionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates monetary or converted amount for the derivatives transaction.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_Df6gzXhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notional Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(2)]
    #endif
    public ValueList<NotionalAmount1> NotionalAmount { get; init; } = new ValueList<NotionalAmount1>(){};
    
    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.|
    /// </summary>
    [IsoId("_Df6gz3hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notional Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(2)]
    #endif
    public ValueList<NotionalQuantity1> NotionalQuantity { get; init; } = new ValueList<NotionalQuantity1>(){};
    
    /// <summary>
    /// Specifies the ratio of the absolute change in price of a derivative transaction to the change in price of the underlier, at the time a new transaction is reported or when a change in the notional amount is reported.
    /// </summary>
    [IsoId("_Df6g0XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delta")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction19DecimalNumber? Delta { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Delta { get; init; } 
    #else
    public System.UInt64? Delta { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_Df6g03hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity32Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [IsoId("_Df6g1XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivery Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #else
    public PhysicalTransferType4Code? DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the execution of the derivative transaction.
    /// </summary>
    [IsoId("_Df6g13hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Execution Time Stamp")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExecutionTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExecutionTimeStamp { get; init; } 
    #else
    public System.DateTime? ExecutionTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_Df6g2XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Effective Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EffectiveDate { get; init; } 
    #else
    public System.DateOnly? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the derivative transaction stop being effective, as included in the confirmation.|
    /// For European style options, date on which the holder can exercise the right or let it lapse.
    /// For American style options, the holder can exercise the right up to the expiry date.||
    /// Usage: |An early termination shall not be reported in this field.
    /// </summary>
    [IsoId("_Df6g23hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expiration Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpirationDate { get; init; } 
    #else
    public System.DateOnly? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    [IsoId("_Df6g3XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Early Termination Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EarlyTerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EarlyTerminationDate { get; init; } 
    #else
    public System.DateOnly? EarlyTerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unadjusted date, as per the contract, by which all transfer of cash or assets should take place and the counterparties should no longer have any outstanding obligations to each other.||
    /// For products that may not have a final contractual settlement date (eg American options), this data element reflects the date by which the transfer of cash or asset would take place if termination were to occur on the expiration date.
    /// </summary>
    [IsoId("_Df6g33hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_Df6g43hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Master Agreement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement7? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement7? MasterAgreement { get; init; } 
    #else
    public MasterAgreement7? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [IsoId("_Df6g5XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Confirmation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeConfirmation1Choice_? TradeConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeConfirmation1Choice_? TradeConfirmation { get; init; } 
    #else
    public TradeConfirmation1Choice_? TradeConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [IsoId("_Df6g53hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Clearing")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeClearing5? TradeClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeClearing5? TradeClearing { get; init; } 
    #else
    public TradeClearing5? TradeClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [IsoId("_Df6g6XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateLegs9? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateLegs9? InterestRate { get; init; } 
    #else
    public InterestRateLegs9? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [IsoId("_Df6g63hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange17? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange17? Currency { get; init; } 
    #else
    public CurrencyExchange17? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [IsoId("_Df6g7XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commodity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassCommodity2Choice_? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassCommodity2Choice_? Commodity { get; init; } 
    #else
    public AssetClassCommodity2Choice_? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity delivered in the European Union.
    /// </summary>
    [IsoId("_Df6g73hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Energy Specific Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergySpecificAttribute6? EnergySpecificAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergySpecificAttribute6? EnergySpecificAttributes { get; init; } 
    #else
    public EnergySpecificAttribute6? EnergySpecificAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_Df6g8XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionOrSwaption7? Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionOrSwaption7? Option { get; init; } 
    #else
    public OptionOrSwaption7? Option { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_Df6g83hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDerivative4? Credit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDerivative4? Credit { get; init; } 
    #else
    public CreditDerivative4? Credit { get; set; } 
    #endif
    
    /// <summary>
    /// Payment related to elements not reported in dedicated fields.
    /// </summary>
    [IsoId("_Df6g9XhQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Payment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherPayment3? OtherPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherPayment3? OtherPayment { get; init; } 
    #else
    public OtherPayment3? OtherPayment { get; set; } 
    #endif
    
    /// <summary>
    /// A combination of two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement.
    /// </summary>
    [IsoId("_Df6g93hQEeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Package")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Package1? Package { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Package1? Package { get; init; } 
    #else
    public Package1? Package { get; set; } 
    #endif
    
    
    #nullable disable
    
}
