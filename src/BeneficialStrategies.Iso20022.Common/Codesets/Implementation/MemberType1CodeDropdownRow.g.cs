﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MemberType1Code.  ISO2002 ID# _aLqgx9p-Ed-ak6NoX_4Aeg_977880707.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MemberType1CodeDropdownSource"/>.
/// Implements <seealso cref="IMemberType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aLqgx9p-Ed-ak6NoX_4Aeg_977880707")]
public partial class MemberType1CodeDropdownRow : EnumMetadataItem<MemberType1Code>, IMemberType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MemberType1CodeDropdownRow(MemberType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
