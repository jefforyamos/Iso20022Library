﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountManagementMessageReference5.  ISO2002 ID# _eQZ8AZTPEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the references of an account management instruction message.
/// </summary>
public partial record AccountManagementMessageReference5
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    public ILinkedMessage5Choice? LinkedReference { get; init; } 
    /// <summary>
    /// Type of account management instruction for which the status is requested or a request to know the status of the account.
    /// </summary>
    public required AccountManagementType3Code StatusRequestType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    public Account23? ExistingAccountIdentification { get; init; } 
    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    public InvestmentAccount77? InvestmentAccount { get; init; } 
    
    #nullable disable
}
