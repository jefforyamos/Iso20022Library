﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails63.  ISO2002 ID# _ccpBEzi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[DataContract]
[XmlType]
public partial record IntraPositionDetails63
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [DataMember]
    public SafekeepingPlaceFormat39Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [DataMember]
    public required SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [DataMember]
    public ValueList<IntraPositionMovementDetails20> IntraPositionMovement { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
