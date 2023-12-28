﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FrankingClass1Code.  ISO2002 ID# _yOyeMFfuEeOuDtoQo1qilA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code defining the dvidend / distribution class where this franking information applies to.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FrankingClass1CodeDropdownSource"/>.
/// Implements <seealso cref="IFrankingClass1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yOyeMFfuEeOuDtoQo1qilA")]
public partial class FrankingClass1CodeDropdownRow : EnumMetadataItem<FrankingClass1Code>, IFrankingClass1CodeDropdownRow
{
    /// <summary>
    /// Code defining the dvidend / distribution class where this franking information applies to.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FrankingClass1CodeDropdownRow(FrankingClass1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
