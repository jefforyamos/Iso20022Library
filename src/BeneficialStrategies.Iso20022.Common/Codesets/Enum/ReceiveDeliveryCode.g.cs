﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReceiveDeliveryCode.  ISO2002 ID# _Zafih9p-Ed-ak6NoX_4Aeg_448211310.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the settlement transaction is a delivery or receipt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zafih9p-Ed-ak6NoX_4Aeg_448211310")]
[Description(@"Specifies whether the settlement transaction is a delivery or receipt.")]
[Derivations(typeof(ReceiveDelivery1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ReceiveDeliveryCode
{
    /// <summary>
    /// Financial instruments will be debited from the safekeeping account.
    /// Encoded/decoded by serializers as "DELI".
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_ZafiiNp-Ed-ak6NoX_4Aeg_448211319")]
    [Description(@"Financial instruments will be debited from the safekeeping account.")]
    Delivery,
    
    /// <summary>
    /// Financial instruments will be credited to the safekeeping account.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_ZaoscNp-Ed-ak6NoX_4Aeg_448211335")]
    [Description(@"Financial instruments will be credited to the safekeeping account.")]
    Receive,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReceiveDeliveryCodeMetadataExtensions
{
    private static readonly ReceiveDeliveryCodeDropdownSource _dropdownSource = new ReceiveDeliveryCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReceiveDeliveryCodeDropdownRow GetMetadata(this ReceiveDeliveryCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


