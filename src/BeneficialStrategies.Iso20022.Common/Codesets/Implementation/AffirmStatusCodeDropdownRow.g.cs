﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AffirmStatusCode.  ISO2002 ID# _wZYWYESsEeSTS-T7FO4CUQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of the confirmation acknowledgement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AffirmStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IAffirmStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wZYWYESsEeSTS-T7FO4CUQ")]
public partial class AffirmStatusCodeDropdownRow : EnumMetadataItem<AffirmStatusCode>, IAffirmStatusCodeDropdownRow
{
    /// <summary>
    /// Identifies the status of the confirmation acknowledgement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AffirmStatusCodeDropdownRow(AffirmStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
