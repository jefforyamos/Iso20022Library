﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ManagementPlanContent10.  ISO2002 ID# _lfNqgU6pEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the management plan.
/// </summary>
[DataContract]
[XmlType]
public partial record ManagementPlanContent10
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [DataMember]
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Certificate chain of an asymmetric encryption keys for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [DataMember]
    public ValueList<TMSAction10> Action { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
