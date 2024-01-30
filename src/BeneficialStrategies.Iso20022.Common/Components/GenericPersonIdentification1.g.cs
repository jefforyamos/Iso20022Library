﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericPersonIdentification1.  ISO2002 ID# _P_4pRtp-Ed-ak6NoX_4Aeg_-893603485.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification of a person.
/// </summary>
public partial record GenericPersonIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a person.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IPersonIdentificationSchemeName1Choice? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
    #nullable disable
}
