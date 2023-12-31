﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnderlyingProductIdentifier1Code.  ISO2002 ID# _-ZqKICjmEeK1Sbo8NpBROA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnderlyingProductIdentifier1CodeDropdownSource"/>.
/// Implements <seealso cref="IUnderlyingProductIdentifier1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-ZqKICjmEeK1Sbo8NpBROA")]
public partial class UnderlyingProductIdentifier1CodeDropdownRow : EnumMetadataItem<UnderlyingProductIdentifier1Code>, IUnderlyingProductIdentifier1CodeDropdownRow
{
    /// <summary>
    /// Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnderlyingProductIdentifier1CodeDropdownRow(UnderlyingProductIdentifier1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
