﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryPlaceV2Code.  ISO2002 ID# _iSfctg1eEeu_4e16J8D_UA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the place of delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iSfctg1eEeu_4e16J8D_UA")]
[Description(@"Specifies the place of delivery.")]
[Derivations(typeof(DeliveryPlace3Code))]
// External derivations that should be provided by the proper interface are: 
public enum DeliveryPlaceV2Code
{
    /// <summary>
    /// Card needs to be mailed to employer's address.
    /// Encoded/decoded by serializers as "EMPL".
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_iSfctw1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to employer's address.")]
    Employer,
    
    /// <summary>
    /// Card needs to be mailed to the individual specified in PersonDetail.
    /// Encoded/decoded by serializers as "INDI".
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_iSfcuQ1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to the individual specified in PersonDetail.")]
    Individual,
    
    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as "ENTR".
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_iSfcuA1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    MeetingEntrance,
    
    /// <summary>
    /// Cards needs to be send to another specified address.
    /// Encoded/decoded by serializers as "OADR".
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_iSfcuw1eEeu_4e16J8D_UA")]
    [Description(@"Cards needs to be send to another specified address.")]
    OtherAddress,
    
    /// <summary>
    /// Card needs to be sent via e-mail.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_iSfcug1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be sent via e-mail.")]
    Email,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryPlaceV2CodeMetadataExtensions
{
    private static readonly DeliveryPlaceV2CodeDropdownSource _dropdownSource = new DeliveryPlaceV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryPlaceV2CodeDropdownRow GetMetadata(this DeliveryPlaceV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


