﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Presentation4.  ISO2002 ID# _vsXgeX1qEeGlwNeVP9egyg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the presentation of documents.
/// </summary>
public partial record Presentation4
{
    #nullable enable
    
    /// <summary>
    /// Medium through which the presentation can be submitted such as paper, electronic or both.
    /// </summary>
    public IPresentationMedium1Choice? Medium { get; init; } 
    /// <summary>
    /// Document required to be presented.
    /// </summary>
    public Document11? Document { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information related to the presentation.
    /// </summary>
    // public IReadOnlyCollection<IsoMax2000Text> AdditionalInformation { get; init; }
    
    #nullable disable
}
