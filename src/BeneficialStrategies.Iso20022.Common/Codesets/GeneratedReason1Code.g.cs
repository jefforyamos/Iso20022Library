﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GeneratedReason1Code.  ISO2002 ID# _at8HYdp-Ed-ak6NoX_4Aeg_-1031093704.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the transaction was generated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_at8HYdp-Ed-ak6NoX_4Aeg_-1031093704")]
[Description(@"Specifies the reason why the transaction was generated.")]
[DerivedFrom(typeof(GeneratedReasonCode))]
public enum GeneratedReason1Code
{
    /// <summary>
    /// Transaction has been generated for collateral management purposes.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_at8HYtp-Ed-ak6NoX_4Aeg_-1031093685")]
    [Description(@"Transaction has been generated for collateral management purposes.")]
    CollateralManagement = GeneratedReasonCode.CollateralManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_at8HY9p-Ed-ak6NoX_4Aeg_-1031093661")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without matching operation.")]
    ReturnRefusedDumps = GeneratedReasonCode.ReturnRefusedDumps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated to enable settlement following a shortage of position.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_at8HZNp-Ed-ak6NoX_4Aeg_-1031093660")]
    [Description(@"Transaction has been generated to enable settlement following a shortage of position.")]
    SplitShaping = GeneratedReasonCode.SplitShaping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated by a third party, for example, a central counterparty.
    /// Encoded/decoded by serializers as &quot;THRD&quot;.
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_at8HZdp-Ed-ak6NoX_4Aeg_-1031093644")]
    [Description(@"Transaction has been generated by a third party, for example, a central counterparty.")]
    ThirdParty = GeneratedReasonCode.ThirdParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_at8HZtp-Ed-ak6NoX_4Aeg_-1031093643")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    Transformation = GeneratedReasonCode.Transformation, // same ordinal as derivation source for type conversions
    
}
