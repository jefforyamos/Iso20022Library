﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LinkageType1Code.  ISO2002 ID# _ae4Xttp-Ed-ak6NoX_4Aeg_-2003821143.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of linkage requested.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LinkageType1CodeDropdownSource"/>.
/// Implements <seealso cref="ILinkageType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ae4Xttp-Ed-ak6NoX_4Aeg_-2003821143")]
public partial class LinkageType1CodeDropdownRow : EnumMetadataItem<LinkageType1Code>, ILinkageType1CodeDropdownRow
{
    /// <summary>
    /// Type of linkage requested.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LinkageType1CodeDropdownRow(LinkageType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
