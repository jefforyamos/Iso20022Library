﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ObligationType1Code.  ISO2002 ID# _YZ95oNp-Ed-ak6NoX_4Aeg_-465800539.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the obligation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ObligationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IObligationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZ95oNp-Ed-ak6NoX_4Aeg_-465800539")]
public partial class ObligationType1CodeDropdownRow : EnumMetadataItem<ObligationType1Code>, IObligationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the obligation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ObligationType1CodeDropdownRow(ObligationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
