﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DistributionType1Code.  ISO2002 ID# _aw6i4dp-Ed-ak6NoX_4Aeg_-1335531039.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aw6i4dp-Ed-ak6NoX_4Aeg_-1335531039")]
[Description(@"Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.")]
[DerivedFrom(typeof(DistributionTypeCode))]
public enum DistributionType1Code
{
    /// <summary>
    /// Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.
    /// Encoded/decoded by serializers as "RollingBasis".
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_aw6i4tp-Ed-ak6NoX_4Aeg_-1335531037")]
    [Description(@"Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.")]
    RollingBasis,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DistributionType1CodeMetadataExtensions
{
    private static readonly DistributionType1CodeDropdownSource _dropdownSource = new DistributionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDistributionType1CodeDropdownRow GetMetadata(this DistributionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


