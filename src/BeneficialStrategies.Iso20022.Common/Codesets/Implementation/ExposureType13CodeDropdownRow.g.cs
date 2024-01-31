﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExposureType13Code.  ISO2002 ID# _pr4gLCgtEeyB747fKu7_rw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the exposure.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExposureType13CodeDropdownSource"/>.
/// Implements <seealso cref="IExposureType13CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pr4gLCgtEeyB747fKu7_rw")]
public partial class ExposureType13CodeDropdownRow : EnumMetadataItem<ExposureType13Code>, IExposureType13CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExposureType13CodeDropdownRow(ExposureType13Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
