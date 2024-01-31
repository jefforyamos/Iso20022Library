﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesSettlementStatus3Code.  ISO2002 ID# _WfglwMX-EeiSF9q-coWegA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of settlement of an instruction expressed as a code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesSettlementStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WfglwMX-EeiSF9q-coWegA")]
public partial class SecuritiesSettlementStatus3CodeDropdownSource : EnumMetadataManager<SecuritiesSettlementStatus3Code,ISecuritiesSettlementStatus3CodeDropdownRow,SecuritiesSettlementStatus3CodeDropdownRow>
{
    public SecuritiesSettlementStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesSettlementStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
