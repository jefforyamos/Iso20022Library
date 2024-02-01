﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NewAccount3.  ISO2002 ID# _a8noUdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the new account.
/// </summary>
public partial record NewAccount3
{
    #nullable enable
    
    /// <summary>
    /// Details of the new account.
    /// </summary>
    public required CashAccount41 Account { get; init; } 
    /// <summary>
    /// Party or parties to be identified in the context of account operations.
    /// </summary>
    public IndividualPerson36[] AccountParty { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    public Organisation35? Organisation { get; init; } 
    
    #nullable disable
}
