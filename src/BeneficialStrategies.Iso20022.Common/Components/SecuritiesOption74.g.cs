﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption74.  ISO2002 ID# _8Ghpo_fREeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesOption74
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [DataMember]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [DataMember]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [DataMember]
    public TemporaryFinancialInstrumentIndicator4Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    /// <summary>
    /// Specifies the nature of the securities issue.
    /// </summary>
    [DataMember]
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [DataMember]
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [DataMember]
    public GenericIdentification47? IncomeType { get; init; } 
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [DataMember]
    public ValueList<GenericIdentification47> ExemptionType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [DataMember]
    public CountryCode? CountryOfIncomeSource { get; init; } 
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [DataMember]
    public required Quantity10Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [DataMember]
    public SafekeepingPlaceFormat39Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [DataMember]
    public FractionDispositionType30Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [DataMember]
    public required SecurityDate17 DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [DataMember]
    public CorporateActionRate93? RateDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [DataMember]
    public CorporateActionPrice64? PriceDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties80? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties80? DeliveringSettlementParties { get; init; } 
    
    #nullable disable
}
