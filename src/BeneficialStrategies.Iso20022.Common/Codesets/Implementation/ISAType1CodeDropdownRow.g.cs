﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ISAType1Code.  ISO2002 ID# _adZJ-Np-Ed-ak6NoX_4Aeg_948801052.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current year ISA.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ISAType1CodeDropdownSource"/>.
/// Implements <seealso cref="IISAType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_adZJ-Np-Ed-ak6NoX_4Aeg_948801052")]
public partial class ISAType1CodeDropdownRow : EnumMetadataItem<ISAType1Code>, IISAType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the current year ISA.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ISAType1CodeDropdownRow(ISAType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
