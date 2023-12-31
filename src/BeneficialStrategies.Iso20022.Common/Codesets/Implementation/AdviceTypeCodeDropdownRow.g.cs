﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AdviceTypeCode.  ISO2002 ID# _AuwW8NomEembTrt_WixjyQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of advice to provide back in the report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AdviceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAdviceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AuwW8NomEembTrt_WixjyQ")]
public partial class AdviceTypeCodeDropdownRow : EnumMetadataItem<AdviceTypeCode>, IAdviceTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of advice to provide back in the report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AdviceTypeCodeDropdownRow(AdviceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
