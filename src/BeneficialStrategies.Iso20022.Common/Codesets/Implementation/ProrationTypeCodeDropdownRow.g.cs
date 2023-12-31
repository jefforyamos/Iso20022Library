﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProrationTypeCode.  ISO2002 ID# _EDgcgDFrEeGKkIZzgd38VA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// TSE/JASDEC extension codes for the specific use of pro ration.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProrationTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IProrationTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EDgcgDFrEeGKkIZzgd38VA")]
public partial class ProrationTypeCodeDropdownRow : EnumMetadataItem<ProrationTypeCode>, IProrationTypeCodeDropdownRow
{
    /// <summary>
    /// TSE/JASDEC extension codes for the specific use of pro ration.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProrationTypeCodeDropdownRow(ProrationTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
