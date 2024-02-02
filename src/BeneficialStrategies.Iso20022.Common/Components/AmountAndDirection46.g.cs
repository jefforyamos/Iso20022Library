﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection46.  ISO2002 ID# _-ZtTMzp8EeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[DataContract]
[XmlType]
public partial record AmountAndDirection46
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the net proceeds include interest accrued on the financial instrument.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; } 
    /// <summary>
    /// Whether the net proceeds include stamp duty amount.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? StampDutyIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the net proceeds include brokerage fees for the transaction. If absent, element is not required.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? BrokerageAmountIndicator { get; init; } 
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [DataMember]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [DataMember]
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    
    #nullable disable
}
