﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccount10.  ISO2002 ID# _QUJpF9p-Ed-ak6NoX_4Aeg_-1770262344.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the securities account.
/// </summary>
public partial record SecuritiesAccount10
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    public IPartyIdentification2Choice? AccountOwnerIdentification { get; init; } 
    /// <summary>
    /// Nationality of the account owner.
    /// </summary>
    public NationalityCode? AccountOwnerNationality { get; init; } 
    /// <summary>
    /// Idenfitication of the account.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Type of balance.
    /// </summary>
    public ISecuritiesBalanceType9FormatChoice? BalanceType { get; init; } 
    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; } 
    
    #nullable disable
}
