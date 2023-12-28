﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryReturn1Code.  ISO2002 ID# _azTIg9p-Ed-ak6NoX_4Aeg_-1245884336.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of delivery return.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azTIg9p-Ed-ak6NoX_4Aeg_-1245884336")]
[Description(@"Specifies the type of delivery return.")]
[DerivedFrom(typeof(DeliveryReturnCode))]
public enum DeliveryReturn1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnrecognisedDelivery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azTIhNp-Ed-ak6NoX_4Aeg_-959595290")]
    [Description(@"??")]
    UnrecognisedDelivery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WrongQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azTIhdp-Ed-ak6NoX_4Aeg_-917110811")]
    [Description(@"??")]
    WrongQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WrongSettlementAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azTIhtp-Ed-ak6NoX_4Aeg_-872782203")]
    [Description(@"??")]
    WrongSettlementAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartialDelivery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azTIh9p-Ed-ak6NoX_4Aeg_-845078527")]
    [Description(@"??")]
    PartialDelivery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountMissing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azc5gNp-Ed-ak6NoX_4Aeg_-829378346")]
    [Description(@"??")]
    AccountMissing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DueBiillMissing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azc5gdp-Ed-ak6NoX_4Aeg_-573562488")]
    [Description(@"??")]
    DueBiillMissing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartialReturn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_azc5gtp-Ed-ak6NoX_4Aeg_-502450366")]
    [Description(@"??")]
    PartialReturn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryReturn1CodeMetadataExtensions
{
    private static readonly DeliveryReturn1CodeDropdownSource _dropdownSource = new DeliveryReturn1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryReturn1CodeDropdownRow GetMetadata(this DeliveryReturn1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

