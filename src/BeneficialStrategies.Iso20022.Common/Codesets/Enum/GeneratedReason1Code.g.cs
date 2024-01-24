﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GeneratedReason1Code.  ISO2002 ID# _at8HYdp-Ed-ak6NoX_4Aeg_-1031093704.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_at8HYtp-Ed-ak6NoX_4Aeg_-1031093685")]
    [Description(@"Transaction has been generated for collateral management purposes.")]
    CollateralManagement = GeneratedReasonCode.CollateralManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as "RODE".
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_at8HY9p-Ed-ak6NoX_4Aeg_-1031093661")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without matching operation.")]
    ReturnRefusedDumps = GeneratedReasonCode.ReturnRefusedDumps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated to enable settlement following a shortage of position.
    /// Encoded/decoded by serializers as "SPLI".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_at8HZNp-Ed-ak6NoX_4Aeg_-1031093660")]
    [Description(@"Transaction has been generated to enable settlement following a shortage of position.")]
    SplitShaping = GeneratedReasonCode.SplitShaping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated by a third party, for example, a central counterparty.
    /// Encoded/decoded by serializers as "THRD".
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_at8HZdp-Ed-ak6NoX_4Aeg_-1031093644")]
    [Description(@"Transaction has been generated by a third party, for example, a central counterparty.")]
    ThirdParty = GeneratedReasonCode.ThirdParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_at8HZtp-Ed-ak6NoX_4Aeg_-1031093643")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    Transformation = GeneratedReasonCode.Transformation, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GeneratedReason1CodeMetadataExtensions
{
    private static readonly GeneratedReason1CodeDropdownSource _dropdownSource = new GeneratedReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGeneratedReason1CodeDropdownRow GetMetadata(this GeneratedReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


