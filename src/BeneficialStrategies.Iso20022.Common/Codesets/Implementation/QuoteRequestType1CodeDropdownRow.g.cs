﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QuoteRequestType1Code.  ISO2002 ID# _ZX9L4dp-Ed-ak6NoX_4Aeg_244698019.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of quote request (e.g. manual vs. automatic) being generated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QuoteRequestType1CodeDropdownSource"/>.
/// Implements <seealso cref="IQuoteRequestType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZX9L4dp-Ed-ak6NoX_4Aeg_244698019")]
public partial class QuoteRequestType1CodeDropdownRow : EnumMetadataItem<QuoteRequestType1Code>, IQuoteRequestType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the type of quote request (e.g. manual vs. automatic) being generated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QuoteRequestType1CodeDropdownRow(QuoteRequestType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}