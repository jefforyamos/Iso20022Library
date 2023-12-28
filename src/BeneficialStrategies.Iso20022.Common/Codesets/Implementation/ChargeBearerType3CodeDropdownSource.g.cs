﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeBearerType3Code.  ISO2002 ID# _he7u0KXeEeaBtJ1HvhzRtg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeBearerType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_he7u0KXeEeaBtJ1HvhzRtg")]
public partial class ChargeBearerType3CodeDropdownSource : EnumMetadataManager<ChargeBearerType3Code,IChargeBearerType3CodeDropdownRow,ChargeBearerType3CodeDropdownRow>
{
    public ChargeBearerType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeBearerType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}