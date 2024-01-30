﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardAccount4.  ISO2002 ID# _eYroYYp5EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer account information.
/// </summary>
public partial record CardAccount4
{
    #nullable enable
    
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    public AccountChoiceMethod1Code? SelectionMethod { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    public CardAccountType2Code? SelectedAccountType { get; init; } 
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner's identity and the account number.
    /// </summary>
    public IsoMax70Text? AccountName { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public NameAndAddress3? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    public IAccountIdentification31Choice? AccountIdentifier { get; init; } 
    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    public IsoMax35Text? CreditReference { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public IPartyIdentification72Choice? Servicer { get; init; } 
    /// <summary>
    /// Balance of the account.
    /// </summary>
    public AmountAndDirection43? Balance { get; init; } 
    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; } 
    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; } 
    
    #nullable disable
}
