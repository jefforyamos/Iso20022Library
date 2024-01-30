﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountManagementConfirmation1.  ISO2002 ID# _RESFhNp-Ed-ak6NoX_4Aeg_190539014.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information about the type of request or instruction which triggered this confirmation.
/// </summary>
public partial record AccountManagementConfirmation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the confirmation message applies to an account opening, an account modification request or to a get account details.
    /// </summary>
    public required AccountManagementType2Code ConfirmationType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    #nullable disable
}
