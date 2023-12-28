﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MemberType1Code.  ISO2002 ID# _aLqgx9p-Ed-ak6NoX_4Aeg_977880707.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLqgx9p-Ed-ak6NoX_4Aeg_977880707")]
[Description(@"Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.")]
[DerivedFrom(typeof(MemberTypeCode))]
public enum MemberType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Direct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLqgyNp-Ed-ak6NoX_4Aeg_977880716")]
    [Description(@"??")]
    Direct,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Indirect".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLzqsNp-Ed-ak6NoX_4Aeg_977880717")]
    [Description(@"??")]
    Indirect,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Remote".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLzqsdp-Ed-ak6NoX_4Aeg_977880718")]
    [Description(@"??")]
    Remote,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EURO1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLzqstp-Ed-ak6NoX_4Aeg_977880719")]
    [Description(@"??")]
    EURO1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "STEP1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLzqs9p-Ed-ak6NoX_4Aeg_977880720")]
    [Description(@"??")]
    STEP1,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MemberType1CodeMetadataExtensions
{
    private static readonly MemberType1CodeDropdownSource _dropdownSource = new MemberType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMemberType1CodeDropdownRow GetMetadata(this MemberType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

