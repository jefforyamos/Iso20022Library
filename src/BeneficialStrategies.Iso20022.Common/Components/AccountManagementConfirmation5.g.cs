﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountManagementConfirmation5.  ISO2002 ID# _a_WqsZS-EemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of request or instruction.
/// </summary>
public partial record AccountManagementConfirmation5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the confirmation type.
    /// </summary>
    public required IConfirmationType1Choice ConfirmationType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    public AdditionalReference13? CounterpartyReference { get; init; } 
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    public Account23? ExistingAccountIdentification { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
