﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialCapture1Code.  ISO2002 ID# _KR_d8H1DEeCF8NjrBemJWQ_1904132354.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Mode for the financial capture of the transaction by the acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KR_d8H1DEeCF8NjrBemJWQ_1904132354")]
[Description(@"Mode for the financial capture of the transaction by the acquirer.")]
[DerivedFrom(typeof(FinancialCaptureCode))]
public enum FinancialCapture1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Authorisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KR_d8X1DEeCF8NjrBemJWQ_-344306152")]
    [Description(@"??")]
    Authorisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Completion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KR_d8n1DEeCF8NjrBemJWQ_1190732522")]
    [Description(@"??")]
    Completion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Batch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KR_d831DEeCF8NjrBemJWQ_-1673145279")]
    [Description(@"??")]
    Batch,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialCapture1CodeMetadataExtensions
{
    private static readonly FinancialCapture1CodeDropdownSource _dropdownSource = new FinancialCapture1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialCapture1CodeDropdownRow GetMetadata(this FinancialCapture1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


