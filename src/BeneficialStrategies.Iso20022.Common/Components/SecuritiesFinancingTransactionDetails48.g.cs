﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesFinancingTransactionDetails48.  ISO2002 ID# _SsHaYffWEeiNZp_PtLohLw.
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
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_SsHaYffWEeiNZp_PtLohLw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Financing Transaction Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingTransactionDetails48
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_SsHaY_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Financing Trade Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax52Text? SecuritiesFinancingTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesFinancingTradeIdentification { get; init; } 
    #else
    public System.String? SecuritiesFinancingTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_SsHaa_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Closing Leg Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingLegIdentification { get; init; } 
    #else
    public System.String? ClosingLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_SsHac_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Termination Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminationDate7Choice_? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminationDate7Choice_? TerminationDate { get; init; } 
    #else
    public TerminationDate7Choice_? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_SsHae_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Change Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? RateChangeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? RateChangeDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? RateChangeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_SsHag_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Earliest Call Back Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_SsHahffWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commission Calculation Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_SsHah_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateType67Choice_? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType67Choice_? RateType { get; init; } 
    #else
    public RateType67Choice_? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_SsHaj_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Revaluation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RevaluationIndicator4Choice_? Revaluation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RevaluationIndicator4Choice_? Revaluation { get; init; } 
    #else
    public RevaluationIndicator4Choice_? Revaluation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_SsHal_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Legal Framework")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    #else
    public LegalFramework4Choice_? LegalFramework { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_SsHan_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Computation Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; init; } 
    #else
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_SsHap_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maturity Date Modification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaturityDateModification { get; init; } 
    #else
    public System.String? MaturityDateModification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_SsHar_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Payment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestPayment { get; init; } 
    #else
    public System.String? InterestPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_SsHat_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Variable Rate Support")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateName2? VariableRateSupport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateName2? VariableRateSupport { get; init; } 
    #else
    public RateName2? VariableRateSupport { get; set; } 
    #endif
    
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_SsHav_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repurchase Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? RepurchaseRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? RepurchaseRate { get; init; } 
    #else
    public Rate2? RepurchaseRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender's risk.
    /// </summary>
    [IsoId("_SsHax_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Stock Loan Margin")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? StockLoanMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? StockLoanMargin { get; init; } 
    #else
    public Rate2? StockLoanMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_SsHaz_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Haircut")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? SecuritiesHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? SecuritiesHaircut { get; init; } 
    #else
    public Rate2? SecuritiesHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    [IsoId("_SsHa1_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charges Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? ChargesRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? ChargesRate { get; init; } 
    #else
    public Rate2? ChargesRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_SsHa2ffWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pricing Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateOrName2Choice_? PricingRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrName2Choice_? PricingRate { get; init; } 
    #else
    public RateOrName2Choice_? PricingRate { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_SsHa4ffWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Spread")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? Spread { get; init; } 
    #else
    public Rate2? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of days' notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_SsHa6ffWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Call Delay")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionCallDelay { get; init; } 
    #else
    public System.String? TransactionCallDelay { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_SsHa8ffWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Number Of Collateral Instructions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalNumberOfCollateralInstructions { get; init; } 
    #else
    public System.String? TotalNumberOfCollateralInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_SsHa-ffWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Broker Commission")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? LocalBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? LocalBrokerCommission { get; init; } 
    #else
    public AmountAndDirection59? LocalBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_SsHa-_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deal Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? DealAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? DealAmount { get; init; } 
    #else
    public AmountAndDirection59? DealAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_SsHbA_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accrued Interest Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection59? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_SsHbC_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Forfeit Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? ForfeitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? ForfeitAmount { get; init; } 
    #else
    public AmountAndDirection59? ForfeitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_SsHbE_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Premium Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? PremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? PremiumAmount { get; init; } 
    #else
    public AmountAndDirection59? PremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_SsHbG_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; } 
    #else
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_SsHbI_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Termination Transaction Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    #else
    public AmountAndDirection59? TerminationTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_SsHbK_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Second Leg Narrative")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondLegNarrative { get; init; } 
    #else
    public System.String? SecondLegNarrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
