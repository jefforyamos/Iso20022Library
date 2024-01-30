﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountDetails2.  ISO2002 ID# _U2KG0brQEeiRnc958wUXqA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a bank account
/// </summary>
public partial record AccountDetails2
{
    #nullable enable
    
    /// <summary>
    /// Name of the account as assigned by the account servicing institution in an agreement with the account owner in order to provide an additional means of identification of the account.
    /// </summary>
    public IsoMax70Text? AccountName { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// See ISO 8583 bit 3, Account type codes
    /// </summary>
    public IsoExact2AlphaNumericText? AccountType { get; init; } 
    /// <summary>
    /// Identification of an account.
    /// ISO 8583 bit 102 or bit 103
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    #nullable disable
}
