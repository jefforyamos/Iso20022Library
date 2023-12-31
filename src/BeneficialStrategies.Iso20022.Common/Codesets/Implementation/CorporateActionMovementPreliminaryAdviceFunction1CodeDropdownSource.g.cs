﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionMovementPreliminaryAdviceFunction1Code.  ISO2002 ID# _IQ0_YDQUEe2o-K1dwNg8Gg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionMovementPreliminaryAdviceFunction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IQ0_YDQUEe2o-K1dwNg8Gg")]
public partial class CorporateActionMovementPreliminaryAdviceFunction1CodeDropdownSource : EnumMetadataManager<CorporateActionMovementPreliminaryAdviceFunction1Code,ICorporateActionMovementPreliminaryAdviceFunction1CodeDropdownRow,CorporateActionMovementPreliminaryAdviceFunction1CodeDropdownRow>
{
    public CorporateActionMovementPreliminaryAdviceFunction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionMovementPreliminaryAdviceFunction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
