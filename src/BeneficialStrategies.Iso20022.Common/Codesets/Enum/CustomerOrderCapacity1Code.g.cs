﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerOrderCapacity1Code.  ISO2002 ID# _axz6wNp-Ed-ak6NoX_4Aeg_-690589295.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Member trading for their own account.
    /// Encoded/decoded by serializers as "OWNE".
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_axz6wdp-Ed-ak6NoX_4Aeg_-1833251929")]
    [Description(@"Member trading for their own account.")]
    MemberOwnAccount = CustomerOrderCapacityCode.MemberOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing firm trading for its proprietary account.
    /// Encoded/decoded by serializers as "CLAR".
    /// </summary>
    [EnumMember(Value = "CLAR")]
    [IsoId("_axz6wtp-Ed-ak6NoX_4Aeg_-1833251887")]
    [Description(@"Clearing firm trading for its proprietary account.")]
    ClearingProprietary = CustomerOrderCapacityCode.ClearingProprietary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member trading for another member.
    /// Encoded/decoded by serializers as "OTHM".
    /// </summary>
    [EnumMember(Value = "OTHM")]
    [IsoId("_axz6w9p-Ed-ak6NoX_4Aeg_-1833251869")]
    [Description(@"Member trading for another member.")]
    MemberOtherMember = CustomerOrderCapacityCode.MemberOtherMember, // same ordinal as derivation source for type conversions
    
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


