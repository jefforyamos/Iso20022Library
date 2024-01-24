﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GeneratedReason2Code.  ISO2002 ID# _at8HZ9p-Ed-ak6NoX_4Aeg_-881331299.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction was generated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_at8HZ9p-Ed-ak6NoX_4Aeg_-881331299")]
[Description(@"Specifies the reason why the transaction was generated.")]
[DerivedFrom(typeof(GeneratedReasonCode))]
public enum GeneratedReason2Code
{
    /// <summary>
    /// Transaction has been generated for collateral management purposes.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_at8HaNp-Ed-ak6NoX_4Aeg_2010639743")]
    [Description(@"Transaction has been generated for collateral management purposes.")]
    CollateralManagement = GeneratedReasonCode.CollateralManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as "RODE".
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_auFRUNp-Ed-ak6NoX_4Aeg_-347102380")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without matching operation.")]
    ReturnRefusedDumps = GeneratedReasonCode.ReturnRefusedDumps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated to enable settlement following a shortage of position.
    /// Encoded/decoded by serializers as "SPLI".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_auFRUdp-Ed-ak6NoX_4Aeg_-1231892577")]
    [Description(@"Transaction has been generated to enable settlement following a shortage of position.")]
    SplitShaping = GeneratedReasonCode.SplitShaping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated by a third party, for example, a central counterparty.
    /// Encoded/decoded by serializers as "THRD".
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_auFRUtp-Ed-ak6NoX_4Aeg_705332596")]
    [Description(@"Transaction has been generated by a third party, for example, a central counterparty.")]
    ThirdParty = GeneratedReasonCode.ThirdParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_auFRU9p-Ed-ak6NoX_4Aeg_-153872239")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    Transformation = GeneratedReasonCode.Transformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_auFRVNp-Ed-ak6NoX_4Aeg_432074787")]
    [Description(@"Other. See Narrative.")]
    Other = GeneratedReasonCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GeneratedReason2CodeMetadataExtensions
{
    private static readonly GeneratedReason2CodeDropdownSource _dropdownSource = new GeneratedReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGeneratedReason2CodeDropdownRow GetMetadata(this GeneratedReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


