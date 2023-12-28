﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalMandateSuspensionReason1Code.  ISO2002 ID# _z3ff4YPDEeahmOIR_zFG6A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_z3ff4YPDEeahmOIR_zFG6A")]
[Description(@"Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalMandateSuspensionReasonCode))]
public enum ExternalMandateSuspensionReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContractAmended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY0ytfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ContractAmended,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContractCancellationInitiatedByDebtor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY98ovRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ContractCancellationInitiatedByDebtor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContractExpired".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY98pfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ContractExpired,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MandateSuspendedFinalCollection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY98qPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MandateSuspendedFinalCollection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MandateSuspendedOnceOffCollection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY98q_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MandateSuspendedOnceOffCollection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MandateSuspended7ConsecutiveUnsuccessfulCollections".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY98rvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MandateSuspended7ConsecutiveUnsuccessfulCollections,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalMandateSuspensionReason1CodeMetadataExtensions
{
    private static readonly ExternalMandateSuspensionReason1CodeDropdownSource _dropdownSource = new ExternalMandateSuspensionReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalMandateSuspensionReason1CodeDropdownRow GetMetadata(this ExternalMandateSuspensionReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

