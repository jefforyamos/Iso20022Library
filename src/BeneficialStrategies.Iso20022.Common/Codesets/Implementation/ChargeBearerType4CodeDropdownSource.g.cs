﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeBearerType4Code.  ISO2002 ID# _XaGi3_WfEemtd4wHZYvFUQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeBearerType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XaGi3_WfEemtd4wHZYvFUQ")]
public partial class ChargeBearerType4CodeDropdownSource : EnumMetadataManager<ChargeBearerType4Code,IChargeBearerType4CodeDropdownRow,ChargeBearerType4CodeDropdownRow>
{
    public ChargeBearerType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeBearerType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
