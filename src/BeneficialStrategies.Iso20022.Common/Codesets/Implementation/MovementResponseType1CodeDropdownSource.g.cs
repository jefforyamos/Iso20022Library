﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MovementResponseType1Code.  ISO2002 ID# _jQzlhe5NEeCisYr99QEiWA_-503094567.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of movement response to be returned.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMovementResponseType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jQzlhe5NEeCisYr99QEiWA_-503094567")]
public partial class MovementResponseType1CodeDropdownSource : EnumMetadataManager<MovementResponseType1Code,IMovementResponseType1CodeDropdownRow,MovementResponseType1CodeDropdownRow>
{
    public MovementResponseType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MovementResponseType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
