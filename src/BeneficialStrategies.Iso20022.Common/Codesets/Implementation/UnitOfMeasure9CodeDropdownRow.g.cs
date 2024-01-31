﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnitOfMeasure9Code.  ISO2002 ID# _aSoaEPE_Eee_LsXdoqzkWg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnitOfMeasure9CodeDropdownSource"/>.
/// Implements <seealso cref="IUnitOfMeasure9CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aSoaEPE_Eee_LsXdoqzkWg")]
public partial class UnitOfMeasure9CodeDropdownRow : EnumMetadataItem<UnitOfMeasure9Code>, IUnitOfMeasure9CodeDropdownRow
{
    /// <summary>
    /// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnitOfMeasure9CodeDropdownRow(UnitOfMeasure9Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
