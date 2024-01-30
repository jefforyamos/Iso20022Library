﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument76.  ISO2002 ID# _XHDzMf1PEeixXcHVEYIW2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifying features of a financial instrument that is a sub-set of an investment fund.
/// </summary>
public partial record FinancialInstrument76
{
    #nullable enable
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    public IsoRestrictedFINXMax35Text? SupplementaryIdentification { get; init; } 
    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Features of units offered by a fund. for example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, 'Class A', 'Class 2'.
    /// </summary>
    public IsoRestrictedFINXMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    public ISecurityClassificationType3Choice? ClassificationType { get; init; } 
    
    #nullable disable
}
