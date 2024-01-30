﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentificationSD1.  ISO2002 ID# _rQA50MqREeWyL6686qMenw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification information expressed as a country of fiscal domicile and a reference.
/// </summary>
public partial record GenericIdentificationSD1
{
    #nullable enable
    
    /// <summary>
    /// Country in which the account owner has one's fiscal domicile.
    /// </summary>
    public required CountryCode FiscalDomicile { get; init; } 
    /// <summary>
    /// Identification of the document assigned by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerIdentification { get; init; } 
    /// <summary>
    /// Identification of the document assigned by the account owner.
    /// </summary>
    public IsoMax35Text? AccountOwnerIdentification { get; init; } 
    
    #nullable disable
}
