﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount16.  ISO2002 ID# _7175Qa4AEeWL1uap3dNhCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the deposit transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record DetailedAmount16
{
    #nullable enable
    
    /// <summary>
    /// Link to the account for multi-account deposit.
    /// </summary>
    [DataMember]
    public IsoNumber? AccountSequenceNumber { get; init; } 
    /// <summary>
    /// Amount of the deposit to be made on the ATM after the approval of the deposit transaction.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? AmountToDeposit { get; init; } 
    /// <summary>
    /// Currency of the amount to deposit when different from the base currency of the ATM.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Cashback amount value.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? CashBackAmount { get; init; } 
    /// <summary>
    /// Deposit fees, accepted by the customer.
    /// </summary>
    [DataMember]
    public ValueList<DetailedAmount13> Fees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount of the donation.
    /// </summary>
    [DataMember]
    public ValueList<DetailedAmount13> Donation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
