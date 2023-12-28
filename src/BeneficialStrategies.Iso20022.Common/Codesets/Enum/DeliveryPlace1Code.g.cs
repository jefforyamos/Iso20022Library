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
    /// Card needs to be mailed to employers address.
    /// Encoded/decoded by serializers as "Employer".
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_azANkdp-Ed-ak6NoX_4Aeg_-743931467")]
    [Description(@"Card needs to be mailed to employers address.")]
    Employer,
    
    /// <summary>
    /// Card needs to be mailed to individual specified in PersonDetail.
    /// Encoded/decoded by serializers as "Individual".
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_azANktp-Ed-ak6NoX_4Aeg_-743931451")]
    [Description(@"Card needs to be mailed to individual specified in PersonDetail.")]
    Individual,
    
    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as "EntranceOfMeeting".
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_azANk9p-Ed-ak6NoX_4Aeg_-743931450")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    EntranceOfMeeting,
    
    /// <summary>
    /// Cards needs to be send to other specified address.
    /// Encoded/decoded by serializers as "OtherAddress".
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_azANlNp-Ed-ak6NoX_4Aeg_1639092662")]
    [Description(@"Cards needs to be send to other specified address.")]
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


