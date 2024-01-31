﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminationReason1Code.  ISO2002 ID# _0mEXMHyiEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the termination reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mEXMHyiEeGWJuGCfvwOsQ")]
[Description(@"Specifies the termination reason.")]
[DerivedFrom(typeof(TerminationReasonCode))]
public enum TerminationReason1Code
{
    /// <summary>
    /// Reason for termination is reduction terms have been fulfilled.
    /// Encoded/decoded by serializers as "REFU".
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_946n4RSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is reduction terms have been fulfilled.")]
    ReductionTermsFulfilled = TerminationReasonCode.ReductionTermsFulfilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for termination is non-acceptance of a tender.
    /// Encoded/decoded by serializers as "NOAC".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_-CKDcRSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is non-acceptance of a tender.")]
    TenderNonAcceptance = TerminationReasonCode.TenderNonAcceptance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for termination is underlying business has finished.
    /// Encoded/decoded by serializers as "BUFI".
    /// </summary>
    [EnumMember(Value = "BUFI")]
    [IsoId("_-NLnsRSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is underlying business has finished.")]
    UnderlyingBusinessFinished = TerminationReasonCode.UnderlyingBusinessFinished, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for termination is warranty obligation period has expired.
    /// Encoded/decoded by serializers as "WOEX".
    /// </summary>
    [EnumMember(Value = "WOEX")]
    [IsoId("_-Yp34RSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is warranty obligation period has expired.")]
    WarrantyObligationPeriodExpired = TerminationReasonCode.WarrantyObligationPeriodExpired, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminationReason1CodeMetadataExtensions
{
    private static readonly TerminationReason1CodeDropdownSource _dropdownSource = new TerminationReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminationReason1CodeDropdownRow GetMetadata(this TerminationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


