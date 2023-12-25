﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ESGFocusCode.  ISO2002 ID# _tYWj0M2uEeuAE-cYsQdwHQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if focus will be Environmental, Social or Governance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ESGFocusCodeDropdownSource"/>.
/// Implements <seealso cref="IESGFocusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tYWj0M2uEeuAE-cYsQdwHQ")]
public partial class ESGFocusCodeDropdownRow : EnumMetadataItem<ESGFocusCode>, IESGFocusCodeDropdownRow
{
    /// <summary>
    /// Specifies if focus will be Environmental, Social or Governance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ESGFocusCodeDropdownRow(ESGFocusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
