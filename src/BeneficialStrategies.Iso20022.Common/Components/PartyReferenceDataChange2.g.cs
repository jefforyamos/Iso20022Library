﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyReferenceDataChange2.  ISO2002 ID# _70efBVhLEeih3fUfzR38Ig.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
public partial record PartyReferenceDataChange2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the party for which the changes are listed in the advice.
    /// </summary>
    public required SystemPartyIdentification8 PartyIdentification { get; init; } 
    /// <summary>
    /// Provides the party data record for which details of the change are provided.
    /// </summary>
    public IUpdateLogPartyRecord1Choice? Record { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
    #nullable disable
}
