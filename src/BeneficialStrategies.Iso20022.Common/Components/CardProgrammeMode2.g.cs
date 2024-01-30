﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardProgrammeMode2.  ISO2002 ID# _2fS94-kOEemeDPHh-U9b6w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Programme or brand of the card for the transaction.
/// </summary>
public partial record CardProgrammeMode2
{
    #nullable enable
    
    /// <summary>
    /// Type of card programme or brand.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Identification of the card programme or brand.
    /// </summary>
    public IsoMax35Text? Identification { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
