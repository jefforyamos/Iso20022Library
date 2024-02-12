﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData95.  ISO2002 ID# _4xNiEbOYEemDE9K-I5TT8Q.
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
/// Specifies the loan data details in case of a repurchase trade transaction.
/// </summary>
[IsoId("_4xNiEbOYEemDE9K-I5TT8Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Loan Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanData95
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoanData95 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoanData95( System.String reqUniqueTradeIdentifier,System.DateOnly reqEventDate,System.DateTime reqExecutionDateTime,Cleared10Choice_ reqClearingStatus,System.String reqTradingVenue,System.DateOnly reqValueDate,System.String reqDeliveryByValue,CollateralDeliveryMethod1Code reqCollateralDeliveryMethod )
    {
        UniqueTradeIdentifier = reqUniqueTradeIdentifier;
        EventDate = reqEventDate;
        ExecutionDateTime = reqExecutionDateTime;
        ClearingStatus = reqClearingStatus;
        TradingVenue = reqTradingVenue;
        ValueDate = reqValueDate;
        DeliveryByValue = reqDeliveryByValue;
        CollateralDeliveryMethod = reqCollateralDeliveryMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_43g-a7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unique Trade Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String UniqueTradeIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UniqueTradeIdentifier { get; init; } 
    #else
    public System.String UniqueTradeIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_43g-bbOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Event Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate EventDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateOnly EventDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly EventDate { get; init; } 
    #else
    public System.DateOnly EventDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_43g-dbOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Execution Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ExecutionDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime ExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ExecutionDateTime { get; init; } 
    #else
    public System.DateTime ExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_43g-b7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cleared10Choice_ ClearingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Cleared10Choice_ ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cleared10Choice_ ClearingStatus { get; init; } 
    #else
    public Cleared10Choice_ ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    [IsoId("_43g-cbOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trading Venue")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMICIdentifier TradingVenue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradingVenue { get; init; } 
    #else
    public System.String TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_43g-c7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Master Agreement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement6? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement6? MasterAgreement { get; init; } 
    #else
    public MasterAgreement6? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_43g-d7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    [IsoId("_43g-e7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("General Collateral")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    #else
    public SpecialCollateral1Code? GeneralCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_43g-YbOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivery By Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String DeliveryByValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DeliveryByValue { get; init; } 
    #else
    public System.String DeliveryByValue { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery method of the collateral.
    /// </summary>
    [IsoId("_43g-Y7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Delivery Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
    #else
    public CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
    /// </summary>
    [IsoId("_43g-ZbOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Term")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractTerm3Choice_? Term { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractTerm3Choice_? Term { get; init; } 
    #else
    public ContractTerm3Choice_? Term { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_43g-Z7OYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate20Choice_? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate20Choice_? InterestRate { get; init; } 
    #else
    public InterestRate20Choice_? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    [IsoId("_43g-abOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Principal Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PrincipalAmount2? PrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PrincipalAmount2? PrincipalAmount { get; init; } 
    #else
    public PrincipalAmount2? PrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    [IsoId("_43g-ebOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Termination Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TerminationDate { get; init; } 
    #else
    public System.DateOnly? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    [IsoId("_43g-fbOYEemDE9K-I5TT8Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unit Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
    #else
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
