﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerOrderCapacity1Code.  ISO2002 ID# _axz6wNp-Ed-ak6NoX_4Aeg_-690589295.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Designation of the capacity of the firm placing the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axz6wNp-Ed-ak6NoX_4Aeg_-690589295")]
[Description(@"Designation of the capacity of the firm placing the order.")]
[DerivedFrom(typeof(CustomerOrderCapacityCode))]
public enum CustomerOrderCapacity1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MemberOwnAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_axz6wdp-Ed-ak6NoX_4Aeg_-1833251929")]
    [Description(@"??")]
    MemberOwnAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearingProprietary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_axz6wtp-Ed-ak6NoX_4Aeg_-1833251887")]
    [Description(@"??")]
    ClearingProprietary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MemberOtherMember".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_axz6w9p-Ed-ak6NoX_4Aeg_-1833251869")]
    [Description(@"??")]
    MemberOtherMember,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustomerOrderCapacity1CodeMetadataExtensions
{
    private static readonly CustomerOrderCapacity1CodeDropdownSource _dropdownSource = new CustomerOrderCapacity1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustomerOrderCapacity1CodeDropdownRow GetMetadata(this CustomerOrderCapacity1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


