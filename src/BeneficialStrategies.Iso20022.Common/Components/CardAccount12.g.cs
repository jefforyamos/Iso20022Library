﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardAccount12.  ISO2002 ID# _eW6GEa4ZEeW_TaP-ygI0SQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer account information.
/// </summary>
[DataContract]
[XmlType]
public partial record CardAccount12
{
    #nullable enable
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [DataMember]
    public CardAccountType3Code? AccountType { get; init; } 
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner's identity and the account number.
    /// </summary>
    [DataMember]
    public IsoMax70Text? AccountName { get; init; } 
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [DataMember]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; } 
    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CreditReference { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [DataMember]
    public PartyIdentification72Choice_? Servicer { get; init; } 
    /// <summary>
    /// Balance of the account.
    /// </summary>
    [DataMember]
    public AmountAndDirection43? Balance { get; init; } 
    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; } 
    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; } 
    /// <summary>
    /// Service allowed on the account.
    /// </summary>
    [DataMember]
    public ValueList<ATMService19> AllowedService { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
