﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustodianRecordAgreementTypeCode.  ISO2002 ID# _11V4tDL3EeKU9IrkkToqcw_-319409576.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of the agreement of the custodian record when compared to composite record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11V4tDL3EeKU9IrkkToqcw_-319409576")]
[Description(@"Specifies the state of the agreement of the custodian record when compared to composite record.")]
[Derivations(typeof(CustodianRecordAgreementType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CustodianRecordAgreementTypeCode
{
    /// <summary>
    /// Custodian record agrees with the composite record.
    /// Encoded/decoded by serializers as "AGRE".
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_11V4tTL3EeKU9IrkkToqcw_1633271504")]
    [Description(@"Custodian record agrees with the composite record.")]
    Agree,
    
    /// <summary>
    /// Custodian record disagrees with the composite record.
    /// Encoded/decoded by serializers as "DAGR".
    /// </summary>
    [EnumMember(Value = "DAGR")]
    [IsoId("_11V4tjL3EeKU9IrkkToqcw_429712966")]
    [Description(@"Custodian record disagrees with the composite record.")]
    Disagree,
    
    /// <summary>
    /// No composite record available.
    /// Encoded/decoded by serializers as "NCOP".
    /// </summary>
    [EnumMember(Value = "NCOP")]
    [IsoId("_11fpsDL3EeKU9IrkkToqcw_-729360725")]
    [Description(@"No composite record available.")]
    NoComposite,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustodianRecordAgreementTypeCodeMetadataExtensions
{
    private static readonly CustodianRecordAgreementTypeCodeDropdownSource _dropdownSource = new CustodianRecordAgreementTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustodianRecordAgreementTypeCodeDropdownRow GetMetadata(this CustodianRecordAgreementTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


