﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryPlace1Code.  ISO2002 ID# _azANkNp-Ed-ak6NoX_4Aeg_-743931469.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies where the attendance card should be delivered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azANkNp-Ed-ak6NoX_4Aeg_-743931469")]
[Description(@"Specifies where the attendance card should be delivered.")]
[DerivedFrom(typeof(DeliveryPlaceCode))]
public enum DeliveryPlace1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Employer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azANkdp-Ed-ak6NoX_4Aeg_-743931467")]
    [Description(@"??")]
    Employer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Individual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azANktp-Ed-ak6NoX_4Aeg_-743931451")]
    [Description(@"??")]
    Individual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EntranceOfMeeting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azANk9p-Ed-ak6NoX_4Aeg_-743931450")]
    [Description(@"??")]
    EntranceOfMeeting,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherAddress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azANlNp-Ed-ak6NoX_4Aeg_1639092662")]
    [Description(@"??")]
    OtherAddress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryPlace1CodeMetadataExtensions
{
    private static readonly DeliveryPlace1CodeDropdownSource _dropdownSource = new DeliveryPlace1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryPlace1CodeDropdownRow GetMetadata(this DeliveryPlace1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


