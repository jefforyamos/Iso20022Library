﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentControlRequestType1Code.  ISO2002 ID# _EJVeUJIhEeect698_YsnIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EJVeUJIhEeect698_YsnIA")]
[Description(@"Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code set published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentControlRequestTypeCode))]
public enum ExternalPaymentControlRequestType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReleasePending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_udl9-PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ReleasePending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HoldNormal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_udl9-_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    HoldNormal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_udl9_vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Cancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReSequence".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_udvH4vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ReSequence,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReleaseSuspicious".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_udvH5fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ReleaseSuspicious,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentControlRequestType1CodeMetadataExtensions
{
    private static readonly ExternalPaymentControlRequestType1CodeDropdownSource _dropdownSource = new ExternalPaymentControlRequestType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentControlRequestType1CodeDropdownRow GetMetadata(this ExternalPaymentControlRequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


