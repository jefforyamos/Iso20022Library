﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MOTOCode.  ISO2002 ID# _CPEMoDHLEeyTT91yHXSlSQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// A code that identifies the type of MOTO transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MOTOCodeDropdownSource"/>.
/// Implements <seealso cref="IMOTOCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CPEMoDHLEeyTT91yHXSlSQ")]
public partial class MOTOCodeDropdownRow : EnumMetadataItem<MOTOCode>, IMOTOCodeDropdownRow
{
    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MOTOCodeDropdownRow(MOTOCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
