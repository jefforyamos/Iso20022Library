﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OvernightIndexSwapTypeCode.  ISO2002 ID# _yb-YIbu8EeSXxOgurgHGgw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of overnight index swap transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yb-YIbu8EeSXxOgurgHGgw")]
[Description(@"Specifies the type of overnight index swap transaction.")]
[Derivations(typeof(OvernightIndexSwapType1Code))]
public enum OvernightIndexSwapTypeCode
{
    /// <summary>
    /// Fixed interest rate is paid by the reporting agent.
    /// Encoded/decoded by serializers as "PAID".
    /// </summary>
    [EnumMember(Value = "PAID")]
    [IsoId("_82nLALu8EeSXxOgurgHGgw")]
    [Description(@"Fixed interest rate is paid by the reporting agent.")]
    Paid,
    
    /// <summary>
    /// Fixed interest rate is received by the reporting agent.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_9D2VwLu8EeSXxOgurgHGgw")]
    [Description(@"Fixed interest rate is received by the reporting agent.")]
    Received,
    
}
