﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DrawdownEventType1Code.  ISO2002 ID# _c--OoFNiEeijdq8ilaxyOA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDrawdownEventType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_c--OoFNiEeijdq8ilaxyOA")]
public partial class DrawdownEventType1CodeDropdownSource : EnumMetadataManager<DrawdownEventType1Code,IDrawdownEventType1CodeDropdownRow,DrawdownEventType1CodeDropdownRow>
{
    public DrawdownEventType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DrawdownEventType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
