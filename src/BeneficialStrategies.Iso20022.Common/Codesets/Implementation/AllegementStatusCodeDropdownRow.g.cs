﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllegementStatusCode.  ISO2002 ID# _bopcI9p-Ed-ak6NoX_4Aeg_241665691.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an allegement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllegementStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IAllegementStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bopcI9p-Ed-ak6NoX_4Aeg_241665691")]
public partial class AllegementStatusCodeDropdownRow : EnumMetadataItem<AllegementStatusCode>, IAllegementStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an allegement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllegementStatusCodeDropdownRow(AllegementStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
