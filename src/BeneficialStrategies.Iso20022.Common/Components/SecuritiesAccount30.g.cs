﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccount30.  ISO2002 ID# _5SG1s5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SecuritiesAccount30
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoRestrictedFINXMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    public GenericIdentification47? Type { get; init; } 
    /// <summary>
    /// Description of the account.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    
    #nullable disable
}
