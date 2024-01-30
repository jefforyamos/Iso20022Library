﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet15.  ISO2002 ID# _QmvQAWpPEeSR-ZWLvO-1dg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the management plan of a point of interaction (POI).
/// </summary>
public partial record TerminalManagementDataSet15
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    public required DataSetIdentification4 Identification { get; init; } 
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    /// <summary>
    /// Content of the management plan.
    /// </summary>
    public ManagementPlanContent4? Content { get; init; } 
    
    #nullable disable
}
