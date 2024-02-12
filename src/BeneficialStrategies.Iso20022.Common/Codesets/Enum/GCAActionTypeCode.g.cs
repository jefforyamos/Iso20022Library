﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GCAActionTypeCode.  ISO2002 ID# _11ykoDL3EeKU9IrkkToqcw_-1739118980.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies what action needs to be taken by the validation service for this particular record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11ykoDL3EeKU9IrkkToqcw_-1739118980")]
[Description(@"Specifies what action needs to be taken by the validation service for this particular record.")]
[Derivations(typeof(GCAActionType1Code))]
public enum GCAActionTypeCode
{
    /// <summary>
    /// Custodian needs to be contacted.
    /// Encoded/decoded by serializers as "RCON".
    /// </summary>
    [EnumMember(Value = "RCON")]
    [IsoId("_11ykoTL3EeKU9IrkkToqcw_-1534472255")]
    [Description(@"Custodian needs to be contacted.")]
    ContactCustodian,
    
    /// <summary>
    /// Further research is required.
    /// Encoded/decoded by serializers as "FREA".
    /// </summary>
    [EnumMember(Value = "FREA")]
    [IsoId("_11ykojL3EeKU9IrkkToqcw_-97617058")]
    [Description(@"Further research is required.")]
    ResearchRequired,
    
    /// <summary>
    /// Custodian has been contacted.
    /// Encoded/decoded by serializers as "CDCU".
    /// </summary>
    [EnumMember(Value = "CDCU")]
    [IsoId("_11ykozL3EeKU9IrkkToqcw_1512813294")]
    [Description(@"Custodian has been contacted.")]
    CustodianContacted,
    
    /// <summary>
    /// Custodian does not need to be contacted.
    /// Encoded/decoded by serializers as "NQCU".
    /// </summary>
    [EnumMember(Value = "NQCU")]
    [IsoId("_11ykpDL3EeKU9IrkkToqcw_1707445278")]
    [Description(@"Custodian does not need to be contacted.")]
    DoNotContactCustodian,
    
    /// <summary>
    /// No further action is required.
    /// Encoded/decoded by serializers as "NFAC".
    /// </summary>
    [EnumMember(Value = "NFAC")]
    [IsoId("_11ykpTL3EeKU9IrkkToqcw_954466545")]
    [Description(@"No further action is required.")]
    NoFurtherActionRequired,
    
    /// <summary>
    /// Not supported by the GCA VA (Global Corporate Actions Validation service).
    /// Encoded/decoded by serializers as "NSUP".
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_118VoDL3EeKU9IrkkToqcw_1620933391")]
    [Description(@"Not supported by the GCA VA (Global Corporate Actions Validation service).")]
    NotSupportedByGCA,
    
    /// <summary>
    /// Invalid.
    /// Encoded/decoded by serializers as "INVA".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_118VoTL3EeKU9IrkkToqcw_-704666898")]
    [Description(@"Invalid.")]
    Invalid,
    
}
