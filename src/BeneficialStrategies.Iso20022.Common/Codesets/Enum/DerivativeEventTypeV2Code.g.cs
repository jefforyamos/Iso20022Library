﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DerivativeEventTypeV2Code.  ISO2002 ID# _YLv1ME2VEe2bQ-Ksk8mwQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YLv1ME2VEe2bQ-Ksk8mwQg")]
[Description(@"Explanation or reason for the action being taken on the transaction reporting.")]
[Derivations(typeof(DerivativeEventType3Code))]
public enum DerivativeEventTypeV2Code
{
    /// <summary>
    /// Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives.
    /// Encoded/decoded by serializers as "ALOC".
    /// </summary>
    [EnumMember(Value = "ALOC")]
    [IsoId("_nODWwE2VEe2bQ-Ksk8mwQg")]
    [Description(@"Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives.")]
    Allocation,
    
    /// <summary>
    /// Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer.
    /// Encoded/decoded by serializers as "CLRG".
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_qiBo8E2VEe2bQ-Ksk8mwQg")]
    [Description(@"Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer.")]
    Clearing,
    
    /// <summary>
    /// Simultaneous clearing and allocation event in a derivatives clearing organisation.
    /// Encoded/decoded by serializers as "CLAL".
    /// </summary>
    [EnumMember(Value = "CLAL")]
    [IsoId("_soAeAE2VEe2bQ-Ksk8mwQg")]
    [Description(@"Simultaneous clearing and allocation event in a derivatives clearing organisation.")]
    ClearingAndAllocation,
    
    /// <summary>
    /// Compression or post-trade risk reduction exercise.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_um7o0E2VEe2bQ-Ksk8mwQg")]
    [Description(@"Compression or post-trade risk reduction exercise.")]
    Compression,
    
    /// <summary>
    /// Result of a corporate action.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_2E-HsE2VEe2bQ-Ksk8mwQg")]
    [Description(@"Result of a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Applies only to credit derivatives. A credit event that results in a termination or modification of a derivative, at a trade or position level.
    /// Encoded/decoded by serializers as "CREV".
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_3ys00E2VEe2bQ-Ksk8mwQg")]
    [Description(@"Applies only to credit derivatives. A credit event that results in a termination or modification of a derivative, at a trade or position level.")]
    CreditEvent,
    
    /// <summary>
    /// Termination of an existing derivative transaction prior to scheduled termination or maturity date.
    /// Encoded/decoded by serializers as "ETRM".
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_BbJVwE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Termination of an existing derivative transaction prior to scheduled termination or maturity date.")]
    EarlyTermination,
    
    /// <summary>
    /// The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. 
    /// Encoded/decoded by serializers as "EXER".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_DPC8UE2WEe2bQ-Ksk8mwQg")]
    [Description(@"The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. ")]
    Exercise,
    
    /// <summary>
    /// Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.
    /// Encoded/decoded by serializers as "INCP".
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_FObaIE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.")]
    InclusionInPosition,
    
    /// <summary>
    /// The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.
    /// Encoded/decoded by serializers as "NOVA".
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_Gv_6kE2WEe2bQ-Ksk8mwQg")]
    [Description(@"The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.")]
    Novation,
    
    /// <summary>
    /// The process by which a derivative transaction is transferred to another trade repository using the same UTI.
    /// Encoded/decoded by serializers as "PTNG".
    /// </summary>
    [EnumMember(Value = "PTNG")]
    [IsoId("_I3PT4E2WEe2bQ-Ksk8mwQg")]
    [Description(@"The process by which a derivative transaction is transferred to another trade repository using the same UTI.")]
    Porting,
    
    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as "REVI".
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_K0ZkIE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.")]
    Revive,
    
    /// <summary>
    /// Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.
    /// Encoded/decoded by serializers as "TRAD".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_Mzxa4E2WEe2bQ-Ksk8mwQg")]
    [Description(@"Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.")]
    Trade,
    
    /// <summary>
    /// Outstanding derivative is updated to comply with the revised requirements on reporting.
    /// Encoded/decoded by serializers as "UPDT".
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_OoybwE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Outstanding derivative is updated to comply with the revised requirements on reporting.")]
    Update,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DerivativeEventTypeV2CodeMetadataExtensions
{
    private static readonly DerivativeEventTypeV2CodeDropdownSource _dropdownSource = new DerivativeEventTypeV2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDerivativeEventTypeV2CodeDropdownRow GetMetadata(this DerivativeEventTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


