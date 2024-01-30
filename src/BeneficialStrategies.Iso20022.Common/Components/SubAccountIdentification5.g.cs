﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification5.  ISO2002 ID# _QTjzNNp-Ed-ak6NoX_4Aeg_1662748352.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SubAccountIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IAccountIdentificationFormatChoice Identification { get; init; } 
    /// <summary>
    /// Indicates whether the securities in the account are fungible, ie, interchangeable.
    /// </summary>
    public required IsoYesNoIndicator FungibleIndicator { get; init; } 
    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    public AggregateBalanceInformation4? BalanceForSubAccount { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
