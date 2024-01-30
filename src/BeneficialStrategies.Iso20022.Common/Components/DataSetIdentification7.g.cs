﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DataSetIdentification7.  ISO2002 ID# _jqZPMdqMEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a data set.
/// </summary>
public partial record DataSetIdentification7
{
    #nullable enable
    
    /// <summary>
    /// Name of the data set.
    /// </summary>
    public IsoMax256Text? Name { get; init; } 
    /// <summary>
    /// Category of data set.
    /// </summary>
    public required DataSetCategory12Code Type { get; init; } 
    /// <summary>
    /// Version of the data set.
    /// </summary>
    public IsoMax256Text? Version { get; init; } 
    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    public IsoISODateTime? CreationDateTime { get; init; } 
    
    #nullable disable
}
