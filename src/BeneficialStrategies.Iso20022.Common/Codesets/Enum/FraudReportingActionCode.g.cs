﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FraudReportingActionCode.  ISO2002 ID# _ndM2AHbBEeef9c2nwgY9Xw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of fraud reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ndM2AHbBEeef9c2nwgY9Xw")]
[Description(@"Type of fraud reporting.")]
public enum FraudReportingActionCode
{
    /// <summary>
    /// New fraud information not reported yet.
    /// </summary>
    [EnumMember(Value = "NEWF")]
    [IsoId("_r0wFEHbBEeef9c2nwgY9Xw")]
    [Description(@"New fraud information not reported yet.")]
    NEWF,
    
    /// <summary>
    /// Fraud information already reported.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_xA9rQHbBEeef9c2nwgY9Xw")]
    [Description(@"Fraud information already reported.")]
    DUPL,
    
    /// <summary>
    /// Update information about a fraud already reported.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_4nmFcHbBEeef9c2nwgY9Xw")]
    [Description(@"Update information about a fraud already reported.")]
    UPDT,
    
    /// <summary>
    /// Closing a previously reported fraud.
    /// </summary>
    [EnumMember(Value = "CLSE")]
    [IsoId("_JaL44HbCEeef9c2nwgY9Xw")]
    [Description(@"Closing a previously reported fraud.")]
    CLSE,
    
    /// <summary>
    /// Reopen a previously closed reported fraud case
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_VzYqMHbCEeef9c2nwgY9Xw")]
    [Description(@"Reopen a previously closed reported fraud case")]
    REOP,
    
    /// <summary>
    /// Other process about a fraud already reported defined at national level.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_d5f1sHbCEeef9c2nwgY9Xw")]
    [Description(@"Other process about a fraud already reported defined at national level.")]
    OTHN,
    
    /// <summary>
    /// Other process about a fraud already reported defined at private level.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_meJ-YHbCEeef9c2nwgY9Xw")]
    [Description(@"Other process about a fraud already reported defined at private level.")]
    OTHP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FraudReportingActionCodeMetadataExtensions
{
    private static readonly FraudReportingActionCodeDropdownSource _dropdownSource = new FraudReportingActionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFraudReportingActionCodeDropdownRow GetMetadata(this FraudReportingActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


