﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Account.  ISO2002 ID# _4H1_o-GBEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice;

/// <summary>
/// Unique identification of the securities account.
/// </summary>
public partial record Account : ISecuritiesAccount2Choice
{
    #nullable enable
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    public GenericIdentification30? Type { get; init; } 
    /// <summary>
    /// Description of the account.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    #nullable disable
}
