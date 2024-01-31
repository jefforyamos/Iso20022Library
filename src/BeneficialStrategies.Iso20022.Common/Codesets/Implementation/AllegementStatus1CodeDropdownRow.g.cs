﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllegementStatus1Code.  ISO2002 ID# _bopcINp-Ed-ak6NoX_4Aeg_611998730.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an allegement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllegementStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IAllegementStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bopcINp-Ed-ak6NoX_4Aeg_611998730")]
public partial class AllegementStatus1CodeDropdownRow : EnumMetadataItem<AllegementStatus1Code>, IAllegementStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an allegement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllegementStatus1CodeDropdownRow(AllegementStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
