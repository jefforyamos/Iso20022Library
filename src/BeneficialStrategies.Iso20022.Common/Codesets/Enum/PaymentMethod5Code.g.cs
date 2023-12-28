﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentMethod5Code.  ISO2002 ID# _Vr6_BNp-Ed-ak6NoX_4Aeg_445510957.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer method that will be used to transfer an amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vr6_BNp-Ed-ak6NoX_4Aeg_445510957")]
[Description(@"Specifies the transfer method that will be used to transfer an amount of money.")]
[DerivedFrom(typeof(PaymentMethodCode))]
public enum PaymentMethod5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vr6_Bdp-Ed-ak6NoX_4Aeg_869407428")]
    [Description(@"??")]
    CreditTransfer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentMethod5CodeMetadataExtensions
{
    private static readonly PaymentMethod5CodeDropdownSource _dropdownSource = new PaymentMethod5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentMethod5CodeDropdownRow GetMetadata(this PaymentMethod5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


