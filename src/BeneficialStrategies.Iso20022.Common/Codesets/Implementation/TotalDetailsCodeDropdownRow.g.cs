﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TotalDetailsCode.  ISO2002 ID# _uDmwIN6SEeiwsev40qZGEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TotalDetailsCodeDropdownSource"/>.
/// Implements <seealso cref="ITotalDetailsCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uDmwIN6SEeiwsev40qZGEQ")]
public partial class TotalDetailsCodeDropdownRow : EnumMetadataItem<TotalDetailsCode>, ITotalDetailsCodeDropdownRow
{
    /// <summary>
    /// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TotalDetailsCodeDropdownRow(TotalDetailsCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
