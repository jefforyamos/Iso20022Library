﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesFinancingDetails.  ISO2002 ID# _AYOIN9okEeC60axPepSq7g_-1464294568.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TwoLegTransactionType1Choice
{
    /// <summary>
    /// Provides details about the two leg transaction.
    /// </summary>
    [IsoId("_AYOIN9okEeC60axPepSq7g_-1464294568")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Financing Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesFinancingDetails : TwoLegTransactionType1Choice_
    #else
    public partial class SecuritiesFinancingDetails : TwoLegTransactionType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Date/Time at which rate change has taken place.
        /// </summary>
        [IsoId("_At1L1dokEeC60axPepSq7g_-695932125")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Rate Change Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? RateChangeDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? RateChangeDate { get; init; } 
        #else
        public System.DateTime? RateChangeDate { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the rate is fixed or variable.
        /// </summary>
        [IsoId("_At-VwNokEeC60axPepSq7g_-312215540")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Rate Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RateType19Choice_? RateType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateType19Choice_? RateType { get; init; } 
        #else
        public RateType19Choice_? RateType { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
        /// </summary>
        [IsoId("_At-VwdokEeC60axPepSq7g_1988607050")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Revaluation")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Revaluation2Choice_? Revaluation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Revaluation2Choice_? Revaluation { get; init; } 
        #else
        public Revaluation2Choice_? Revaluation { get; set; } 
        #endif
        
        /// <summary>
        /// Legal framework of the transaction.
        /// </summary>
        [IsoId("_At-VwtokEeC60axPepSq7g_1106850683")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Legal Framework")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LegalFramework1Code? LegalFramework { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LegalFramework1Code? LegalFramework { get; init; } 
        #else
        public LegalFramework1Code? LegalFramework { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the computation method of accrued interest of the related financial instrument.
        /// </summary>
        [IsoId("_At-Vw9okEeC60axPepSq7g_-1309287893")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Interest Computation Method")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestComputationMethod2Choice_? InterestComputationMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestComputationMethod2Choice_? InterestComputationMethod { get; init; } 
        #else
        public InterestComputationMethod2Choice_? InterestComputationMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Index or support rate used together with the spread to calculate the repurchase rate.
        /// </summary>
        [IsoId("_At-VxNokEeC60axPepSq7g_-1002610009")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Variable Rate Support")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RateName1? VariableRateSupport { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateName1? VariableRateSupport { get; init; } 
        #else
        public RateName1? VariableRateSupport { get; set; } 
        #endif
        
        /// <summary>
        /// Repurchase rate used to calculate the repurchase amount.
        /// </summary>
        [IsoId("_At-VxdokEeC60axPepSq7g_-275415175")]
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
        [IsoId("_At-VxtokEeC60axPepSq7g_721657178")]
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
        [IsoId("_AuIGwNokEeC60axPepSq7g_1718729531")]
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
        /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
        /// </summary>
        [IsoId("_AuIGwdokEeC60axPepSq7g_-1272487528")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Pricing Rate")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RateOrName1Choice_? PricingRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateOrName1Choice_? PricingRate { get; init; } 
        #else
        public RateOrName1Choice_? PricingRate { get; set; } 
        #endif
        
        /// <summary>
        /// Margin over or under an index that determines the repurchase rate, expressed as a rate or an amount.
        /// </summary>
        [IsoId("_AuIGwtokEeC60axPepSq7g_2025407415")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Spread Rate")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SpreadRate1? SpreadRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SpreadRate1? SpreadRate { get; init; } 
        #else
        public SpreadRate1? SpreadRate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether or not the trade is callable.
        /// </summary>
        [IsoId("_AuIGw9okEeC60axPepSq7g_-1267193902")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Callable Trade Indicator")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? CallableTradeIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CallableTradeIndicator { get; init; } 
        #else
        public System.String? CallableTradeIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Minimum number of days' notice a counterparty needs for terminating the transaction.
        /// </summary>
        [IsoId("_AuIGxNokEeC60axPepSq7g_-1999682362")]
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
        public IsoMax3NumericText? TransactionCallDelay { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TransactionCallDelay { get; init; } 
        #else
        public System.String? TransactionCallDelay { get; set; } 
        #endif
        
        /// <summary>
        /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
        /// </summary>
        [IsoId("_AuIGxdokEeC60axPepSq7g_-965809644")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Accrued Interest Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection5? AccruedInterestAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection5? AccruedInterestAmount { get; init; } 
        #else
        public AmountAndDirection5? AccruedInterestAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Interest rate that has been accrued in between coupon payment periods.
        /// </summary>
        [IsoId("_AuIGxtokEeC60axPepSq7g_-933857720")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Accrued Interest Percentage")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? AccruedInterestPercentage { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? AccruedInterestPercentage { get; init; } 
        #else
        public System.Decimal? AccruedInterestPercentage { get; set; } 
        #endif
        
        /// <summary>
        /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
        /// </summary>
        [IsoId("_AuRQsNokEeC60axPepSq7g_1028335062")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Forfeit Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection5? ForfeitAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection5? ForfeitAmount { get; init; } 
        #else
        public AmountAndDirection5? ForfeitAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
        /// </summary>
        [IsoId("_AuRQsdokEeC60axPepSq7g_-1193971907")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Premium Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection5? PremiumAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection5? PremiumAmount { get; init; } 
        #else
        public AmountAndDirection5? PremiumAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money to be settled per piece of collateral to close the transaction.
        /// </summary>
        [IsoId("_AuRQstokEeC60axPepSq7g_-1962881997")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Closing Amount Per Pieces Of Collateral")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; init; } 
        #else
        public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the total Number of collateral instructions involved in the transaction.
        /// </summary>
        [IsoId("_AuRQs9okEeC60axPepSq7g_1298212581")]
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
        public IsoMax3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TotalNumberOfCollateralInstructions { get; init; } 
        #else
        public System.String? TotalNumberOfCollateralInstructions { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details for the securities financing transaction.
        /// </summary>
        [IsoId("_AuRQtNokEeC60axPepSq7g_2103923036")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Financing Agreement")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Agreement3? FinancingAgreement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Agreement3? FinancingAgreement { get; init; } 
        #else
        public Agreement3? FinancingAgreement { get; set; } 
        #endif
        
        /// <summary>
        /// Method applied to a lending transaction.
        /// </summary>
        [IsoId("_AuRQtdokEeC60axPepSq7g_414120520")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Lending Transaction Method")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; init; } 
        #else
        public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates if the contract is with or without an exchange of collateral.
        /// </summary>
        [IsoId("_AuRQttokEeC60axPepSq7g_-232941151")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Lending With Collateral")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? LendingWithCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LendingWithCollateral { get; init; } 
        #else
        public System.String? LendingWithCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the underlying reason for the borrowing, for instance, sale on my behalf or on behalf of a third party.
        /// </summary>
        [IsoId("_AubBsNokEeC60axPepSq7g_-1443291770")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Borrowing Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BorrowingReason1Choice_? BorrowingReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BorrowingReason1Choice_? BorrowingReason { get; init; } 
        #else
        public BorrowingReason1Choice_? BorrowingReason { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the type of collateral, for insatnce, security, bond, etc.
        /// </summary>
        [IsoId("_AubBsdokEeC60axPepSq7g_-412210548")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Collateral Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralType1Choice_? CollateralType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralType1Choice_? CollateralType { get; init; } 
        #else
        public CollateralType1Choice_? CollateralType { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether or not the contract terms changed.
        /// </summary>
        [IsoId("_AubBstokEeC60axPepSq7g_-1017643701")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Contract Terms Modification Changed")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? ContractTermsModificationChanged { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ContractTermsModificationChanged { get; init; } 
        #else
        public System.String? ContractTermsModificationChanged { get; set; } 
        #endif
        
        /// <summary>
        /// Interest rate to be paid as agreed between the counterparties.
        /// </summary>
        [IsoId("_AubBs9okEeC60axPepSq7g_1287973967")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Interest Rate")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Rate2? InterestRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Rate2? InterestRate { get; init; } 
        #else
        public Rate2? InterestRate { get; set; } 
        #endif
        
        /// <summary>
        /// Rate to be paid by the Borrower to the Lender for the securities borrowed.
        /// </summary>
        [IsoId("_AubBtNokEeC60axPepSq7g_-228030791")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Borrowing Rate")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Rate2? BorrowingRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Rate2? BorrowingRate { get; init; } 
        #else
        public Rate2? BorrowingRate { get; set; } 
        #endif
        
        /// <summary>
        /// Method used to calculate the standard collateral amount.
        /// </summary>
        [IsoId("_AubBtdokEeC60axPepSq7g_367898826")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Standard Collateral Ratio")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Rate2? StandardCollateralRatio { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Rate2? StandardCollateralRatio { get; init; } 
        #else
        public Rate2? StandardCollateralRatio { get; set; } 
        #endif
        
        /// <summary>
        /// Percentage of earnings paid to shareholders in dividends.
        /// </summary>
        [IsoId("_AukysNokEeC60axPepSq7g_641828188")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Dividend Ratio")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Rate2? DividendRatio { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Rate2? DividendRatio { get; init; } 
        #else
        public Rate2? DividendRatio { get; set; } 
        #endif
        
        /// <summary>
        /// Number of days the securities are lent or borrowed where the contract has an agreed closing date.
        /// </summary>
        [IsoId("_AukysdokEeC60axPepSq7g_-1206770256")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Number Of Days Lending Borrowing")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Number21Choice_? NumberOfDaysLendingBorrowing { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Number21Choice_? NumberOfDaysLendingBorrowing { get; init; } 
        #else
        public Number21Choice_? NumberOfDaysLendingBorrowing { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the standard collateral amount.
        /// </summary>
        [IsoId("_AukystokEeC60axPepSq7g_1937742031")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Standard Collateral Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection5? StandardCollateralAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection5? StandardCollateralAmount { get; init; } 
        #else
        public AmountAndDirection5? StandardCollateralAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Interest rate tax that has been accrued in between coupon payment periods.
        /// </summary>
        [IsoId("_Aukys9okEeC60axPepSq7g_-1335503795")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Accrued Interest Tax")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? AccruedInterestTax { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AccruedInterestTax { get; init; } 
        #else
        public System.String? AccruedInterestTax { get; set; } 
        #endif
        
        /// <summary>
        /// Number of days accrued at the instant of closing trade.
        /// </summary>
        [IsoId("_AukytNokEeC60axPepSq7g_460885409")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("End Number Of Days Accrued")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax3Number? EndNumberOfDaysAccrued { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? EndNumberOfDaysAccrued { get; init; } 
        #else
        public System.UInt64? EndNumberOfDaysAccrued { get; set; } 
        #endif
        
        /// <summary>
        /// End ratio of principal outstanding to the original balance.
        /// </summary>
        [IsoId("_AukytdokEeC60axPepSq7g_1286453782")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("End Factor")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoBaseOneRate? EndFactor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? EndFactor { get; init; } 
        #else
        public System.Decimal? EndFactor { get; set; } 
        #endif
        
        /// <summary>
        /// Type of securities lending.
        /// </summary>
        [IsoId("_AukyttokEeC60axPepSq7g_702451242")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Securities Lending Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; init; } 
        #else
        public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
        /// </summary>
        [IsoId("_Aut8oNokEeC60axPepSq7g_-1062983843")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reversible")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Reversible1Choice_? Reversible { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Reversible1Choice_? Reversible { get; init; } 
        #else
        public Reversible1Choice_? Reversible { get; set; } 
        #endif
        
        /// <summary>
        /// This is the minimum date at which the Borrower is allowed to give back the securities.
        /// </summary>
        [IsoId("_Aut8odokEeC60axPepSq7g_1976821560")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Minimum Date For Call Back")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? MinimumDateForCallBack { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? MinimumDateForCallBack { get; init; } 
        #else
        public System.DateOnly? MinimumDateForCallBack { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates that the contract can be rolled over.
        /// </summary>
        [IsoId("_Aut8otokEeC60axPepSq7g_446006542")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Roll Over")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? RollOver { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RollOver { get; init; } 
        #else
        public System.String? RollOver { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the securities lending fees can be paid periodically or at the end of the contract.
        /// </summary>
        [IsoId("_Aut8o9okEeC60axPepSq7g_788130492")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Periodic Payment")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? PeriodicPayment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PeriodicPayment { get; init; } 
        #else
        public System.String? PeriodicPayment { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the trade is executed ex coupon.
        /// </summary>
        [IsoId("_Aut8pNokEeC60axPepSq7g_1099234723")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Ex Coupon")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? ExCoupon { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ExCoupon { get; init; } 
        #else
        public System.String? ExCoupon { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
