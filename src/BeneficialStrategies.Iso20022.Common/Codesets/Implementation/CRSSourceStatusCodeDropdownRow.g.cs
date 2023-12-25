﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CRSSourceStatusCode.  ISO2002 ID# _kOZ0kENsEeaS-NnwLNvMPg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the source of Common Reporting Standard (CRS) status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CRSSourceStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ICRSSourceStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kOZ0kENsEeaS-NnwLNvMPg")]
public partial class CRSSourceStatusCodeDropdownRow : EnumMetadataItem<CRSSourceStatusCode>, ICRSSourceStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the source of Common Reporting Standard (CRS) status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CRSSourceStatusCodeDropdownRow(CRSSourceStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
