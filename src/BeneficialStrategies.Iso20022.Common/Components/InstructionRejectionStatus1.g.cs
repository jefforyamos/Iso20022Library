﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructionRejectionStatus1.  ISO2002 ID# _RWwVldp-Ed-ak6NoX_4Aeg_-151657311.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the rejection of the instruction or cancellation request.
/// </summary>
[DataContract]
[XmlType]
public partial record InstructionRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason advising the rejection of the instruction.
    /// </summary>
    [DataMember]
    public required RejectionReason1Code Reason { get; init; } 
    /// <summary>
    /// This code can be used in case another reason is required.
    /// </summary>
    [DataMember]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    [DataMember]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
