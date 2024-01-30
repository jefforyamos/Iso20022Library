﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountManagementMessageReference1.  ISO2002 ID# _RPTpwNp-Ed-ak6NoX_4Aeg_1905550020.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the account management instruction message for which the status is requested.
/// </summary>
public partial record AccountManagementMessageReference1
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    public AdditionalReference3? OtherReference { get; init; } 
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    public AdditionalReference3? PreviousReference { get; init; } 
    /// <summary>
    /// Specifies if the status request refers to an earlier account opening or modification instruction message.
    /// </summary>
    public required AccountManagementType1Code StatusRequestType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    public InvestmentAccount14? InvestmentAccount { get; init; } 
    
    #nullable disable
}
