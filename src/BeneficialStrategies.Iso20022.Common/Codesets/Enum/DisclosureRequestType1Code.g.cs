﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisclosureRequestType1Code.  ISO2002 ID# _OQLLYEV3EemRx7jyevcLwg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OQLLYEV3EemRx7jyevcLwg")]
[Description(@"Type of disclosure request.")]
[DerivedFrom(typeof(DisclosureRequestTypeCode))]
public enum DisclosureRequestType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "New".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SWm1QUV3EemRx7jyevcLwg")]
    [Description(@"??")]
    New,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Replacement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SdTTIUV3EemRx7jyevcLwg")]
    [Description(@"??")]
    Replacement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisclosureRequestType1CodeMetadataExtensions
{
    private static readonly DisclosureRequestType1CodeDropdownSource _dropdownSource = new DisclosureRequestType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisclosureRequestType1CodeDropdownRow GetMetadata(this DisclosureRequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


