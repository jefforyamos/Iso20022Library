﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PensionOrderTypeCode.  ISO2002 ID# _QyyooLTpEeiENt6AoDfPXg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of order attached to a pension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QyyooLTpEeiENt6AoDfPXg")]
[Description(@"Specifies a type of order attached to a pension.")]
[Derivations(typeof(PensionOrderType1Code))]
public enum PensionOrderTypeCode
{
    /// <summary>
    /// Pension policy, plan or scheme has been earmarked (set aside.)
    /// Encoded/decoded by serializers as &quot;EARM&quot;.
    /// </summary>
    [EnumMember(Value = "EARM")]
    [IsoId("_W4DWsLTpEeiENt6AoDfPXg")]
    [Description(@"Pension policy, plan or scheme has been earmarked (set aside.)")]
    Earmark,
    
    /// <summary>
    /// Sharing order for the pension policy, plan or scheme has been issued by a court.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_hgtXcLTpEeiENt6AoDfPXg")]
    [Description(@"Sharing order for the pension policy, plan or scheme has been issued by a court.")]
    Sharing,
    
}
