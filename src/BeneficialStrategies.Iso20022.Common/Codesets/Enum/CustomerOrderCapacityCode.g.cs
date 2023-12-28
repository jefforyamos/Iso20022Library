﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerOrderCapacityCode.  ISO2002 ID# _axz6xNp-Ed-ak6NoX_4Aeg_335336023.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Designation of the capacity of the firm placing the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axz6xNp-Ed-ak6NoX_4Aeg_335336023")]
[Description(@"Designation of the capacity of the firm placing the order.")]
public enum CustomerOrderCapacityCode
{
    /// <summary>
    /// Member trading for their own account.
    /// Encoded/decoded by serializers as "OWNE".
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_axz6xdp-Ed-ak6NoX_4Aeg_335336024")]
    [Description(@"Member trading for their own account.")]
    MemberOwnAccount,
    
    /// <summary>
    /// Clearing firm trading for its proprietary account.
    /// Encoded/decoded by serializers as "CLAR".
    /// </summary>
    [EnumMember(Value = "CLAR")]
    [IsoId("_axz6xtp-Ed-ak6NoX_4Aeg_335336025")]
    [Description(@"Clearing firm trading for its proprietary account.")]
    ClearingProprietary,
    
    /// <summary>
    /// Member trading for another member.
    /// Encoded/decoded by serializers as "OTHM".
    /// </summary>
    [EnumMember(Value = "OTHM")]
    [IsoId("_axz6x9p-Ed-ak6NoX_4Aeg_335336026")]
    [Description(@"Member trading for another member.")]
    MemberOtherMember,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustomerOrderCapacityCodeMetadataExtensions
{
    private static readonly CustomerOrderCapacityCodeDropdownSource _dropdownSource = new CustomerOrderCapacityCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustomerOrderCapacityCodeDropdownRow GetMetadata(this CustomerOrderCapacityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


