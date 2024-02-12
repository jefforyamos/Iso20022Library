﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceReportFunctionCode.  ISO2002 ID# _bJkrQBl9EeKxsrht2duUcg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the price report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bJkrQBl9EeKxsrht2duUcg")]
[Description(@"Specifies the function of the price report.")]
[Derivations(typeof(PriceReportFunction1Code))]
public enum PriceReportFunctionCode
{
    /// <summary>
    /// The price report is ‘new’, that is the report is not being used as a correction of previously sent prices.
    /// Encoded/decoded by serializers as "NEWP".
    /// </summary>
    [EnumMember(Value = "NEWP")]
    [IsoId("_gOSiUBl9EeKxsrht2duUcg")]
    [Description(@"The price report is ‘new’, that is the report is not being used as a correction of previously sent prices.")]
    NewPriceReport,
    
    /// <summary>
    /// The price report conveys the correction of the complete set of prices previously sent for the same price report identification.
    /// Encoded/decoded by serializers as "REPL".
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_gXEq4Bl9EeKxsrht2duUcg")]
    [Description(@"The price report conveys the correction of the complete set of prices previously sent for the same price report identification.")]
    CompleteReplacementPriceReport,
    
    /// <summary>
    /// The price report conveys the correction of some of the prices previously sent for the same price report identification.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_gfRkoBl9EeKxsrht2duUcg")]
    [Description(@"The price report conveys the correction of some of the prices previously sent for the same price report identification.")]
    PartialCorrectionPriceReport,
    
}
