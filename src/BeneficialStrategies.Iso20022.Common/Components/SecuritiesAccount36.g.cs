﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccount36.  ISO2002 ID# _nXxcYddiEeispNOuywCdbA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SecuritiesAccount36
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
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    public IsoMax35Text? Designation { get; init; } 
    
    #nullable disable
}
