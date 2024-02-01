﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PackageType4.  ISO2002 ID# _flEsIXDUEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chunk of a software package.
/// </summary>
public partial record PackageType4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the software packages of which the chunk belongs.
    /// </summary>
    public GenericIdentification176? PackageIdentification { get; init; } 
    /// <summary>
    /// Full length of software package identified through PackageIdentification.
    /// </summary>
    public IsoPositiveNumber? PackageLength { get; init; } 
    /// <summary>
    /// Place of the first following PackageBlock, beginning with 0, in the full software package identified through PackageIdentification.
    /// </summary>
    public IsoPositiveNumber? OffsetStart { get; init; } 
    /// <summary>
    /// Following place of the last following PackageBlock in the full software package identified through PackageIdentification.
    /// </summary>
    public IsoPositiveNumber? OffsetEnd { get; init; } 
    /// <summary>
    /// Consecutive slices of the full software package identified through PackageIdentification starting with first slice at the place identified with OffsetStart and ending with the last slice at the previous place identified with OffsetEnd.
    /// </summary>
    public ExternallyDefinedData4[] PackageBlock { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
