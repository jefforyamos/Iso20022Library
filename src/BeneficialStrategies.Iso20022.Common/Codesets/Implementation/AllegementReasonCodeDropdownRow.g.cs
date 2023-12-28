﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllegementReasonCode.  ISO2002 ID# __0Jx0dojEeC60axPepSq7g_-2133812073.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has an allegement status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllegementReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IAllegementReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__0Jx0dojEeC60axPepSq7g_-2133812073")]
public partial class AllegementReasonCodeDropdownRow : EnumMetadataItem<AllegementReasonCode>, IAllegementReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction has an allegement status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllegementReasonCodeDropdownRow(AllegementReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}