﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryPlace3Code.  ISO2002 ID# _L915cA1fEeu_4e16J8D_UA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the place of delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_L915cA1fEeu_4e16J8D_UA")]
[Description(@"Specifies the place of delivery.")]
[DerivedFrom(typeof(DeliveryPlaceV2Code))]
public enum DeliveryPlace3Code
{
    /// <summary>
    /// Card needs to be sent via e-mail.
    /// Encoded/decoded by serializers as "Email".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_OY3KYQ1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be sent via e-mail.")]
    Email,
    
    /// <summary>
    /// Card needs to be mailed to employer's address.
    /// Encoded/decoded by serializers as "Employer".
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_OgTPIQ1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to employer's address.")]
    Employer,
    
    /// <summary>
    /// Card needs to be mailed to the individual specified in PersonDetail.
    /// Encoded/decoded by serializers as "Individual".
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_OoL_0Q1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to the individual specified in PersonDetail.")]
    Individual,
    
    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as "MeetingEntrance".
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_Ot174Q1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    MeetingEntrance,
    
    /// <summary>
    /// Cards needs to be send to another specified address.
    /// Encoded/decoded by serializers as "OtherAddress".
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_O2KxcQ1fEeu_4e16J8D_UA")]
    [Description(@"Cards needs to be send to another specified address.")]
    OtherAddress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryPlace3CodeMetadataExtensions
{
    private static readonly DeliveryPlace3CodeDropdownSource _dropdownSource = new DeliveryPlace3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryPlace3CodeDropdownRow GetMetadata(this DeliveryPlace3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


