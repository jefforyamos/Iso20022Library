﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DerivativeEventTypeV2Code.  ISO2002 ID# _YLv1ME2VEe2bQ-Ksk8mwQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YLv1ME2VEe2bQ-Ksk8mwQg")]
[Description(@"Explanation or reason for the action being taken on the transaction reporting.")]
public enum DerivativeEventTypeV2Code
{
    /// <summary>
    /// Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives.
    /// </summary>
    [EnumMember(Value = "ALOC")]
    [IsoId("_nODWwE2VEe2bQ-Ksk8mwQg")]
    [Description(@"Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives.")]
    ALOC,
    
    /// <summary>
    /// Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer.
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_qiBo8E2VEe2bQ-Ksk8mwQg")]
    [Description(@"Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer.")]
    CLRG,
    
    /// <summary>
    /// Simultaneous clearing and allocation event in a derivatives clearing organisation.
    /// </summary>
    [EnumMember(Value = "CLAL")]
    [IsoId("_soAeAE2VEe2bQ-Ksk8mwQg")]
    [Description(@"Simultaneous clearing and allocation event in a derivatives clearing organisation.")]
    CLAL,
    
    /// <summary>
    /// Compression or post-trade risk reduction exercise.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_um7o0E2VEe2bQ-Ksk8mwQg")]
    [Description(@"Compression or post-trade risk reduction exercise.")]
    COMP,
    
    /// <summary>
    /// Result of a corporate action.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_2E-HsE2VEe2bQ-Ksk8mwQg")]
    [Description(@"Result of a corporate action.")]
    CORP,
    
    /// <summary>
    /// Applies only to credit derivatives. A credit event that results in a termination or modification of a derivative, at a trade or position level.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_3ys00E2VEe2bQ-Ksk8mwQg")]
    [Description(@"Applies only to credit derivatives. A credit event that results in a termination or modification of a derivative, at a trade or position level.")]
    CREV,
    
    /// <summary>
    /// Termination of an existing derivative transaction prior to scheduled termination or maturity date.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_BbJVwE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Termination of an existing derivative transaction prior to scheduled termination or maturity date.")]
    ETRM,
    
    /// <summary>
    /// The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. 
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_DPC8UE2WEe2bQ-Ksk8mwQg")]
    [Description(@"The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. ")]
    EXER,
    
    /// <summary>
    /// Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_FObaIE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.")]
    INCP,
    
    /// <summary>
    /// The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_Gv_6kE2WEe2bQ-Ksk8mwQg")]
    [Description(@"The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.")]
    NOVA,
    
    /// <summary>
    /// The process by which a derivative transaction is transferred to another trade repository using the same UTI.
    /// </summary>
    [EnumMember(Value = "PTNG")]
    [IsoId("_I3PT4E2WEe2bQ-Ksk8mwQg")]
    [Description(@"The process by which a derivative transaction is transferred to another trade repository using the same UTI.")]
    PTNG,
    
    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_K0ZkIE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.")]
    REVI,
    
    /// <summary>
    /// Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_Mzxa4E2WEe2bQ-Ksk8mwQg")]
    [Description(@"Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.")]
    TRAD,
    
    /// <summary>
    /// Outstanding derivative is updated to comply with the revised requirements on reporting.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_OoybwE2WEe2bQ-Ksk8mwQg")]
    [Description(@"Outstanding derivative is updated to comply with the revised requirements on reporting.")]
    UPDT,
    
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


