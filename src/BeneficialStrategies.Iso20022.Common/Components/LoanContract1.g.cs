﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanContract1.  ISO2002 ID# _uCfA8NLJEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract by which an amount of money in exchange for future repayment of the principal amount along with interest or other finance charges.
/// </summary>
[DataContract]
[XmlType]
public partial record LoanContract1
{
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this loan agreement.
    /// </summary>
    [DataMember]
    public required DocumentIdentification22 ContractDocumentIdentification { get; init; } 
    /// <summary>
    /// Party that is specified as the buyer for this loan agreement.
    /// </summary>
    [DataMember]
    public ValueList<TradeParty2> Buyer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that is specified as the seller for this loan agreement.
    /// </summary>
    [DataMember]
    public ValueList<TradeParty2> Seller { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Loan amount as defined in the contract.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [DataMember]
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator ProlongationFlag { get; init; } 
    /// <summary>
    /// Start date of the loan contract.
    /// </summary>
    [DataMember]
    public required IsoISODate StartDate { get; init; } 
    /// <summary>
    /// Currency in which the loan is being settled.
    /// </summary>
    [DataMember]
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    /// <summary>
    /// When the amount is credited outside of the country, special conditions are applicable.
    /// </summary>
    [DataMember]
    public SpecialCondition1? SpecialConditions { get; init; } 
    /// <summary>
    /// Loan duration in a coded form.
    /// </summary>
    [DataMember]
    public required IsoExact1NumericText DurationCode { get; init; } 
    /// <summary>
    /// Interest rate for the loan.
    /// </summary>
    [DataMember]
    public required InterestRate2Choice_ InterestRate { get; init; } 
    /// <summary>
    /// One part or division of the loan, used to define the repayment.
    /// </summary>
    [DataMember]
    public ValueList<LoanContractTranche1> Tranche { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Schedule of the payments defined for the loan contract.
    /// </summary>
    [DataMember]
    public PaymentSchedule1Choice_? PaymentSchedule { get; init; } 
    /// <summary>
    /// Schedule of the interest payments defined for the loan contract.
    /// </summary>
    [DataMember]
    public required InterestPaymentSchedule1Choice_ InterestSchedule { get; init; } 
    /// <summary>
    /// Loan is an intra company loan.
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; } 
    /// <summary>
    /// Details of the collateral for the loan.
    /// </summary>
    [DataMember]
    public ContractCollateral1? Collateral { get; init; } 
    /// <summary>
    /// Loan offered by a group of lenders (called a syndicate) who work together to provide funds for a single borrower.
    /// </summary>
    [DataMember]
    public ValueList<SyndicatedLoan1> SyndicatedLoan { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Documents provided as attachments to the loan contract.
    /// </summary>
    [DataMember]
    public ValueList<DocumentGeneralInformation3> Attachment { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
