﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartialSettlementCode.  ISO2002 ID# _ZxlM09p-Ed-ak6NoX_4Aeg_1795335735.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about partial settlement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxlM09p-Ed-ak6NoX_4Aeg_1795335735")]
[Description(@"Information about partial settlement.")]
[Derivations(typeof(PartialSettlement1Code))]
public enum PartialSettlementCode
{
    /// <summary>
    /// Confirmation is for partial settlement. Part of the transaction remains unsettled.
    /// Encoded/decoded by serializers as "PAIN".
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_ZxlM1Np-Ed-ak6NoX_4Aeg_2123185009")]
    [Description(@"Confirmation is for partial settlement. Part of the transaction remains unsettled.")]
    PartialSettlement,
    
    /// <summary>
    /// Confirmation is for the remaining part of an instruction that was previously partially confirmed.
    /// Encoded/decoded by serializers as "PARC".
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_ZxlM1dp-Ed-ak6NoX_4Aeg_-1731260987")]
    [Description(@"Confirmation is for the remaining part of an instruction that was previously partially confirmed.")]
    PreviouslyPartialConfirmed,
    
}
