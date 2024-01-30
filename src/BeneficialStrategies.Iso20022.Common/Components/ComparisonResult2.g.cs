﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ComparisonResult2.  ISO2002 ID# _RbOl4dp-Ed-ak6NoX_4Aeg_153355944.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
public partial record ComparisonResult2
{
    #nullable enable
    
    /// <summary>
    /// Sequence number assigned to the element.
    /// </summary>
    public required IsoNumber ElementSequenceNumber { get; init; } 
    /// <summary>
    /// Specifies from the root of the message the complete path of the element.
    /// </summary>
    public required IsoMax350Text ElementPath { get; init; } 
    /// <summary>
    /// Name of the element.
    /// </summary>
    public required IsoMax35Text ElementName { get; init; } 
    /// <summary>
    /// Replacement of an existing content by a different one.
    /// </summary>
    public required Replacement2 Replacement { get; init; } 
    /// <summary>
    /// Deletion of the current element.
    /// </summary>
    public required Deletion2 Deletion { get; init; } 
    /// <summary>
    /// Addition of a new element.
    /// </summary>
    public required Addition2 Addition { get; init; } 
    
    #nullable disable
}
