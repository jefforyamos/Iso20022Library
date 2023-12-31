﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExposureType11Code.  ISO2002 ID# _pPoQtiW2EeyT3chuyX0PgA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExposureType11CodeDropdownSource"/>.
/// Implements <seealso cref="IExposureType11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pPoQtiW2EeyT3chuyX0PgA")]
public partial class ExposureType11CodeDropdownRow : EnumMetadataItem<ExposureType11Code>, IExposureType11CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExposureType11CodeDropdownRow(ExposureType11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
