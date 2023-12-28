﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestRate1Code.  ISO2002 ID# _FENyMDErEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the list of interest rates.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestRate1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FENyMDErEemzCpWiCwK4aQ")]
public partial class InterestRate1CodeDropdownSource : EnumMetadataManager<InterestRate1Code,IInterestRate1CodeDropdownRow,InterestRate1CodeDropdownRow>
{
    public InterestRate1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestRate1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
