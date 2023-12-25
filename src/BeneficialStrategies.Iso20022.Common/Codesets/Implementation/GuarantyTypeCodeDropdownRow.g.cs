﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GuarantyTypeCode.  ISO2002 ID# _au04N9p-Ed-ak6NoX_4Aeg_1142175847.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of credit enhancement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GuarantyTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IGuarantyTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_au04N9p-Ed-ak6NoX_4Aeg_1142175847")]
public partial class GuarantyTypeCodeDropdownRow : EnumMetadataItem<GuarantyTypeCode>, IGuarantyTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of credit enhancement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GuarantyTypeCodeDropdownRow(GuarantyTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
