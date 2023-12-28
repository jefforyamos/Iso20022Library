﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalTradeMarketCode.  ISO2002 ID# _NzE0NzM1-AOSNFX-5096928.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalTradeMarketCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalTradeMarketCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NzE0NzM1-AOSNFX-5096928")]
public partial class ExternalTradeMarketCodeDropdownRow : EnumMetadataItem<ExternalTradeMarketCode>, IExternalTradeMarketCodeDropdownRow
{
    /// <summary>
    /// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalTradeMarketCodeDropdownRow(ExternalTradeMarketCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}