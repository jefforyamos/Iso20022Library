﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FileActionResponse1.  ISO2002 ID# _dUB4wVZjEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the file action.
/// </summary>
[DataContract]
[XmlType]
public partial record FileActionResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    [DataMember]
    public required Environment3 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [DataMember]
    public Context8? Context { get; init; } 
    /// <summary>
    /// File action transaction details.
    /// </summary>
    [DataMember]
    public required Transaction90 Transaction { get; init; } 
    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    [DataMember]
    public required ResultData4 ProcessingResult { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [DataMember]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
