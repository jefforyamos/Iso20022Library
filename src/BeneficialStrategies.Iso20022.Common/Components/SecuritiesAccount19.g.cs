﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccount19.  ISO2002 ID# _T_JUKtp-Ed-ak6NoX_4Aeg_1976638301.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SecuritiesAccount19
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
