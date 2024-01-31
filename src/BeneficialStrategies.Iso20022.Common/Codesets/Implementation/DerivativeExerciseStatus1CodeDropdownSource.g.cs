﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DerivativeExerciseStatus1Code.  ISO2002 ID# _QJkDQIAxEeSUJZYcWGKkkw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the exercise status of the derivative products.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDerivativeExerciseStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QJkDQIAxEeSUJZYcWGKkkw")]
public partial class DerivativeExerciseStatus1CodeDropdownSource : EnumMetadataManager<DerivativeExerciseStatus1Code,IDerivativeExerciseStatus1CodeDropdownRow,DerivativeExerciseStatus1CodeDropdownRow>
{
    public DerivativeExerciseStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DerivativeExerciseStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
